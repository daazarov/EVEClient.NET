using NUnit.Framework;

namespace EVEOnline.ESI.Communication.IntegrationTests.WarningHeader
{
    public class CalendarLogicTests : WarningHeaderTestsBase
    {
        [TestCaseSource(nameof(EndpointVersions), new object[] { ESI.Endpoints.Calendar.CalendarItems })]
        public async Task CalendarItems_Test(EndpointVersion endpointVersion)
        {
            var characterId = 2119944183;

            var response = await _logicAccessor.CalendarLogic.GetCharacterSummaryCalendarEventsAsync(characterId);

            Assert.That(response.Success, Is.True);
            Assert.That(response.Warning, Is.Null);
        }
    }
}
