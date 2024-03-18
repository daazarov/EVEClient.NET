using NUnit.Framework;
using System.Net;

namespace EVEOnline.ESI.Communication.IntegrationTests.Smoke
{
    [TestFixture]
    public class SomePublicEndpointsTests : SmokeTestsBase
    {
        private const int CharacterId = 2119944183;

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
