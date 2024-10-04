using System;
using System.Collections.Generic;

namespace EVEClient.NET.Models
{
    public class Parameters
    {
        private Dictionary<string, string>? _queryParameters;
        private Dictionary<string, string>? _routeParameters;

        private object? _body;

        public Dictionary<string, string> Route
        {
            get
            {
                if (_routeParameters is null)
                {
                    _routeParameters = new Dictionary<string, string>();
                }
                return _routeParameters;
            }
        }

        public Dictionary<string, string> Query
        {
            get
            {
                if (_queryParameters is null)
                {
                    _queryParameters = new Dictionary<string, string>();
                }
                return _queryParameters;
            }
        }

        public object? Body
        {
            get
            {
                return _body;
            }
            set
            {
                ArgumentNullException.ThrowIfNull(value, nameof(Body));
                _body = value;
            }
        }
    }
}
