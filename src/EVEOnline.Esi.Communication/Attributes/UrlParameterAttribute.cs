using System;

namespace EVEOnline.Esi.Communication.Attributes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    internal class UrlParameterAttribute : Attribute
    {
        public string ParameterName { get; set; }
    }
}
