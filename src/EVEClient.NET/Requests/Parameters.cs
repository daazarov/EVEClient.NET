using System;
using System.Collections;
using System.Collections.Generic;

namespace EVEClient.NET.Requests
{
    public class Parameters : IEnumerable<KeyValuePair<string, string>>
    {
        private readonly List<KeyValuePair<string, string>> _routeParameters = new List<KeyValuePair<string, string>>();
        private readonly List<KeyValuePair<string, string>> _queryParameters = new List<KeyValuePair<string, string>>();

        private object? _body;

        public ParameterCollection Route { get; }

        public ParameterCollection Query { get; }

        public object? Body
        {
            get => _body;
            set => _body = value ?? throw new ArgumentNullException(nameof(Body));
        }

        public Parameters()
        {
            Route = new ParameterCollection(_routeParameters);
            Query = new ParameterCollection(_queryParameters);
        }

        public IEnumerator<KeyValuePair<string, string>> GetEnumerator()
        {
            foreach (var parameter in _routeParameters)
                yield return parameter;

            foreach (var parameter in _queryParameters)
                yield return parameter;
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public class ParameterCollection : IEnumerable<KeyValuePair<string, string>>
    {
        private readonly List<KeyValuePair<string, string>> _parameters;

        public ParameterCollection(List<KeyValuePair<string, string>> parameters)
        {
            _parameters = parameters;
        }

        public string? this[string key]
        {
            get => GetParameter(key);
            set => SetParameter(key, value);
        }

        public bool ContainsKey(string key)
        {
            ArgumentNullException.ThrowIfNullOrEmpty(key);

            return this[key] != null;
        }

        protected virtual void SetParameter(string key, string? value)
        {
            if (string.IsNullOrEmpty(value)) return;
            
            var index = _parameters.FindIndex(p => p.Key == key);
            if (index >= 0)
                _parameters[index] = new KeyValuePair<string, string>(key, value);
            else
                _parameters.Add(new KeyValuePair<string, string>(key, value));
        }

        protected virtual string? GetParameter(string key)
        {
            var parameter = _parameters.Find(p => p.Key == key);
            if (parameter.Equals(default(KeyValuePair<string, string>)))
                return null;

            return parameter.Value;
        }

        public IEnumerator<KeyValuePair<string, string>> GetEnumerator()
        {
            return _parameters.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
