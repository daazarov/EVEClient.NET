using System;
using System.Net.Http;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

using EVEClient.NET.Attributes;
using EVEClient.NET.Utilities;
using EVEClient.NET.Pipline;
using EVEClient.NET.Extensions;

namespace EVEClient.NET.Handlers
{
    /// <summary>
    /// Performs getting the access token from IAccessTokenProvider or input parameter, validates scope, and sets the Authorization header
    /// </summary>
    public class ProtectionHandler : IHandler
    {
        private readonly IAccessTokenProvider? _accessTokenProvider;
        private readonly IScopeAccessValidator? _scopeAccessValidator;

        public ProtectionHandler(IScopeAccessValidator? scopeAccessValidator = null, IAccessTokenProvider? accessTokenProvider = null)
        {
            _accessTokenProvider = accessTokenProvider;
            _scopeAccessValidator = scopeAccessValidator;
        }

        public async Task HandleAsync(EsiContext context, RequestDelegate next)
        {
            if (context.PublicEndpoint())
            {
                await next.Invoke(context);
            }
            else
            {
                var accessToken = context.TokenProvidedInRequest()
                    ? context.RequestContext.Token
                    : _accessTokenProvider != null ? await _accessTokenProvider.RequestAccessToken() : throw new ArgumentNullException(nameof(_accessTokenProvider));

                if (string.IsNullOrEmpty(accessToken))
                {
                    UnauthorizedResponse(context, HttpStatusCode.Unauthorized, $"The request endpoint requires SSO authentication and a token has not been provided.");
                    return;
                }

                var validScope = await ValidateScope(context, accessToken);
                if (validScope)
                {
                    context.SetAuthorizationHeader(accessToken);

                    await next.Invoke(context);
                }
                else
                {
                    return;
                }
            }
        }

        protected virtual async Task<bool> ValidateScope(EsiContext context, string token)
        {
            if (_scopeAccessValidator == null)
            {
                throw new ArgumentNullException(nameof(_scopeAccessValidator));
            }
            
            var protectedEnpointAttribute = ReflectionCacheAttributeAccessor.Instance.GetAttribute<ProtectedEndpointAttribute>(context.EndpointMarker.AsMethodInfo())!;

            var allowed = await _scopeAccessValidator.ValidateScopeAccess(token, protectedEnpointAttribute.RequiredScope);

            if (!allowed)
            {
                UnauthorizedResponse(context, HttpStatusCode.Forbidden, $"Token is not valid for scope: {protectedEnpointAttribute.RequiredScope}");
            }

            return allowed;
        }

        protected void UnauthorizedResponse(EsiContext context, HttpStatusCode httpStatusCode, string errorMessage)
        {
            context.SetHttpResponseMessage(new HttpResponseMessage(httpStatusCode)
            {
                Content = new StringContent(JsonConvert.SerializeObject(new { error = errorMessage }), Encoding.UTF8, "application/json")
            });
        }
    }
}
