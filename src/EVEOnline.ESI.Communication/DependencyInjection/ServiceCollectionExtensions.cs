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
using EVEOnline.ESI.Communication.Handlers;
using EVEOnline.ESI.Communication.Pipline;

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
            
            services.TryAddTransient<IEsiLogicAccessor, EsiLogicAccessor>();
            services.TryAddTransient<IEsiContextFactory, EsiContextFactory>();
            services.TryAddTransient<IRequestPiplineBuilder, RequestPiplineBuilder>();
            services.TryAddTransient(typeof(IEsiHttpClient<>), typeof(EsiHttpClient<>));

            services.AddLogics();
            services.AddDefaultRequestPiplineHandlers();

            services.AddHttpClient(ESI.HttpClientName, httpClient => httpClient.BaseAddress = new Uri(configuration.BaseUrl))
                    .ConfigurePrimaryHttpMessageHandler(() => new HttpClientHandler { AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate });

            if (configuration.EnableETag)
            {
                services.TryAddSingleton<IETagStorage, DefaultInMemoryETagThreadSaveStore>();
            }

            services.Configure<EsiClientConfiguration>(options => 
            {
                options.Server = configuration.Server;
                options.UserAgent = configuration.UserAgent;
                options.EnableETag = configuration.EnableETag;
                options.BaseUrl = configuration.BaseUrl;
            });

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
            services.TryAddTransient<IFleetsLogic, FleetsLogic>();
            services.TryAddTransient<IIncursionsLogic, IncursionsLogic>();
            services.TryAddTransient<IIndustryLogic, IndustryLogic>();
            services.TryAddTransient<IInsuranceLogic, InsuranceLogic>();
            services.TryAddTransient<IKillmailsLogic, KillmailsLogic>();
            services.TryAddTransient<ILocationLogic, LocationLogic>();
            services.TryAddTransient<ILoyaltyLogic, LoyaltyLogic>();
            services.TryAddTransient<IMailLogic, MailLogic>();
            services.TryAddTransient<IMarketLogic, MarketLogic>();
            services.TryAddTransient<IOpportunitiesLogic, OpportunitiesLogic>();
            services.TryAddTransient<IPlanetaryInteractionLogic, PlanetaryInteractionLogic>();
            services.TryAddTransient<IRoutesLogic, RoutesLogic>();
            services.TryAddTransient<ISearchLogic, SearchLogic>();
            services.TryAddTransient<ISkillsLogic, SkillsLogic>();
            services.TryAddTransient<ISovereigntyLogic, SovereigntyLogic>();
            services.TryAddTransient<IStatusLogic, StatusLogic>();
            services.TryAddTransient<IUniverseLogic, UniverseLogic>();
            services.TryAddTransient<IUserInterfaceLogic, UserInterfaceLogic>();
            services.TryAddTransient<IWalletLogic, WalletLogic>();
            services.TryAddTransient<IWarsLogic, WarsLogic>();

            return services;
        }

        private static IServiceCollection AddDefaultRequestPiplineHandlers(this IServiceCollection services)
        {
            services.TryAddTransient<RequestHeadersHandler>();
            services.TryAddTransient<UrlRequestParametersHandler>();
            services.TryAddTransient<RequestGetHandler>();
            services.TryAddTransient<RequestPostHandler>();
            services.TryAddTransient<RequestDeleteHandler>();
            services.TryAddTransient<RequestPutHandler>();
            services.TryAddTransient<ETagHandler>();
            services.TryAddTransient<EndpointHandler>();
            services.TryAddTransient<ProtectionHandler>();
            services.TryAddTransient<BodyRequestParametersHandler>();

            return services;
        }
    }
}
