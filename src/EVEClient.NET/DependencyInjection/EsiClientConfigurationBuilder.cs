using Microsoft.Extensions.DependencyInjection;
using EVEClient.NET.Configuration;

namespace EVEClient.NET.DependencyInjection
{
    internal class EsiClientConfigurationBuilder : IEsiClientConfigurationBuilder
    {
        private readonly IServiceCollection _serviceCollection;
        private readonly EsiClientConfiguration _configuration;

        public IServiceCollection Services => _serviceCollection;
        public EsiClientConfiguration Configuration => _configuration;

        public EsiClientConfigurationBuilder(IServiceCollection serviceCollection, EsiClientConfiguration configuration)
        { 
            _serviceCollection = serviceCollection;
            _configuration = configuration;
        }
    }
}
