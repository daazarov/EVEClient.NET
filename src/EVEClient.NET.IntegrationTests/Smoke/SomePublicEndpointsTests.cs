using EVEClient.NET.Defaults;
using EVEClient.NET.IntegrationTests.Fakes;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;
using System.Net;

namespace EVEClient.NET.IntegrationTests.Smoke
{
    [TestFixture]
    public class SomePublicEndpointsTests
    {
        private const int CharacterId = 2119944183;

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
        public async Task GetCharacterInfo()
        {
            System.Diagnostics.Debug.WriteLine($"Execute: GetCharacterInfo");

            var response = await _logicAccessor.CharacterLogic.PublicInformation(CharacterId);

            System.Diagnostics.Debug.WriteLine($"Execute: GetCharacterInfo: Complete");

            Assert.That(response.Success, Is.True);
            Assert.That(response.Data, Is.Not.Null);
        }

        [Test]
        public async Task GetCharacterInfo_eTag()
        {
            System.Diagnostics.Debug.WriteLine($"Execute: GetCharacterInfo_eTag");

            var response = await _logicAccessor.CharacterLogic.PublicInformation(CharacterId);
            var response1 = await _logicAccessor.CharacterLogic.PublicInformation(CharacterId);

            System.Diagnostics.Debug.WriteLine($"Execute: GetCharacterInfo_eTag: Complete");

            Assert.That(response.Success, Is.True);
            Assert.That(response.Data, Is.Not.Null);

            Assert.That(response1.Success, Is.True);
            Assert.That(response1.StatusCode, Is.EqualTo(HttpStatusCode.NotModified));
            Assert.That(response1.Data, Is.Null);
        }

        [Test]
        public async Task GetCharacterCorporationHistory()
        {
            System.Diagnostics.Debug.WriteLine($"Execute: GetCharacterCorporationHistory");

            var response = await _logicAccessor.CharacterLogic.CorporationHistory(CharacterId);

            System.Diagnostics.Debug.WriteLine($"Execute: GetCharacterCorporationHistory: Complete");

            Assert.That(response.Success, Is.True);
            Assert.That(response.Data, Is.Not.Null);
        }
    }
}
