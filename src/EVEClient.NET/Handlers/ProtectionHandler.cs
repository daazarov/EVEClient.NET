using System.Net.Http;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Headers;

using Newtonsoft.Json;

using EVEClient.NET.Attributes;
using EVEClient.NET.Utilities;
using EVEClient.NET.Pipline;

namespace EVEClient.NET.Handlers
{
    public class ProtectionHandler : IHandler
    {
        private readonly IAccessTokenProvider _accessTokenProvider;
        private readonly IScopeAccessValidator _scopeAccessValidator;

        public ProtectionHandler(IAccessTokenProvider accessTokenProvider, IScopeAccessValidator scopeAccessValidator)
        {
            _accessTokenProvider = accessTokenProvider;
            _scopeAccessValidator = scopeAccessValidator;
        }

        public async Task HandleAsync(EsiContext context, RequestDelegate next)
        {
            if (IsPublicEndpoint(context))
            {
                await next.Invoke(context);
            }
            else
            {
                var tokenResult = await _accessTokenProvider.RequestAccessToken();

                if (string.IsNullOrEmpty(tokenResult))
                {
                    UnauthorizedResponse(context, HttpStatusCode.Unauthorized, $"The request endpoint requires SSO authentication and a token has not been provided.");
                }

                await ValidateScope(context, tokenResult);
                await SetAuthorizationHeader(context, tokenResult);

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

        protected virtual async Task ValidateScope(EsiContext context, string token)
        {
            if (CanContinue(context))
            {
                var protectedEnpointAttribute = ReflectionCacheAttributeAccessor.Instance.GetAttribute<ProtectedEndpointAttribute>(context.EndpointMarker.AsMethodInfo());

                var allowed = await _scopeAccessValidator.ValidateScopeAccess(token, protectedEnpointAttribute.RequiredScope);

                if (!allowed)
                {
                    UnauthorizedResponse(context, HttpStatusCode.Forbidden, $"Token is not valid for scope: {protectedEnpointAttribute.RequiredScope}");
                }
            }
        }

        protected virtual Task SetAuthorizationHeader(EsiContext context, string token)
        {
            if (CanContinue(context))
            {
                context.HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            }

            return Task.CompletedTask;
        }

        protected void UnauthorizedResponse(EsiContext context, HttpStatusCode httpStatusCode, string errorMessage)
        {
            context.SetHttpResponseMessage(new HttpResponseMessage(httpStatusCode)
            {
                Content = new StringContent(JsonConvert.SerializeObject(new { error = errorMessage }), Encoding.UTF8, "application/json")
            });
        }

        private bool CanContinue(EsiContext context) => 
            context.Response == null;

        private bool IsPublicEndpoint(EsiContext context) =>
            ReflectionCacheAttributeAccessor.Instance.ContainsAttribute<PublicEndpointAttribute>(context.EndpointMarker.AsMethodInfo());
    }
}
