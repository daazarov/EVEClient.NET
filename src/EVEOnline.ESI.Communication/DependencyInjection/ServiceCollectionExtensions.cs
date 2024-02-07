using System;
using System.Net;
using System.Net.Http;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection.Extensions;

using EVEOnline.ESI.Communication.Configuration;
using EVEOnline.ESI.Communication.Logic;
using EVEOnline.ESI.Communication.DependencyInjection;
using EVEOnline.ESI.Communication;
using EVEOnline.ESI.Communication.Utilities.Stores;

namespace Microsoft.Extensions.DependencyInjection
{
    public static partial class ServiceCollectionExtensions
    {
        public static IEsiClientConfigurationBuilder AddEVEOnlineEsiClient(this IServiceCollection services, IConfiguration configuration, string sectionName = null)
        {
            if (services == null)
            { 
                throw new ArgumentNullException(nameof(services));
            }

            if (configuration == null)
            {
                throw new ArgumentNullException(nameof(configuration));
            }

            return services.AddEVEOnlineEsiClient(configuration.GetRequiredSection(string.IsNullOrEmpty(sectionName) ? EsiClientConfiguration.DefaultEsiConfigurationSectionName : sectionName));
        }

        public static IEsiClientConfigurationBuilder AddEVEOnlineEsiClient(this IServiceCollection services, Action<EsiClientConfiguration> configure)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            if (configure == null)
            {
                throw new ArgumentNullException(nameof(configure));
            }

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
            services.TryAddTransient<IEsiLogicAccessor, EsiLogicAccessor>();
            services.TryAddTransient<IEsiContextFactory, EsiContextFactory>();
            services.TryAddTransient<IRequestPiplineBuilder, RequestPiplineBuilder>();
            services.TryAddTransient(typeof(IEsiHttpClient<>), typeof(EsiHttpClient<>));

            services.AddLogics();

            services.AddHttpClient(ESI.HttpClientName, httpClient => httpClient.BaseAddress = new Uri(configuration.BaseUrl))
                    .ConfigurePrimaryHttpMessageHandler(() => new HttpClientHandler { AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate });

            if (configuration.EnableETag)
            {
                services.TryAddSingleton<IETagStorage, DefaultInMemoryETagThreadSaveStore>();
            }

            services.Configure<EsiClientConfiguration>(options => options = configuration);

            var builder = new EsiClientConfigurationBuilder(services, configuration);

            return builder;
        }

        private static IServiceCollection AddLogics(this IServiceCollection services)
        {
            services.TryAddTransient<ICharacterLogic, CharacterLogic>();
            services.TryAddTransient<IAllianceLogic, AllianceLogic>();
            services.TryAddTransient<IAssetsLogic, AssetsLogic>();
            services.TryAddTransient<IBookmarksLogic, BookmarksLogic>();
            services.TryAddTransient<ICalendarLogic, CalendarLogic>();
            services.TryAddTransient<IClonesLogic, ClonesLogic>();
            services.TryAddTransient<IContactsLogic, ContactsLogic>();
            services.TryAddTransient<IContractsLogic, ContractsLogic>();
            services.TryAddTransient<ICorporationLogic, CorporationLogic>();
            services.TryAddTransient<IDogmaLogic, DogmaLogic>();
            services.TryAddTransient<IFactionWarfareLogic, FactionWarfareLogic>();
            services.TryAddTransient<IFittingsLogic, FittingsLogic>();

            return services;
        }
    }
}
