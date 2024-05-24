using System.Data;
using Microsoft.Extensions.DependencyInjection;

using Moq;
using NUnit.Framework;

using EVEClient.NET.IntegrationTests.Fakes;

namespace EVEClient.NET.IntegrationTests.WarningHeader
{
    [TestFixture]
    [Category("DeprecatedHeaderTests")]
    public class WarningHeaderTestsBase
    {
        protected ServiceProvider _serviceProvider;
        protected ServiceCollection _serviceCollection;
        protected IEsiLogicAccessor _logicAccessor;

        [SetUp]
        public async Task PerTestsSetup()
        {
            // X-ESI-Error-Limit-Remain & X-ESI-Error-Limit-Reset headers
            // Artificially slowing down test execution so as not to overstep the threshold.
            // There is no need to complete each request successfully, the warning header comes even in 4xx responses.
            // However, you need to be authorized.
            await Task.Delay(500);

            ConfigureServiceProvider();
        }

        [TearDown]
        public void Cleanup()
        {
            _serviceProvider.Dispose();
        }

        private void ConfigureServiceProvider()
        {
            _serviceCollection = new ServiceCollection();

            _serviceCollection.AddEVEOnlineEsiClient(config =>
            {
                config.UserAgent = "github.com/daazarov/EVEClient.NET warning headers CI tests";
            })
            .UseAccessTokenProvider<AccessTokenProviderFake>();

            _serviceProvider = _serviceCollection.BuildServiceProvider();
            _logicAccessor = _serviceProvider.GetService<IEsiLogicAccessor>()!;
        }
    }
}
