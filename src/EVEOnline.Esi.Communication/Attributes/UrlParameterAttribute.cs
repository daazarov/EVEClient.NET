using System;

namespace EVEOnline.ESI.Communication.Attributes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    internal class UrlParameterAttribute : Attribute
    {
        public string ParameterName { get; set; }
    }
}
