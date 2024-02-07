
using System;

namespace EVEOnline.ESI.Communication.Attributes
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    internal class PublicEndpointAttribute : Attribute
    {
    }
}
