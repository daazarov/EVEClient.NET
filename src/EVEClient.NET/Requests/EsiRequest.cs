using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Web;

using EVEClient.NET.Configuration;

namespace EVEClient.NET.Requests
{
    public abstract class EsiRequest : HttpRequestMessage
    {
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
        /// 
        /// </summary>
        public virtual void Prepare(EndpointConfiguration configuration)
        {
            Validate();

            switch (configuration.MethodType)
            {
                case HttpMethodType.Get: base.Method = HttpMethod.Get; break;
                case HttpMethodType.Post: base.Method = HttpMethod.Post; break;
                case HttpMethodType.Put: base.Method = HttpMethod.Put; break;
                case HttpMethodType.Delete: base.Method = HttpMethod.Delete; break;
                default: 
                    throw new NotImplementedException(configuration.MethodType.ToString());
            }

            // make sure that all necessary parameters are configured, if this was not done in the pipline
            EnshureAuthorizationHeader(Token);
            EnshureRequestBody(Parameters.Body);
            EnshureAvailableEndpointUrls(configuration.Routes);
            EnshureRequestUrl();
        }

        /// <summary>
        /// Validate the request.
        /// </summary>
        public virtual void Validate()
        {
        }

        private void EnshureAuthorizationHeader(string? token)
        {
            if (string.IsNullOrEmpty(token) || base.Headers.Authorization is not null)
            {
                return;
            }

            base.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);
        }

        private void EnshureRequestBody(object? body)
        {
            if (base.Content is not null && body is not null)
            {
                base.Content = new StringContent(JsonSerializer.Serialize(body));
            }
        }

        private void EnshureAvailableEndpointUrls(IEnumerable<Route> routes)
        {
            if (AvailableEndpointUrls is not null && AvailableEndpointUrls.Any())
            {
                return;
            }
            
            var urls = new List<string>();

            foreach (var route in routes)
            {
                var url = BuildUrl(route.Value, Parameters.Route, Parameters.Query);
                urls.Add(url);

                if (route.Preferred && RequestUrl == null)
                {
                    RequestUrl = url;
                }
            }

            string BuildUrl(string template, ParameterCollection routeParameters, ParameterCollection queryParameters)
            {
                var query = HttpUtility.ParseQueryString(string.Empty);
                var path = new StringBuilder(template);

                foreach (var kvp in routeParameters)
                {
                    path = path.Replace($"{{{kvp.Key}}}", kvp.Value);
                }

                foreach (var kvp in queryParameters)
                {
                    if(!string.IsNullOrEmpty(kvp.Value))
                        query[kvp.Key] = kvp.Value;
                }

                return string.Concat(path.ToString(), "?", query.ToString());
            }

            AvailableEndpointUrls = urls;
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
