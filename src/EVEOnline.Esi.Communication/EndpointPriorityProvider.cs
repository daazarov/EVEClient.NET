using System.Collections.Generic;
using Microsoft.Extensions.Options;

using EVEOnline.Esi.Communication.Configuration;

namespace EVEOnline.Esi.Communication
{
    internal class EndpointPriorityProvider : IEndpointPriorityProvider
    {
        private readonly RoutePriorityConfiguration _configuration;

        private readonly static IList<RoutePriority> _defaultLatest = new List<RoutePriority> { RoutePriority.Latest };
        private readonly static IList<RoutePriority> _defaultDev = new List<RoutePriority> { RoutePriority.Dev };

        public EndpointPriorityProvider(IOptions<RoutePriorityConfiguration> configuration)
        {
            _configuration = configuration.Value;
        }

        public IEnumerable<RoutePriority> GetPriorities(string endpointId)
        {
            if (_configuration.UseOnlyLatestRoutes)
            { 
                return _defaultLatest;
            }

            if (_configuration.UseDevelopmentRoutes)
            {
                return _defaultDev;
            }
            
            return _configuration.PriorityConfigurations.ContainsKey(endpointId) ? _configuration.PriorityConfigurations[endpointId] : _defaultLatest;
        }
    }
}
