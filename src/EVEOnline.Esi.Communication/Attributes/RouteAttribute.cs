using System;

namespace EVEOnline.Esi.Communication.Attributes
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    internal class RouteAttribute : Attribute
    {
        private string _template;
        private EndpointType _type;
        
        public RouteAttribute(string template)
        {
            _template = template;
        }

        public string Template { get => _template; set => _template = value; }
        public EndpointType Type { get => _type; set => _type = value; }
    }
}
