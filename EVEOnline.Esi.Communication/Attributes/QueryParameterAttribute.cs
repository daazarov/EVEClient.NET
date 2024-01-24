using System;

namespace EVEOnline.Esi.Communication.Attributes
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
