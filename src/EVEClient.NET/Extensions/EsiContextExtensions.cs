using System;
using System.Net.Http;
using System.Net.Http.Headers;

using EVEClient.NET.Attributes;
using EVEClient.NET.Utilities;

namespace EVEClient.NET.Extensions
{
    public static class EsiContextExtensions
    {
        /// <summary>
        /// Indicates whether the ESI endpoint is public for the created context.
        /// </summary>
        /// <param name="context">The <see cref="EsiContext"/>.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="InvalidOperationException"></exception>
        public static bool PublicEndpoint(this EsiContext context)
        {
            ArgumentNullException.ThrowIfNull(context);

            return ReflectionCacheAttributeAccessor.Instance.ContainsAttribute<PublicEndpointAttribute>(context.EndpointMarker.AsMethodInfo());
        }

        /// <summary>
        /// Indicates whether the access token was passed as an input parameter when the logic method was called.
        /// </summary>
        /// <param name="context">The <see cref="EsiContext"/>.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public static bool TokenProvidedInRequest(this EsiContext context)
        {
            ArgumentNullException.ThrowIfNull(context);

            return !string.IsNullOrEmpty(context.RequestContext.Token);
        }

        /// <summary>
        /// Sets the authentication header value for the <see cref="HttpClient"/>.
        /// </summary>
        /// <param name="context">The <see cref="EsiContext"/>.</param>
        /// <param name="parameter">The authentication header value without scheme.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public static void SetAuthorizationHeader(this EsiContext context, string parameter)
        {
            ArgumentNullException.ThrowIfNull(context);

            if (string.IsNullOrEmpty(parameter))
            {
                throw new ArgumentNullException(nameof(parameter));
            }

            if (context.HttpClient.DefaultRequestHeaders.Authorization is not null)
            {
                return;
            }

            context.HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", parameter);
        }
    }
}
