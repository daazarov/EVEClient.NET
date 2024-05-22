using System;
using Microsoft.Extensions.Configuration;

using EVEOnline.ESI.Communication.Configuration;
using EVEOnline.ESI.Communication.DependencyInjection;

namespace Microsoft.Extensions.DependencyInjection
{
    public static partial class ServiceCollectionExtensions
    {
        public static IEsiClientConfigurationBuilder AddEVEOnlineEsiClient(this IServiceCollection services, IConfiguration configuration, string sectionName = null)
        {
            return services.AddEVEOnlineEsiClient(configuration.GetRequiredSection(string.IsNullOrEmpty(sectionName) ? EsiClientConfiguration.DefaultEsiConfigurationSectionName : sectionName));
        }

        public static IEsiClientConfigurationBuilder AddEVEOnlineEsiClient(this IServiceCollection services, Action<EsiClientConfiguration> configure)
        {
            var options = new EsiClientConfiguration();
            configure(options);

            return services.AddEVEOnlineEsiClient(options);
        }

        private static IEsiClientConfigurationBuilder AddEVEOnlineEsiClient(this IServiceCollection services, IConfigurationSection configuration)
        {
            if (!configuration.Exists())
            {
                throw new InvalidOperationException(); //todo
            }
            
            var options = new EsiClientConfiguration();
            configuration.Bind(options);

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
            return new EsiClientConfigurationBuilder(services, configuration);
        }
    }
}
