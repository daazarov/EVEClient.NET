
using System;

namespace EVEClient.NET.Attributes
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    internal class PublicEndpointAttribute : Attribute
    {
    }
}
