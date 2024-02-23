using System.Net.Http;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Headers;

using Newtonsoft.Json;

using EVEOnline.ESI.Communication.Attributes;
using EVEOnline.ESI.Communication.Utilities;

namespace EVEOnline.ESI.Communication.Handlers
{
    public class ProtectionHandler : IHandler
    {
        private readonly IAccessTokenProvider _accessTokenProvider;
        private readonly IScopeAccessValidator _scopeAccessValidator;

        public ProtectionHandler() : this(null, null)
        { }

        public ProtectionHandler(IAccessTokenProvider accessTokenProvider) : this(accessTokenProvider, null)
        {}

        public ProtectionHandler(IAccessTokenProvider accessTokenProvider, IScopeAccessValidator scopeAccessValidator)
        {
            _accessTokenProvider = accessTokenProvider;
            _scopeAccessValidator = scopeAccessValidator;
        }

        public async Task HandleAsync(EsiContext context, RequestDelegate next)
        {
            var isPublic = await IsPublicEndpoint(context);

            if (isPublic)
            {
                await next.Invoke(context);
            }
            else
            {
                await ValidateScope(context);
                await SetAuthHeader(context);

                if (CanContinue(context))
                {
                    await next.Invoke(context);
                }
                else
                {
                    return;
                }
            }
        }

        protected virtual Task<bool> IsPublicEndpoint(EsiContext context)
        {
            var isPublic = ReflectionCacheAttributeAccessor.Instance.ContainsAttribute<PublicEndpointAttribute>(context.CallingContext.MethodInfo);

            return Task.FromResult(isPublic);
        }

        protected virtual async Task ValidateScope(EsiContext context)
        {
            var protectedEnpointAttribute = ReflectionCacheAttributeAccessor.Instance.GetAttribute<ProtectedEndpointAttribute>(context.CallingContext.MethodInfo);

            if (_scopeAccessValidator != null && !string.IsNullOrEmpty(protectedEnpointAttribute.RequiredScope))
            {
                var allowed =  await _scopeAccessValidator.VerifyScopeAccess(protectedEnpointAttribute.RequiredScope);

                if (!allowed)
                {
                    UnauthorizedResponse(context, HttpStatusCode.Forbidden, $"token is not valid for scope: {protectedEnpointAttribute.RequiredScope}");
                }
            }
        }

        protected virtual async Task SetAuthHeader(EsiContext context)
        {
            if (!CanContinue(context)) return;
            
            var token = await _accessTokenProvider.GetAccessToken();

            if (string.IsNullOrEmpty(token))
            {
                UnauthorizedResponse(context, HttpStatusCode.Unauthorized, "The request endpoint requires SSO authentication and a token has not been provided.");
            }
            else
            {
                context.HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            }
        }

        protected void UnauthorizedResponse(EsiContext context, HttpStatusCode httpStatusCode, string errorMessage)
        {
            context.SetHttpResponseMessage(new HttpResponseMessage(httpStatusCode)
            {
                Content = new StringContent(JsonConvert.SerializeObject(new { error = errorMessage }), Encoding.UTF8, "application/json")
            });
        }

        protected bool CanContinue(EsiContext context) => context.Response == null;
    }
}
