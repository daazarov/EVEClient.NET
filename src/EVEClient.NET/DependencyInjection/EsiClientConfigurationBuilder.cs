using Microsoft.Extensions.DependencyInjection;
using EVEClient.NET.Configuration;
using EVEClient.NET.Pipline.Modifications;

namespace EVEClient.NET.DependencyInjection
{
    internal class EsiClientConfigurationBuilder : IEsiClientConfigurationBuilder
    {

        public IServiceCollection Services { get; }
        public EsiClientConfiguration Configuration { get; }
        public IPiplineModificationsBuilder PiplineModificationBuilder { get; }

        public EsiClientConfigurationBuilder(IServiceCollection serviceCollection, EsiClientConfiguration configuration, IPiplineModificationsBuilder modificationBuilder)
        {
            Services = serviceCollection;
            Configuration = configuration;
            PiplineModificationBuilder = modificationBuilder;
        }
    }
}
