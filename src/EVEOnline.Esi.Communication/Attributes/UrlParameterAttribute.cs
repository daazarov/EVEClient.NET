using System;

namespace EVEOnline.Esi.Communication.Attributes
{
    internal class UrlParameterAttribute : Attribute
    {
        public string ParameterName { get; set; }
    }
}
