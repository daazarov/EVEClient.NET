using System;

namespace EVEClient.NET.Attributes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    internal class QueryParameterAttribute : UrlParameterAttribute
    {
        public QueryParameterAttribute(string parameterName)
        { 
            ParameterName = parameterName;
        }
    }
}
