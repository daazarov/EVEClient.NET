using System.Data;
using Microsoft.Extensions.DependencyInjection;

using Moq;
using NUnit.Framework;

using EVEOnline.ESI.Communication.IntegrationTests.Fakes;

namespace EVEOnline.ESI.Communication.IntegrationTests.WarningHeader
{
    [TestFixture]
    [Category("DeprecatedHeaderTests")]
    public class WarningHeaderTestsBase
    {
        private const EndpointVersion _excluded = EndpointVersion.Latest | EndpointVersion.Legacy | EndpointVersion.Dev;

        protected ServiceProvider _serviceProvider;
        protected ServiceCollection _serviceCollection;
        protected IEsiLogicAccessor _logicAccessor;

        protected Mock<ICustomEndpointRoutePriorityProvider> _customEndpointRoutePriorityProviderMock;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            _customEndpointRoutePriorityProviderMock = new Mock<ICustomEndpointRoutePriorityProvider>();
        }

        [SetUp]
        public async Task PerTestsSetup()
        {
            // X-ESI-Error-Limit-Remain & X-ESI-Error-Limit-Reset headers
            // Artificially slowing down test execution so as not to overstep the threshold.
            // There is no need to complete each request successfully, the warning header comes even in 4xx responses.
            // However, you need to be authorized.
            await Task.Delay(500);

            ConfigureCustomEnpointPriority();
            ConfigureServiceProvider();
        }

        [TearDown]
        public void Cleanup()
        {
            _serviceProvider.Dispose();
        }

        protected static IEnumerable<EndpointVersion> EndpointVersions(string method)
        {
            var availableRoutes = ESI.Endpoints.AvailableRoutes[method];

            foreach (EndpointVersion version in Enum.GetValues(typeof(EndpointVersion)))
            {
                if (availableRoutes.HasFlag(version) && !_excluded.HasFlag(version))
                {
                    yield return version;
                };
            }
        }

        private void ConfigureServiceProvider()
        {
            _serviceCollection = new ServiceCollection();

            _serviceCollection.AddEVEOnlineEsiClient(config =>
            {
                config.Server = "tranquility";
                config.UserAgent = "github.com/daazarov/EVEOnline.ESI.Communication warning headers CI tests";
                config.BaseUrl = "https://esi.evetech.net";
            })
            .UseAccessTokenProvider<AccessTokenProviderFake>();

            _serviceCollection.AddTransient(typeof(ICustomEndpointRoutePriorityProvider), (sp) => 
            {
                return _customEndpointRoutePriorityProviderMock.Object;
            });

            _serviceProvider = _serviceCollection.BuildServiceProvider();
            _logicAccessor = _serviceProvider.GetService<IEsiLogicAccessor>()!;
        }

        private void ConfigureCustomEnpointPriority()
        {
            var version = (EndpointVersion)TestContext.CurrentContext.Test.Arguments.Where(x => x is EndpointVersion).First()!;

            _customEndpointRoutePriorityProviderMock
                .Setup(x => x.GetRoutePrioritiesForEndpoint(It.IsAny<string>()))
                .Returns(new List<EndpointRoutePrioritySetting> { new EndpointRoutePrioritySetting { Version = version } });
        }
    }
}
