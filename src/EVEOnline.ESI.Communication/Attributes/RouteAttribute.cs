using System;

namespace EVEOnline.ESI.Communication.Attributes
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    internal class RouteAttribute : Attribute
    {
        private string _template;
        private EndpointVersion _version;
        private bool _preferred;
        
        public RouteAttribute(string template)
        {
            _template = template;
        }

        public string Template { get => _template; set => _template = value; }
        public EndpointVersion Version { get => _version; set => _version = value; }
        public bool Preferred { get => _preferred; set => _preferred = value; }
    }
}
