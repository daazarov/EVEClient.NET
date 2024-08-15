using EVEClient.NET.Configuration;
using EVEClient.NET.Handlers;
using EVEClient.NET.Pipline;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using NUnit.Framework;

namespace EVEClient.NET.UnitTests
{
    [TestFixture]
    public class DependencyInjectionTests
    {
        private ServiceCollection _serviceCollection;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            _serviceCollection = new ServiceCollection();
            _serviceCollection.AddEVEOnlineEsiClient(config => config.UserAgent = "1111");
        }

        [TestCase(typeof(ICharacterLogic))]
        [TestCase(typeof(IAllianceLogic))]
        [TestCase(typeof(IAssetsLogic))]
        [TestCase(typeof(IBookmarksLogic))]
        [TestCase(typeof(ICalendarLogic))]
        [TestCase(typeof(IClonesLogic))]
        [TestCase(typeof(IContactsLogic))]
        [TestCase(typeof(IContractsLogic))]
        [TestCase(typeof(ICorporationLogic))]
        [TestCase(typeof(IDogmaLogic))]
        [TestCase(typeof(IFactionWarfareLogic))]
        [TestCase(typeof(IFittingsLogic))]
        [TestCase(typeof(IFleetsLogic))]
        [TestCase(typeof(IIncursionsLogic))]
        [TestCase(typeof(IIndustryLogic))]
        [TestCase(typeof(IInsuranceLogic))]
        [TestCase(typeof(IKillmailsLogic))]
        [TestCase(typeof(ILocationLogic))]
        [TestCase(typeof(ILoyaltyLogic))]
        [TestCase(typeof(IMailLogic))]
        [TestCase(typeof(IMarketLogic))]
        [TestCase(typeof(IOpportunitiesLogic))]
        [TestCase(typeof(IPlanetaryInteractionLogic))]
        [TestCase(typeof(IRoutesLogic))]
        [TestCase(typeof(ISearchLogic))]
        [TestCase(typeof(ISkillsLogic))]
        [TestCase(typeof(IUniverseLogic))]
        [TestCase(typeof(IUserInterfaceLogic))]
        [TestCase(typeof(IWalletLogic))]
        [TestCase(typeof(IWarsLogic))]
        public void ServiceCollection_ContainsLogic(Type type)
        {
            Assert.That(_serviceCollection.Single(x => x.ServiceType == type), Is.Not.Null);
            Assert.That(_serviceCollection.Single(x => x.ServiceType == type).Lifetime, Is.EqualTo(ServiceLifetime.Scoped));
        }

        [TestCase(typeof(EndpointHandler), ServiceLifetime.Singleton)]
        [TestCase(typeof(ProtectionHandler), ServiceLifetime.Scoped)]
        [TestCase(typeof(RequestDeleteHandler), ServiceLifetime.Singleton)]
        [TestCase(typeof(RequestPutHandler), ServiceLifetime.Singleton)]
        [TestCase(typeof(RequestGetHandler), ServiceLifetime.Singleton)]
        [TestCase(typeof(RequestPostHandler), ServiceLifetime.Singleton)]
        [TestCase(typeof(UrlRequestParametersHandler), ServiceLifetime.Scoped)]
        [TestCase(typeof(RequestHeadersHandler), ServiceLifetime.Scoped)]
        [TestCase(typeof(ETagHandler), ServiceLifetime.Scoped)]
        [TestCase(typeof(BodyRequestParametersHandler), ServiceLifetime.Singleton)]
        public void ServiceCollection_ContainsHandlers(Type type, ServiceLifetime lifetime)
        {
            Assert.That(_serviceCollection.Single(x => x.ServiceType == type), Is.Not.Null);
            Assert.That(_serviceCollection.Single(x => x.ServiceType == type).Lifetime, Is.EqualTo(lifetime));
        }

        [TestCase(typeof(IETagStorage), ServiceLifetime.Singleton)]
        [TestCase(typeof(IPiplineStore), ServiceLifetime.Singleton)]
        [TestCase(typeof(IHttpClientFactory), ServiceLifetime.Singleton)]
        [TestCase(typeof(IEsiContextFactory), ServiceLifetime.Scoped)]
        [TestCase(typeof(IEsiLogicAccessor), ServiceLifetime.Scoped)]
        [TestCase(typeof(IEsiHttpClient<>), ServiceLifetime.Scoped)]
        public void ServiceCollection_ContainsOther(Type type, ServiceLifetime lifetime)
        {
            Assert.That(_serviceCollection.Single(x => x.ServiceType == type), Is.Not.Null);
            Assert.That(_serviceCollection.Single(x => x.ServiceType == type).Lifetime, Is.EqualTo(lifetime));
        }

        [Test]
        public void Configuration_Custom()
        {
            var services = new ServiceCollection();
            services.AddEVEOnlineEsiClient(config =>
            {
                config.UserAgent = "blah blah blah";
                config.EnableETag = true;
                config.Server = EVEOnlineServer.Singularity;
            });
            var provider = services.BuildServiceProvider();
            var options = provider.GetService<IOptions<EsiClientConfiguration>>().Value;

            Assert.That(options.UserAgent, Is.EqualTo("blah blah blah"));
            Assert.That(options.EnableETag, Is.True);
            Assert.That(options.EsiBaseUrl, Is.EqualTo(ESI.EsiBaseUrl));
            Assert.That(options.Server, Is.EqualTo(EVEOnlineServer.Singularity));
        }

        [Test]
        public void Configuration_Default()
        {
            var services = new ServiceCollection();
            services.AddEVEOnlineEsiClient(config =>
            {
                config.UserAgent = "blah blah blah";
            });
            var provider = services.BuildServiceProvider();
            var options = provider.GetService<IOptions<EsiClientConfiguration>>().Value;

            Assert.That(options.UserAgent, Is.EqualTo("blah blah blah"));
            Assert.That(options.EnableETag, Is.False);
            Assert.That(options.EsiBaseUrl, Is.EqualTo(ESI.EsiBaseUrl));
            Assert.That(options.Server, Is.EqualTo(EVEOnlineServer.Tranquility));
        }
    }
}
