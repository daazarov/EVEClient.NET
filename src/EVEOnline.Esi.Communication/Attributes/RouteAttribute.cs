using System;

namespace EVEOnline.Esi.Communication.Attributes
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    internal class RouteAttribute : Attribute
    {
        private string _template;
        private EndpointVersion _version;
        private bool _default;
        
        public RouteAttribute(string template)
        {
            _template = template;
        }

        public string Template { get => _template; set => _template = value; }
        public EndpointVersion Version { get => _version; set => _version = value; }
        public bool Default { get => _default; set => _default = value; }
    }
}
