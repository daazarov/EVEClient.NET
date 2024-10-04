using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;

namespace EVEClient.NET.Models
{
    public abstract class EsiRequest : HttpRequestMessage
    {
        /// <summary>
        /// Gets or sets the http method type.
        /// </summary>
        public HttpMethodType MethodType { get; set; }

        /// <summary>
        /// Gets or sets access token for sending HTTP request to the ESI API.
        /// </summary>
        public string? Token { get; set; }

        /// <summary>
        /// Gets or sets request parameters.
        /// </summary>
        public Parameters Parameters { get; } = new();

        /// <summary>
        /// Gets or sets the string url used for the HTTP request.
        /// </summary>
        [StringSyntax(StringSyntaxAttribute.Uri)]
        public string? RequestUrl
        {
            get => base.RequestUri?.ToString();
            set => base.RequestUri = new Uri(value!, UriKind.RelativeOrAbsolute);
        }

        /// <summary>
        /// Gets or sets the already prepared request urls in the order they were added (important for priority)
        /// </summary>
        /// <remarks>If <see cref="RequestUrl"/> property has not been specified, the first url will be assigned.</remarks>
        public IEnumerable<string> AvailableEndpointUrls { get; set; } = default!;

        /// <summary>
        /// Allows derived types to handle <see cref="Parameters"/> initializing.
        /// </summary>
        public abstract void InitializeParameters();

        /// <summary>
        /// 
        /// </summary>
        public void Prepare()
        {
            Validate();

            switch (MethodType)
            {
                case HttpMethodType.Get: base.Method = System.Net.Http.HttpMethod.Get; break;
                case HttpMethodType.Post: base.Method = System.Net.Http.HttpMethod.Post; break;
                case HttpMethodType.Put: base.Method = System.Net.Http.HttpMethod.Put; break;
                case HttpMethodType.Delete: base.Method = System.Net.Http.HttpMethod.Delete; break;
                default: 
                    throw new NotImplementedException(MethodType.ToString());
            }

            SetAuthorizationHeaderIfProvided();

            EnshureRequestUrl();
        }

        /// <summary>
        /// Sets the <see cref="AuthenticationHeaderValue"/> for the current request if it hasn't already been done.
        /// </summary>
        public virtual void SetAuthorizationHeaderIfProvided()
        {
            if (string.IsNullOrEmpty(Token) || base.Headers.Authorization is not null)
            {
                return;
            }

            base.Headers.Authorization = new AuthenticationHeaderValue("Bearer", Token);
        }

        /// <summary>
        /// Validate the request.
        /// </summary>
        public virtual void Validate()
        {
            if (string.IsNullOrEmpty(RequestUrl) && (AvailableEndpointUrls is null || !AvailableEndpointUrls.Any()))
            {
                throw new InvalidOperationException("Can not determine request url. At least the RequestUrl or AvailableEndpointUrls must be set to successfully send a request.");
            }
        }

        private void EnshureRequestUrl()
        {
            // already configured
            if (!string.IsNullOrEmpty(RequestUrl))
            {
                return;
            }

            RequestUrl = AvailableEndpointUrls.First();
        }
    }
}
