using System;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;

using EVEClient.NET.Extensions;
using EVEClient.NET.Utilities;

namespace EVEClient.NET
{
    public readonly struct EndpointMarker : IEquatable<EndpointMarker>
    {
        public string? CallerName { get; }
        public Type? CallerType { get; }
        public string HttpMethodType { get; }

        [MemberNotNullWhen(false, nameof(CallerName), nameof(CallerType), nameof(HttpMethodType))]
        public bool IsNull => Equals(Null);

        private static EndpointMarker _null = new();

        public static EndpointMarker Null => _null;

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

        public static bool operator ==(EndpointMarker x, EndpointMarker y)
        {
            return x.Equals(y);
        }

        public static bool operator !=(EndpointMarker x, EndpointMarker y)
        {
            return !(x == y);
        }

        //public static implicit operator string(EndpointMarker key)
        //{
        //    return key.ToEndpointId() 
        //        ?? throw new NotSupportedException(
        //            $"Unable to cast this endpoint marker to the endpoint identifier. " +
        //            $"HttpMethodType: {key.HttpMethodType ?? "null"}, CallerName: {key.CallerName ?? "null"}, CallerType: {key.CallerType?.Name ?? "null"}"
        //            );
        //}

        public override string ToString() => ToEndpointId() ?? "(null)";

        public string? ToEndpointId()
        {
            if (IsNull)
            {
                return null;
            }

            return EndpointsMapper.Instance[this];
        }

        internal MethodInfo AsMethodInfo()
        {
            if (!IsNull)
            {
                var methodInfo = CallerType.GetMethod(CallerName);
                if (methodInfo != null)
                {
                    return methodInfo;
                }
            }

            throw new InvalidOperationException("An empty or default marker cannot refer to a specific invocation method.");
        }
    }
}
