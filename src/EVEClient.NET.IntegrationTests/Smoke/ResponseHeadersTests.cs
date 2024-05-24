using EVEClient.NET.Defaults;
using EVEClient.NET.IntegrationTests.Fakes;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;

namespace EVEClient.NET.IntegrationTests.Smoke
{
    [TestFixture]
    public class ResponseHeadersTests
    {
        protected IServiceScope _serviceScope;
        protected ServiceCollection _serviceCollection;
        protected IEsiLogicAccessor _logicAccessor;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            _serviceCollection = new ServiceCollection();

            _serviceCollection.AddEVEOnlineEsiClient(config =>
            {
                config.UserAgent = "github.com/daazarov/EVEClient.NET smoke tests";
                config.EnableETag = true;
            })
            .UseAccessTokenProvider<AccessTokenProviderEmptyFake>();

            _serviceScope = _serviceCollection.BuildServiceProvider().CreateScope();
            _logicAccessor = _serviceScope.ServiceProvider.GetService<IEsiLogicAccessor>()!;
        }

        [TearDown]
        public void PerTestsSetup()
        {
            var storage = _serviceScope.ServiceProvider.GetService<IETagStorage>() as DefaultInMemoryETagThreadSaveStore;
            storage.Clear();
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            _serviceScope.Dispose();
        }

        [Test]
        public async Task DefaultHeaders()
        {
            System.Diagnostics.Debug.WriteLine($"Execute: DefaultHeaders");

            var characterId = 2119944183;

            var response = await _logicAccessor.CharacterLogic.PublicInformation(characterId);

            System.Diagnostics.Debug.WriteLine($"Execute: DefaultHeaders: Complete");

            Assert.That(response.Success, Is.True);
            Assert.That(response.Expires.HasValue, Is.True);
            Assert.That(response.ErrorLimitRemain, Is.Not.EqualTo(0));
            Assert.That(response.ErrorLimitReset, Is.Not.EqualTo(TimeSpan.Zero));
            Assert.That(response.ETag, Is.Not.Null);
            Assert.That(response.RequestId, Is.Not.EqualTo(Guid.Empty));
            Assert.That(response.LastModified.HasValue, Is.True);
        }

        [Test]
        public async Task PaginationHeaders()
        {
            System.Diagnostics.Debug.WriteLine($"Execute: PaginationHeaders");

            var regionId = 10000001;

            var response = await _logicAccessor.MarketLogic.RegionOrders(regionId);

            System.Diagnostics.Debug.WriteLine($"Execute: PaginationHeaders: Complete");

            Assert.That(response.Success, Is.True);
            Assert.That(response.Pages, Is.Not.EqualTo(0));
        }
    }
}
