using System;

using EVEClient.NET.Configuration;
using EVEClient.NET.DependencyInjection;
using EVEClient.NET.Pipline.Modifications;

namespace Microsoft.Extensions.DependencyInjection
{
    public static partial class ServiceCollectionExtensions
    {
        public static IEsiClientConfigurationBuilder AddEVEOnlineEsiClient(this IServiceCollection services, Action<EsiClientConfiguration> configure)
        {
            var options = new EsiClientConfiguration();
            configure(options);

            return services.AddEVEOnlineEsiClient(options);
        }

        private static IEsiClientConfigurationBuilder AddEVEOnlineEsiClient(this IServiceCollection services, EsiClientConfiguration configuration)
        {
            if (string.IsNullOrEmpty(configuration.UserAgent))
            {
                throw new ArgumentNullException("Please specify UserAgent in the EsiClientConfiguration");
            }

            services.Configure<EsiClientConfiguration>(options =>
            {
                options.Server = configuration.Server;
                options.UserAgent = configuration.UserAgent;
                options.EnableETag = configuration.EnableETag;
            });

            var builder = services.AddEsiClientConfigurationBuilder(configuration);

            builder
                .AddRequiredClientServices()
                .AddDefaults()
                .AddEsiLogic()
                .AddPiplineHandlers();

            return builder;
        }

        private static IEsiClientConfigurationBuilder AddEsiClientConfigurationBuilder(this IServiceCollection services, EsiClientConfiguration configuration)
        {
            return new EsiClientConfigurationBuilder(services, configuration, new PiplineModificationsBuilder());
        }
    }
}
