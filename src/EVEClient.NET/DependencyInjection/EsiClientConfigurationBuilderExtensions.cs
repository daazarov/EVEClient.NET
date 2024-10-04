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
        /// <summary>
        /// Adds the configured HTTP client.
        /// </summary>
        /// <param name="builder">The <see cref="IEsiClientConfigurationBuilder"/>.</param>
        public static IEsiClientConfigurationBuilder AddRequiredClientServices(this IEsiClientConfigurationBuilder builder)
        {
            builder.Services
                .AddHttpClient(ESI.HttpClientName, httpClient =>
                {
                    httpClient.BaseAddress = new Uri(builder.Configuration.EsiBaseUrl);
                })
                .ConfigurePrimaryHttpMessageHandler(() => new HttpClientHandler
                { 
                    AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate
                });

            builder.Services.TryAddScoped<IEsiHttpClient, EsiHttpClient>();
            builder.Services.TryAddSingleton<IEndpointConfigurationProvider, EndpointConfigurationProvider>();

            return builder;
        }

        /// <summary>
        /// Adds the default implementations.
        /// </summary>
        /// <param name="builder">The <see cref="IEsiClientConfigurationBuilder"/>.</param>
        public static IEsiClientConfigurationBuilder AddDefaults(this IEsiClientConfigurationBuilder builder)
        {
            builder.Services.TryAddSingleton<IETagStorage, DefaultInMemoryETagThreadSaveStore>();
            builder.Services.TryAddSingleton<IPiplineStore, PiplineStore>();

            return builder;
        }

        /// <summary>
        /// Adds the <see cref="IEsiLogicAccessor"/> and all inner services.
        /// </summary>
        /// <param name="builder">The <see cref="IEsiClientConfigurationBuilder"/>.</param>
        public static IEsiClientConfigurationBuilder AddEsiLogic(this IEsiClientConfigurationBuilder builder)
        {
            builder.Services.TryAddScoped<IEsiLogicAccessor, EsiLogicAccessor>();
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

        /// <summary>
        /// Registers all default pipline handlers.
        /// </summary>
        /// <param name="builder">The <see cref="IEsiClientConfigurationBuilder"/>.</param>
        public static IEsiClientConfigurationBuilder AddPiplineHandlers(this IEsiClientConfigurationBuilder builder)
        {
            // handlers without injections
            builder.Services.TryAddSingleton<EndpointHandler>();
            builder.Services.TryAddSingleton<BodyRequestParametersHandler>();

            // handlers with injections
            builder.Services.TryAddScoped<RequestHandler>();
            builder.Services.TryAddScoped<ETagHandler>();
            builder.Services.TryAddScoped<ProtectionHandler>();
            builder.Services.TryAddScoped<UrlRequestParametersHandler>();

            return builder;
        }

        /// <summary>
        /// Allows  to customize the request middleware for one or more ESI endpoints.
        /// </summary>
        /// <param name="builder">The <see cref="IEsiClientConfigurationBuilder"/>.</param>
        /// <param name="configure">The action delegate witch configure <see cref="IPiplineModificationsBuilder"/>.</param>
        /// <exception cref="InvalidOperationException"></exception>
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

        /// <summary>
        /// Adds the public <see cref="IAccessTokenProvider"/> and  <see cref="IScopeAccessValidator"/> to the <see cref="IServiceCollection"/> if the service type hasn't already been registered.
        /// </summary>
        /// <remarks>If you try to call a protected enpoint, an <see cref="InvalidOperationException"/> exception will be raised.</remarks>
        /// <param name="builder">The <see cref="IEsiClientConfigurationBuilder"/>.</param>
        /// <returns>The <see cref="IEsiClientConfigurationBuilder"/>.</returns>
        public static IEsiClientConfigurationBuilder UseOnlyPublicEndpoints(this IEsiClientConfigurationBuilder builder)
        {
            builder.AddAccessTokenProvider<PublicAccessTokenProvider>();
            builder.AddScopeValidator<PublicScopeAccessValidator>();

            return builder;
        }

        /// <summary>
        /// Adds the specified <see cref="IAccessTokenProvider"/> as a <see cref="ServiceLifetime.Transient"/> service
        /// to the <see cref="IServiceCollection"/> if the service type hasn't already been registered.
        /// </summary>
        /// <typeparam name="T">The <see cref="IAccessTokenProvider"/> implementation.</typeparam>
        /// <param name="builder">The <see cref="IEsiClientConfigurationBuilder"/>.</param>
        /// <returns>The <see cref="IEsiClientConfigurationBuilder"/>.</returns>
        public static IEsiClientConfigurationBuilder AddAccessTokenProvider<T>(this IEsiClientConfigurationBuilder builder)
        {
            return builder.AddAccessTokenProvider(typeof(T));
        }

        /// <summary>
        /// Adds the specified <see cref="IAccessTokenProvider"/> as a <see cref="ServiceLifetime.Transient"/> service
        /// with the <paramref name="instanceType"/> implementation
        /// to the <see cref="IServiceCollection"/> if the service type hasn't already been registered.
        /// </summary>
        /// <param name="builder">The <see cref="IEsiClientConfigurationBuilder"/>.</param>
        /// <param name="instanceType">The implementation type of the service.</param>
        /// <returns>The <see cref="IEsiClientConfigurationBuilder"/>.</returns>
        public static IEsiClientConfigurationBuilder AddAccessTokenProvider(this IEsiClientConfigurationBuilder builder, Type instanceType)
        {
            IsAssignableFrom(typeof(IAccessTokenProvider), instanceType);

            builder.Services.AddScopedWithReplace(typeof(IAccessTokenProvider), instanceType);

            return builder;
        }

        /// <summary>
        /// Adds the specified <see cref="IScopeAccessValidator"/> as a <see cref="ServiceLifetime.Transient"/> service
        /// to the <see cref="IServiceCollection"/> if the service type hasn't already been registered.
        /// </summary>
        /// <typeparam name="T">The <see cref="IScopeAccessValidator"/> implementation.</typeparam>
        /// <param name="builder">The <see cref="IEsiClientConfigurationBuilder"/>.</param>
        /// <returns>The <see cref="IEsiClientConfigurationBuilder"/>.</returns>
        public static IEsiClientConfigurationBuilder AddScopeValidator<T>(this IEsiClientConfigurationBuilder builder)
        {
            return builder.AddScopeValidator(typeof(T));
        }

        /// <summary>
        /// Adds the specified <see cref="IScopeAccessValidator"/> as a <see cref="ServiceLifetime.Transient"/> service
        /// with the <paramref name="instanceType"/> implementation
        /// to the <see cref="IServiceCollection"/> if the service type hasn't already been registered.
        /// </summary>
        /// <param name="builder">The <see cref="IEsiClientConfigurationBuilder"/>.</param>
        /// <param name="instanceType">The implementation type of the service.</param>
        /// <returns>The <see cref="IEsiClientConfigurationBuilder"/>.</returns>
        public static IEsiClientConfigurationBuilder AddScopeValidator(this IEsiClientConfigurationBuilder builder, Type instanceType)
        {
            IsAssignableFrom(typeof(IScopeAccessValidator), instanceType);

            builder.Services.AddScopedWithReplace(typeof(IScopeAccessValidator), instanceType);

            return builder;
        }

        /// <summary>
        /// Adds the specified <see cref="IETagStorage"/> as a <see cref="ServiceLifetime.Singleton"/> service
        /// to the <see cref="IServiceCollection"/> if the service type hasn't already been registered.
        /// </summary>
        /// <typeparam name="T">The <see cref="IETagStorage"/> implementation.</typeparam>
        /// <param name="builder">The <see cref="IEsiClientConfigurationBuilder"/>.</param>
        /// <returns>The <see cref="IEsiClientConfigurationBuilder"/>.</returns>
        public static IEsiClientConfigurationBuilder AddETagStorage<T>(this IEsiClientConfigurationBuilder builder)
        {
            return builder.AddETagStorage(typeof(T));
        }

        /// <summary>
        /// Adds the specified <see cref="IETagStorage"/> as a <see cref="ServiceLifetime.Singleton"/> service
        /// with the <paramref name="instanceType"/> implementation
        /// to the <see cref="IServiceCollection"/> if the service type hasn't already been registered.
        /// </summary>
        /// <param name="builder">The <see cref="IEsiClientConfigurationBuilder"/>.</param>
        /// <param name="instanceType">The implementation type of the service.</param>
        /// <returns>The <see cref="IEsiClientConfigurationBuilder"/>.</returns>
        public static IEsiClientConfigurationBuilder AddETagStorage(this IEsiClientConfigurationBuilder builder, Type instanceType)
        {
            IsAssignableFrom(typeof(IETagStorage), instanceType);

            builder.Services.AddScopedWithReplace(typeof(IETagStorage), instanceType);

            return builder;
        }

        private static IEsiClientConfigurationBuilder AddPiplineModification(this IEsiClientConfigurationBuilder builder, PiplineModification modification)
        {
            builder.Services.AddSingleton(modification);
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
