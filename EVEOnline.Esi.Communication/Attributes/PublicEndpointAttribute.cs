
using System;

namespace EVEOnline.Esi.Communication.Attributes
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    internal class PublicEndpointAttribute : Attribute
    {
    }
}
