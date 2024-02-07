using System;
using System.Diagnostics.CodeAnalysis;

namespace EVEOnline.ESI.Communication.Attributes
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
