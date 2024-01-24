using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;

using EVEOnline.Esi.Communication.Attributes;
using EVEOnline.Esi.Communication.Configuration;
using EVEOnline.Esi.Communication.Utilities;

namespace EVEOnline.Esi.Communication.Handlers
{
    internal class RequestHeadersHandler : IHandler
    {
        private readonly EsiClientConfiguration _configuration;
        private readonly IAccessTokenProvider _accessTokenProvider;
        private readonly IScopeAccessValidator _scopeAccessValidator;

        public RequestHeadersHandler(IOptions<EsiClientConfiguration> configuration, IAccessTokenProvider accessTokenProvider, IScopeAccessValidator scopeAccessValidator)
        {
            _configuration = configuration.Value;
            _accessTokenProvider = accessTokenProvider;
            _scopeAccessValidator = scopeAccessValidator;
        }

        public async Task HandleAsync(EsiContext context, RequestDelegate next)
        {
            if (TryConfigureProtectionHeader(context))
            {
                ConfigureDefaultHttpClientHeaders(context);

                await next.Invoke(context);
            }
            else
            {
                return;
            }
        }

        private void ConfigureDefaultHttpClientHeaders(EsiContext context)
        {
            context.HttpClient.DefaultRequestHeaders.Add("X-User-Agent", _configuration.UserAgent);
            context.HttpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            context.HttpClient.DefaultRequestHeaders.AcceptEncoding.Add(new StringWithQualityHeaderValue("gzip"));
            context.HttpClient.DefaultRequestHeaders.AcceptEncoding.Add(new StringWithQualityHeaderValue("deflate"));
        }

        private bool TryConfigureProtectionHeader(EsiContext context)
        {
            var isPublic = IsPublicEndpoint(context);

            if (!isPublic)
            {
                var protectedEnpointAttribute = ReflectionCacheAttributeAccessor.Instance.GetAttribute<ProtectedEndpointAttribute>(context.CallingContext.MethodInfo) ??
                    throw new InvalidOperationException($"Missing {nameof(ProtectedEndpointAttribute)} in the {context.CallingContext.MethodInfo.Name} method of {context.CallingContext.MethodInfo.DeclaringType.Name} type.");

                var token = _accessTokenProvider.GetAccessToken();

                if (string.IsNullOrEmpty(token))
                {
                    UnauthorizedResponse(context, HttpStatusCode.Unauthorized, "The request endpoint requires SSO authentication and a token has not been provided.");

                    return false;
                }
                else
                {
                    context.HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                }

                if (_scopeAccessValidator != null && !string.IsNullOrEmpty(protectedEnpointAttribute.RequiredScope))
                {
                    var isAuthorized = _scopeAccessValidator.VerifyScopeAccess(protectedEnpointAttribute.RequiredScope);

                    if (!isAuthorized)
                    {
                        UnauthorizedResponse(context, HttpStatusCode.Forbidden, $"The request endpoint requires the following scope: {protectedEnpointAttribute.RequiredScope}.");

                        return false;
                    }
                }
            }

            return true;
        }

        private bool IsPublicEndpoint(EsiContext context)
        {
            return ReflectionCacheAttributeAccessor.Instance.ContainsAttribute<PublicEndpointAttribute>(context.CallingContext.MethodInfo);
        }

        private void UnauthorizedResponse(EsiContext context, HttpStatusCode httpStatusCode, string errorMessage)
        {
            context.SetHttpResponseMessage(new HttpResponseMessage(httpStatusCode)
            {
                Content = new StringContent(JsonConvert.SerializeObject(new { error = errorMessage }), Encoding.UTF8, "application/json")
            });
        }
    }
}
