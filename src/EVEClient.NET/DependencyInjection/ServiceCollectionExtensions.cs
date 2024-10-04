using System;

using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Options;

using EVEClient.NET.Configuration;
using EVEClient.NET.DependencyInjection;
using EVEClient.NET.Pipline.Modifications;

namespace Microsoft.Extensions.DependencyInjection
{
    public static partial class ServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="IEsiLogicAccessor"/> and related services to the <see cref="IServiceCollection"/>.
        /// </summary>
        /// <param name="services">The <see cref="IServiceCollection"/></param>
        /// <param name="configure">Delegate for configuration settings</param>
        /// <returns>The <see cref="IEsiClientConfigurationBuilder"/></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static IEsiClientConfigurationBuilder AddEVEOnlineEsiClient(this IServiceCollection services, Action<EsiClientConfiguration> configure)
        {
            if (configure is null)
            { 
                throw new ArgumentNullException(nameof(configure));
            }
            
            var options = new EsiClientConfiguration();
            configure(options);

            return services.AddEVEOnlineEsiClient(options);
        }

        /// <summary>
        /// Adds the <see cref="IEsiLogicAccessor"/> and related services to the <see cref="IServiceCollection"/>.
        /// </summary>
        /// <param name="services">The <see cref="IServiceCollection"/></param>
        /// <param name="configuration">ESI Client configurations</param>
        /// <returns>The <see cref="IEsiClientConfigurationBuilder"/></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static IEsiClientConfigurationBuilder AddEVEOnlineEsiClient(this IServiceCollection services, EsiClientConfiguration configuration)
        {
            if (configuration is null)
            {
                throw new ArgumentNullException(nameof(configuration));
            }

            services.Configure<EsiClientConfiguration>(options =>
            {
                options.Server = configuration.Server;
                options.UserAgent = configuration.UserAgent;
                options.EnableETag = configuration.EnableETag;
            });

            services.TryAddEnumerable(ServiceDescriptor.Singleton<IPostConfigureOptions<EsiClientConfiguration>, EnshureUserAgentProvidedPostConfigure>());
            services.TryAddEnumerable(ServiceDescriptor.Singleton<IPostConfigureOptions<EsiClientConfiguration>, EnshureBackchannelPostConfigure>());

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
