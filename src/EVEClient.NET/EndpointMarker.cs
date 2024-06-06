using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net.Http;
using System.Reflection;

using EVEClient.NET.Extensions;
using EVEClient.NET.Utilities;

namespace EVEClient.NET
{
    public readonly struct EndpointMarker : IEquatable<EndpointMarker>
    {
        public string CallerName { get; }
        public Type CallerType { get; }
        public string HttpMethodType { get; }
        public bool IsDefault => !IsNull && CallerType is null && string.IsNullOrEmpty(CallerName);
        public bool IsNull => Equals(Null);

        private static string[] availableHttpMethods = { HttpMethod.Get.Method, HttpMethod.Post.Method, HttpMethod.Put.Method, HttpMethod.Delete.Method };

        public static EndpointMarker Null => new();

        public static EndpointMarker DefaultGet = HttpMethod.Get.Method;
        public static EndpointMarker DefaultPost = HttpMethod.Post.Method;
        public static EndpointMarker DefaultPut = HttpMethod.Put.Method;
        public static EndpointMarker DefaultDelete = HttpMethod.Delete.Method;
        
        internal EndpointMarker(string httpMethodType)
        {
            if (!availableHttpMethods.Contains(httpMethodType.ToUpper()))
            {
                throw new NotSupportedException($"{httpMethodType} is unsupported HTTP method.");
            }

            HttpMethodType = httpMethodType.ToUpper();
        }

        internal EndpointMarker(string httpMethodType, Type callerType, string callerName)
        {
            httpMethodType.ArgumentStringNotNullOrEmpty(nameof(httpMethodType));
            callerName.ArgumentStringNotNullOrEmpty(nameof(callerName));
            callerType.ArgumentNotNull(nameof(callerType));

            HttpMethodType = httpMethodType.ToUpper();
            CallerName = callerName;
            CallerType = callerType;
        }

        public bool Equals(EndpointMarker other)
        {
            // If run-time types are not exactly the same, return false.
            if (GetType() != other.GetType())
            {
                return false;
            }

            // Return true if the fields match.
            return HttpMethodType == other.HttpMethodType && CallerName == other.CallerName && CallerType == other.CallerType;
        }

        public override bool Equals(object? obj)
        {
            return obj is EndpointMarker && Equals((EndpointMarker)obj);
        }

        public override int GetHashCode()
        {
            return (HttpMethodType, CallerName, CallerType).GetHashCode();
        }

        public static implicit operator EndpointMarker(string httpMethodType)
        {
            if (string.IsNullOrEmpty(httpMethodType))
            {
                return Null;
            }

            return new EndpointMarker(httpMethodType);
        }

        public static bool operator ==(EndpointMarker x, EndpointMarker y)
        {
            return x.Equals(y);
        }

        public static bool operator !=(EndpointMarker x, EndpointMarker y)
        {
            return !(x == y);
        }

        public static implicit operator string?(EndpointMarker key)
        {
            return key.ToEndpointId();
        }

        public override string ToString() => ((string?)this) ?? "(null)";

        internal MethodInfo AsMethodInfo()
        {
            if (!IsNull && !IsDefault)
            { 
                return CallerType.GetMethod(CallerName);
            }

            throw new InvalidOperationException("An empty or default marker cannot refer to a specific invocation method.");
        }

        private string? ToEndpointId()
        {
            if (IsNull)
            {
                return null;
            }
            
            if (IsDefault)
            {
                return HttpMethodType switch
                {
                    "GET" => "get_default",
                    "POST" => "post_default",
                    "PUT" => "put_default",
                    "DELETE" => "delete_default",
                    _ => throw new NotSupportedException("Unsupported HTTP method.")
                };
            }

            return EndpointsMapper.Instance[this];
        }
    }
}
