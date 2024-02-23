using EVEOnline.ESI.Communication.Utilities.Stores;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;

namespace EVEOnline.ESI.Communication.IntegrationTests.Smoke
{
    [TestFixture]
    internal class SomePublicEndpointsTests
    {
        private ServiceProvider _serviceProvider;
        private ServiceCollection _serviceCollection;
        private IEsiLogicAccessor _logicAccessor;

        private const int CharacterId = 2119944183;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            _serviceCollection = new ServiceCollection();

            _serviceCollection.AddEVEOnlineEsiClient(config =>
            {
                config.Server = "tranquility";
                config.UserAgent = "github.com/daazarov/EVEOnline.ESI.Communication smoke tests";
                config.BaseUrl = "https://esi.evetech.net";
                config.EnableETag = true;
            });

            _serviceProvider = _serviceCollection.BuildServiceProvider();

            _logicAccessor = _serviceProvider.GetService<IEsiLogicAccessor>()!;
        }

        [SetUp]
        public void PerTestsSetup()
        {
            (_serviceProvider.GetService<IETagStorage>() as DefaultInMemoryETagThreadSaveStore)!.Clear();
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            _serviceProvider.Dispose();
        }

        [Test]
        public async Task GetCharacterInfo()
        {
            var response = await _logicAccessor.CharacterLogic.GetCharacterPulicInformationAsync(CharacterId);

            Assert.That(response.Success, Is.True);
            Assert.That(response.Data, Is.Not.Null);
        }

        [Test]
        public async Task GetCharacterInfo_eTag()
        {
            var response = await _logicAccessor.CharacterLogic.GetCharacterPulicInformationAsync(CharacterId);
            var response1 = await _logicAccessor.CharacterLogic.GetCharacterPulicInformationAsync(CharacterId);

            Assert.That(response.Success, Is.True);
            Assert.That(response.Data, Is.Not.Null);

            Assert.That(response1.Success, Is.True);
            Assert.That(response1.StatusCode, Is.EqualTo(HttpStatusCode.NotModified));
            Assert.That(response1.Data, Is.Null);
        }

        [Test]
        public async Task GetCharacterCorporationHistory()
        {
            var response = await _logicAccessor.CharacterLogic.GetCharacterCorporationHistoryAsync(CharacterId);

            Assert.That(response.Success, Is.True);
            Assert.That(response.Data, Is.Not.Null);
        }
    }
}
