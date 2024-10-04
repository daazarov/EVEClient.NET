using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;

namespace EVEClient.NET.Configuration
{
    public class EndpointConfigurationBuilder
    {
        private const string EndpointIdKey = "endpoint_id";
        private const string HttpMethodTypeKey = "http_method_type";
        private const string ProtectedKey = "protected";
        private const string RoutesKey = "routes";
        private const string RouteValueKey = "value";
        private const string RouteVersionKey = "version";
        private const string RoutePreferredKey = "preferred";

        private static string[] _availableHttpMethodTypes = 
        { 
            HttpMethod.Put.Method,
            HttpMethod.Delete.Method,
            HttpMethod.Get.Method,
            HttpMethod.Post.Method
        };
        
        private JsonElement? _configurationElement;
        
        public string EndpointId { get; }
        public HttpMethodType? HttpMethodType { get; set;}
        public bool ProtectedEndpoint { get; set; }
        public string? Scope { get; set; }
        public List<Route>? Routes { get; set; }

        public EndpointConfigurationBuilder(string endpointId)
        {
            EndpointId = endpointId;
        }

        public void FromJsonElement(JsonElement element)
        {
            _configurationElement = element;
        }

        public EndpointConfiguration Build()
        {
            if (_configurationElement.HasValue)
            {
                InitializeFromJson(_configurationElement.Value);
            }

            if (ProtectedEndpoint && string.IsNullOrEmpty(Scope))
            {
                throw new InvalidOperationException("Scope property can not be skipped if the esi endpoint is protected.");
            }

            if (Routes is null || Routes.Count < 1)
            {
                throw new InvalidOperationException("At least one route must be configured for the esi endpoint.");
            }

            if (!HttpMethodType.HasValue || !_availableHttpMethodTypes.Contains(HttpMethodType.ToString(), StringComparer.OrdinalIgnoreCase))
            {
                throw new InvalidOperationException("Not supported http method type: " + HttpMethodType);
            }

            return new EndpointConfiguration(EndpointId, HttpMethodType.Value, ProtectedEndpoint, Routes.ToArray(), Scope);
        }

        private void InitializeFromJson(JsonElement element)
        {
            var endpointId = element.GetProperty(EndpointIdKey).ToString();
            if (EndpointId != endpointId)
            {
                throw new InvalidOperationException("Endpoint identifier from the json configuration does not match the value passed through builder constructor. " +
                    EndpointId + " <--> " + endpointId);
            }

            HttpMethodType = Enum.Parse<HttpMethodType>(element.GetProperty(HttpMethodTypeKey).ToString(), true);
            ProtectedEndpoint = element.GetProperty(ProtectedKey).GetBoolean();

            Routes = new List<Route>();

            var routeArray = element.GetProperty(RoutesKey).EnumerateArray();
            foreach (var routeItem in routeArray)
            {
                var value = routeItem.GetProperty(RouteValueKey).ToString();
                var preferred = routeItem.GetProperty(RoutePreferredKey).GetBoolean();
                var version = Enum.Parse<EndpointVersion>(routeItem.GetProperty(RouteVersionKey).ToString(), true);

                Routes.Add(new Route(value, version, preferred));
            }
        }
    }
}
