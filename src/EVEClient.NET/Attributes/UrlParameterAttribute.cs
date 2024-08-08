using System;

namespace EVEClient.NET.Attributes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    internal class UrlParameterAttribute : Attribute
    {
        public string ParameterName { get; set; } = default!;
    }
}
