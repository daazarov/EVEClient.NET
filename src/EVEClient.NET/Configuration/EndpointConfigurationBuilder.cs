using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

namespace EVEClient.NET.Configuration
{
    public class EndpointConfigurationBuilder
    {
        private static string[] _availableHttpMethodTypes = 
        { 
            HttpMethod.Put.Method,
            HttpMethod.Delete.Method,
            HttpMethod.Get.Method,
            HttpMethod.Post.Method
        };
        
        public string EndpointId { get; }
        public HttpMethodType HttpMethodType { get; set;}
        public bool ProtectedEndpoint { get; set; }
        public string? Scope { get; set; }
        public List<Route> Routes { get; set; } = default!;

        public EndpointConfigurationBuilder(string endpointId)
        {
            EndpointId = endpointId;
        }

        public EndpointConfiguration Build()
        {
            Validate();

            return new EndpointConfiguration(EndpointId, ProtectedEndpoint, HttpMethodType, Routes!.ToArray(), Scope);
        }

        private void Validate()
        {
            if (ProtectedEndpoint && string.IsNullOrEmpty(Scope))
            {
                throw new InvalidOperationException("Scope property can not be skipped if the esi endpoint is protected.");
            }

            if (Routes is null || Routes.Count < 1)
            {
                throw new InvalidOperationException("At least one route must be configured for the esi endpoint.");
            }

            if (!_availableHttpMethodTypes.Contains(HttpMethodType.ToString(), StringComparer.OrdinalIgnoreCase))
            {
                throw new InvalidOperationException("Not supported HTTP method type: " + HttpMethodType);
            }
        }
    }
}
