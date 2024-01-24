using System;
using System.Diagnostics.CodeAnalysis;

namespace EVEOnline.Esi.Communication.Attributes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    internal class RouteParameterAttribute : UrlParameterAttribute
    {
        public RouteParameterAttribute(string parameterName)
        {
            ParameterName = parameterName;
        }
    }
}
