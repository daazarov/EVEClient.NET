﻿using EVEClient.NET.Defaults;
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
            .UseOnlyPublicEndpoints();

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
            var response = await _logicAccessor.CharacterLogic.PublicInformation(CharacterId);

            Assert.That(response.Success, Is.True);
            Assert.That(response.TryGetData(out var data, out _), Is.True);
            Assert.That(data, Is.Not.Null);
        }

        [Test]
        public async Task GetCharacterInfo_eTag()
        {
            var response = await _logicAccessor.CharacterLogic.PublicInformation(CharacterId);
            var response1 = await _logicAccessor.CharacterLogic.PublicInformation(CharacterId);

            Assert.That(response.Success, Is.True);
            Assert.That(response.TryGetData(out var responseData, out _), Is.True);
            Assert.That(responseData, Is.Not.Null);

            Assert.That(response1.Success, Is.True);
            Assert.That(response1.StatusCode, Is.EqualTo(HttpStatusCode.NotModified));
            Assert.That(response1.TryGetData(out var response1Data, out var message), Is.False);
            Assert.That(response1Data, Is.Null);
            Assert.That(message, Is.EqualTo("No results can be returned because the server returned the NotModified http status code."));
        }

        [Test]
        public async Task GetCharacterCorporationHistory()
        {
            var response = await _logicAccessor.CharacterLogic.CorporationHistory(CharacterId);

            Assert.That(response.Success, Is.True);
            Assert.That(response.TryGetData(out var data, out _), Is.True);
            Assert.That(data, Is.Not.Null);
        }
    }
}
