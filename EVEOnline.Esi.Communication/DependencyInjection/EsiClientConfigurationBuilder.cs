using Microsoft.Extensions.DependencyInjection;
using EVEOnline.Esi.Communication.Configuration;

namespace EVEOnline.Esi.Communication.DependencyInjection
{
    internal class EsiClientConfigurationBuilder : IEsiClientConfigurationBuilder
    {
        private readonly IServiceCollection _serviceCollection;
        private readonly EsiClientConfiguration _configuration;

        public IServiceCollection ServiceCollection => _serviceCollection;
        public EsiClientConfiguration Configuration => _configuration;

        public EsiClientConfigurationBuilder(IServiceCollection serviceCollection, EsiClientConfiguration configuration)
        { 
            _serviceCollection = serviceCollection;
            _configuration = configuration;
        }
    }
}
