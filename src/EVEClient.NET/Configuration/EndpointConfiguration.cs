using System;
using System.Collections.Generic;

namespace EVEClient.NET.Configuration
{
    public class EndpointConfiguration
    {
        public string EndpointId { get; }
        public bool ProtectedEndpoint { get;  }
        public HttpMethodType MethodType { get; }
        public string? Scope { get; }
        public IEnumerable<Route> Routes { get; }

        public EndpointConfiguration(string endpointId, bool protectedEndpoint, HttpMethodType methodType, Route[] routes, string? scope)
        { 
            EndpointId = endpointId;
            ProtectedEndpoint = protectedEndpoint;
            MethodType = methodType;
            Routes = routes;
            Scope = scope;
        }
    }

    public class Route
    { 
        public string Value { get; }
        public EndpointVersion Version { get; }
        public bool Preferred { get; }

        public Route(string value, EndpointVersion version, bool prefered)
        {
            ArgumentNullException.ThrowIfNullOrEmpty(value);

            Value = value;
            Version = version;
            Preferred = prefered;
        }
    }
}
