using System;
using System.Threading.Tasks;
using System.Collections.Generic;

using Microsoft.Extensions.Options;

using EVEClient.NET.Configuration;

namespace EVEClient.NET
{
    internal class EndpointConfigurationProvider : IEndpointConfigurationProvider
    {
        private readonly EsiClientConfiguration _options;
        private readonly IDictionary<string, EndpointConfiguration> _configurations = new Dictionary<string, EndpointConfiguration>();
        
        public EndpointConfigurationProvider(IOptions<EsiClientConfiguration> options)
        { 
            _options = options.Value;

            foreach (var builder in _options.EndpointConfigurations)
            {
                var configuration = builder.Build();
                AddConfiguration(configuration);
            }
        }

        public EndpointConfiguration GetEndpointConfiguration(string endpointId)
        {
            return _configurations[endpointId];
        }

        private void AddConfiguration(EndpointConfiguration configuration)
        {
            if (_configurations.ContainsKey(configuration.EndpointId))
            {
                throw new InvalidOperationException("Esiendpoint configuration already exists: " + configuration.EndpointId);
            }

            _configurations[configuration.EndpointId] = configuration;
        }
    }
}
