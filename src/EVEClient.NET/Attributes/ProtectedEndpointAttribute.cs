using System;

namespace EVEClient.NET.Attributes
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    internal class ProtectedEndpointAttribute : Attribute
    {
        public string RequiredScope { get; set; }
    }
}
