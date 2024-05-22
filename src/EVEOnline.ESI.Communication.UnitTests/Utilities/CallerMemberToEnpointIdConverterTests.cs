using EVEOnline.ESI.Communication.Utilities;
using NUnit.Framework;

namespace EVEOnline.ESI.Communication.UnitTests.Utilities
{
    public class CallerMemberToEnpointIdConverterTests
    {
        [Test]
        public void CallerMemberToEnpointIdConverterTests_UniqiueValues()
        {
            Assert.That(() => CallerMemberToEnpointIdConverter._dataset.Values.Distinct().Count() == CallerMemberToEnpointIdConverter._dataset.Count);
        }

        [Test]
        public void CallerMemberToEnpointIdConverterTests_NotEmpryValues()
        {
            Assert.That(() => !CallerMemberToEnpointIdConverter._dataset.Values.Any(x => string.IsNullOrEmpty(x)));
        }
    }
}
