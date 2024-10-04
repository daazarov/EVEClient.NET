using System;
using System.Net.Http;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Extensions.DependencyInjection;

using Newtonsoft.Json;

using EVEClient.NET.Pipline;
using EVEClient.NET.Extensions;

namespace EVEClient.NET.Handlers
{
    /// <summary>
    /// Performs getting the access token from IAccessTokenProvider or input parameter, validates scope, and sets the Authorization header
    /// </summary>
    public class ProtectionHandler : IRequestProtectionHandler
    {
        public async Task HandleAsync(EsiContext context, RequestDelegate next)
        {
            if (!context.IsProtectedEndpoint())
            {
                await next.Invoke(context);
            }
            else
            {
                // immediately take the token from input parameter, if there is no such token, then contact the provider
                var accessToken = context.Request.Token ??= await context.ScopedServices.GetRequiredService<IAccessTokenProvider>().RequestAccessToken();
                if (string.IsNullOrEmpty(accessToken))
                {
                    UnauthorizedResponse(context, HttpStatusCode.Unauthorized, $"The request endpoint requires SSO authentication and a token has not been provided.");
                    return;
                }

                var requiredScope = context.GetEndpointRequiredScope();
                if (string.IsNullOrEmpty(requiredScope))
                {
                    throw new InvalidOperationException("Missing [Scope] property in configuration for the protected esi endpoint: " + context.EndpointId);
                }

                if (!await ValidateScope(context, requiredScope, accessToken))
                {
                    UnauthorizedResponse(context, HttpStatusCode.Forbidden, $"Token is not valid for scope: {requiredScope}");
                    return;
                }

                await next.Invoke(context);
            }
        }

        protected virtual Task<bool> ValidateScope(EsiContext context, string scope, string token)
        {
            return context.ScopedServices.GetRequiredService<IScopeAccessValidator>().ValidateScopeAccess(token, scope);
        }

        protected void UnauthorizedResponse(EsiContext context, HttpStatusCode httpStatusCode, string errorMessage)
        {
            context.ResponseContext.Response = new HttpResponseMessage(httpStatusCode)
            {
                Content = new StringContent(JsonConvert.SerializeObject(new { error = errorMessage }), Encoding.UTF8, "application/json")
            };

            context.ResponseContext.Completed = true;
        }
    }
}
