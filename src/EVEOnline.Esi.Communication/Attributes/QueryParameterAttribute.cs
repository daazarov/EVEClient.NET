using System;

namespace EVEOnline.ESI.Communication.Attributes
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
