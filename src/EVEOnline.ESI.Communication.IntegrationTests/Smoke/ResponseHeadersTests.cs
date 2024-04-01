using NUnit.Framework;

namespace EVEOnline.ESI.Communication.IntegrationTests.Smoke
{
    public class ResponseHeadersTests : SmokeTestsBase
    {
        [Test]
        public async Task DefaultHeaders()
        {
            var characterId = 2119944183;

            var response = await _logicAccessor.CharacterLogic.GetCharacterPulicInformationAsync(characterId);

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
            var regionId = 10000001;

            var response = await _logicAccessor.MarketLogic.GetRegionOrders(regionId);

            Assert.That(response.Success, Is.True);
            Assert.That(response.Pages, Is.Not.EqualTo(0));
        }
    }
}
