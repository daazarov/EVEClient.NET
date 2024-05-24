using NUnit.Framework;

namespace EVEClient.NET.IntegrationTests.WarningHeader
{
    public class CalendarLogicTests : WarningHeaderTestsBase
    {
        public async Task CalendarItems_Test()
        {
            var characterId = 2119944183;

            var response = await _logicAccessor.CalendarLogic.CalendarItems(characterId);

            Assert.That(response.Success, Is.True);
            Assert.That(response.Warning, Is.Null);
        }
    }
}
