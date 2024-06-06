using System;
using System.Net;
using System.Net.Http;
using System.Reflection;
using Microsoft.Extensions.DependencyInjection.Extensions;

using EVEClient.NET;
using EVEClient.NET.DependencyInjection;
using EVEClient.NET.Handlers;
using EVEClient.NET.Pipline;
using EVEClient.NET.Pipline.Modifications;
using EVEClient.NET.Defaults;
using EVEClient.NET.Logic;

namespace Microsoft.Extensions.DependencyInjection
{
    public static partial class EsiClientConfigurationBuilderExtensions
    {
        public static IEsiClientConfigurationBuilder AddRequiredClientServices(this IEsiClientConfigurationBuilder builder)
        {
            builder.Services
                .AddHttpClient(ESI.HttpClientName, httpClient =>
                {
                    httpClient.BaseAddress = new Uri(builder.Configuration.EsiUrl);
                })
                .ConfigurePrimaryHttpMessageHandler(() => new HttpClientHandler
                { 
                    AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate
                });

            builder.Services.TryAddScoped<IEsiContextFactory, EsiContextFactory>();
            builder.Services.TryAddScoped<IEsiLogicAccessor, EsiLogicAccessor>();
            builder.Services.TryAddScoped(typeof(IEsiHttpClient<>), typeof(EsiHttpClient<>));

            return builder;
        }

        public static IEsiClientConfigurationBuilder AddDefaults(this IEsiClientConfigurationBuilder builder)
        {
            builder.Services.TryAddSingleton<IETagStorage, DefaultInMemoryETagThreadSaveStore>();
            builder.Services.TryAddSingleton<IScopeAccessValidator, DefaultScopeAccessValidator>();
            builder.Services.TryAddSingleton<IPiplineStore, PiplineStore>();

            return builder;
        }

        public static IEsiClientConfigurationBuilder AddEsiLogic(this IEsiClientConfigurationBuilder builder)
        {
            builder.Services.TryAddScoped<ICharacterLogic, CharacterLogic>();
            builder.Services.TryAddScoped<IAllianceLogic, AllianceLogic>();
            builder.Services.TryAddScoped<IAssetsLogic, AssetsLogic>();
            builder.Services.TryAddScoped<IBookmarksLogic, BookmarksLogic>();
            builder.Services.TryAddScoped<ICalendarLogic, CalendarLogic>();
            builder.Services.TryAddScoped<IClonesLogic, ClonesLogic>();
            builder.Services.TryAddScoped<IContactsLogic, ContactsLogic>();
            builder.Services.TryAddScoped<IContractsLogic, ContractsLogic>();
            builder.Services.TryAddScoped<ICorporationLogic, CorporationLogic>();
            builder.Services.TryAddScoped<IDogmaLogic, DogmaLogic>();
            builder.Services.TryAddScoped<IFactionWarfareLogic, FactionWarfareLogic>();
            builder.Services.TryAddScoped<IFittingsLogic, FittingsLogic>();
            builder.Services.TryAddScoped<IFleetsLogic, FleetsLogic>();
            builder.Services.TryAddScoped<IIncursionsLogic, IncursionsLogic>();
            builder.Services.TryAddScoped<IIndustryLogic, IndustryLogic>();
            builder.Services.TryAddScoped<IInsuranceLogic, InsuranceLogic>();
            builder.Services.TryAddScoped<IKillmailsLogic, KillmailsLogic>();
            builder.Services.TryAddScoped<ILocationLogic, LocationLogic>();
            builder.Services.TryAddScoped<ILoyaltyLogic, LoyaltyLogic>();
            builder.Services.TryAddScoped<IMailLogic, MailLogic>();
            builder.Services.TryAddScoped<IMarketLogic, MarketLogic>();
            builder.Services.TryAddScoped<IOpportunitiesLogic, OpportunitiesLogic>();
            builder.Services.TryAddScoped<IPlanetaryInteractionLogic, PlanetaryInteractionLogic>();
            builder.Services.TryAddScoped<IRoutesLogic, RoutesLogic>();
            builder.Services.TryAddScoped<ISearchLogic, SearchLogic>();
            builder.Services.TryAddScoped<ISkillsLogic, SkillsLogic>();
            builder.Services.TryAddScoped<ISovereigntyLogic, SovereigntyLogic>();
            builder.Services.TryAddScoped<IStatusLogic, StatusLogic>();
            builder.Services.TryAddScoped<IUniverseLogic, UniverseLogic>();
            builder.Services.TryAddScoped<IUserInterfaceLogic, UserInterfaceLogic>();
            builder.Services.TryAddScoped<IWalletLogic, WalletLogic>();
            builder.Services.TryAddScoped<IWarsLogic, WarsLogic>();

            return builder;
        }

        public static IEsiClientConfigurationBuilder AddPiplineHandlers(this IEsiClientConfigurationBuilder builder)
        {
            builder.Services.TryAddSingleton<RequestHeadersHandler>();
            builder.Services.TryAddSingleton<UrlRequestParametersHandler>();
            builder.Services.TryAddSingleton<RequestGetHandler>();
            builder.Services.TryAddSingleton<RequestPostHandler>();
            builder.Services.TryAddSingleton<RequestDeleteHandler>();
            builder.Services.TryAddSingleton<RequestPutHandler>();
            builder.Services.TryAddSingleton<ETagHandler>();
            builder.Services.TryAddSingleton<EndpointHandler>();
            builder.Services.TryAddSingleton<ProtectionHandler>();
            builder.Services.TryAddSingleton<BodyRequestParametersHandler>();

            return builder;
        }

        public static IEsiClientConfigurationBuilder CustomizePipline(this IEsiClientConfigurationBuilder builder, Action<IPiplineModificationsBuilder> configure)
        {
            configure(builder.PiplineModificationBuilder);

            if (builder.PiplineModificationBuilder is PiplineModificationsBuilder modificationBuilder)
            {
                modificationBuilder.Validate();

                foreach (var modification in modificationBuilder.Modifications)
                {
                    builder.AddPiplineModification(modification);
                }
            }

            return builder;
        }

        internal static IEsiClientConfigurationBuilder AddPiplineModification(this IEsiClientConfigurationBuilder builder, PiplineModification modification)
        {
            builder.Services.AddSingleton(modification);
            return builder;
        }

        /// <summary>
        /// Adds the specified <see cref="IAccessTokenProvider"/> as a <see cref="ServiceLifetime.Transient"/> service
        /// to the <see cref="IServiceCollection"/> if the service type hasn't already been registered.
        /// </summary>
        /// <typeparam name="T">The <see cref="IAccessTokenProvider"/> implementation.</typeparam>
        /// <param name="builder">The <see cref="IEsiClientConfigurationBuilder"/>.</param>
        /// <returns>The <see cref="IEsiClientConfigurationBuilder"/>.</returns>
        public static IEsiClientConfigurationBuilder UseAccessTokenProvider<T>(this IEsiClientConfigurationBuilder builder)
        {
            return builder.UseAccessTokenProvider(typeof(T));
        }

        /// <summary>
        /// Adds the specified <see cref="IAccessTokenProvider"/> as a <see cref="ServiceLifetime.Transient"/> service
        /// with the <paramref name="instanceType"/> implementation
        /// to the <see cref="IServiceCollection"/> if the service type hasn't already been registered.
        /// </summary>
        /// <param name="builder">The <see cref="IEsiClientConfigurationBuilder"/>.</param>
        /// <param name="instanceType">The implementation type of the service.</param>
        /// <returns>The <see cref="IEsiClientConfigurationBuilder"/>.</returns>
        public static IEsiClientConfigurationBuilder UseAccessTokenProvider(this IEsiClientConfigurationBuilder builder, Type instanceType)
        {
            IsAssignableFrom(typeof(IAccessTokenProvider), instanceType);

            builder.Services.TryAddTransient(typeof(IAccessTokenProvider), instanceType);

            return builder;
        }

        /// <summary>
        /// Adds the specified <see cref="IScopeAccessValidator"/> as a <see cref="ServiceLifetime.Transient"/> service
        /// to the <see cref="IServiceCollection"/> if the service type hasn't already been registered.
        /// </summary>
        /// <typeparam name="T">The <see cref="IScopeAccessValidator"/> implementation.</typeparam>
        /// <param name="builder">The <see cref="IEsiClientConfigurationBuilder"/>.</param>
        /// <returns>The <see cref="IEsiClientConfigurationBuilder"/>.</returns>
        public static IEsiClientConfigurationBuilder UseScopeValidator<T>(this IEsiClientConfigurationBuilder builder)
        {
            return builder.UseScopeValidator(typeof(T));
        }

        /// <summary>
        /// Adds the specified <see cref="IScopeAccessValidator"/> as a <see cref="ServiceLifetime.Transient"/> service
        /// with the <paramref name="instanceType"/> implementation
        /// to the <see cref="IServiceCollection"/> if the service type hasn't already been registered.
        /// </summary>
        /// <param name="builder">The <see cref="IEsiClientConfigurationBuilder"/>.</param>
        /// <param name="instanceType">The implementation type of the service.</param>
        /// <returns>The <see cref="IEsiClientConfigurationBuilder"/>.</returns>
        public static IEsiClientConfigurationBuilder UseScopeValidator(this IEsiClientConfigurationBuilder builder, Type instanceType)
        {
            IsAssignableFrom(typeof(IScopeAccessValidator), instanceType);

            builder.Services.AddSingletonWithReplace(typeof(IScopeAccessValidator), instanceType);

            return builder;
        }

        /// <summary>
        /// Adds the specified <see cref="IETagStorage"/> as a <see cref="ServiceLifetime.Singleton"/> service
        /// to the <see cref="IServiceCollection"/> if the service type hasn't already been registered.
        /// </summary>
        /// <typeparam name="T">The <see cref="IETagStorage"/> implementation.</typeparam>
        /// <param name="builder">The <see cref="IEsiClientConfigurationBuilder"/>.</param>
        /// <returns>The <see cref="IEsiClientConfigurationBuilder"/>.</returns>
        public static IEsiClientConfigurationBuilder UseETagStorage<T>(this IEsiClientConfigurationBuilder builder)
        {
            return builder.UseETagStorage(typeof(T));
        }

        /// <summary>
        /// Adds the specified <see cref="IETagStorage"/> as a <see cref="ServiceLifetime.Singleton"/> service
        /// with the <paramref name="instanceType"/> implementation
        /// to the <see cref="IServiceCollection"/> if the service type hasn't already been registered.
        /// </summary>
        /// <param name="builder">The <see cref="IEsiClientConfigurationBuilder"/>.</param>
        /// <param name="instanceType">The implementation type of the service.</param>
        /// <returns>The <see cref="IEsiClientConfigurationBuilder"/>.</returns>
        public static IEsiClientConfigurationBuilder UseETagStorage(this IEsiClientConfigurationBuilder builder, Type instanceType)
        {
            IsAssignableFrom(typeof(IETagStorage), instanceType);

            builder.Services.AddSingletonWithReplace(typeof(IETagStorage), instanceType);

            return builder;
        }

        private static void IsAssignableFrom(Type from, Type to)
        {
            if (!(from.GetTypeInfo().IsAssignableFrom(to.GetTypeInfo())))
            {
                throw new InvalidCastException($"{to.FullName} is not assignable from {from.FullName}");
            }
        }
    }
}
