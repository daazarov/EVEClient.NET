using EVEOnline.ESI.Communication.DataContract;
using EVEOnline.ESI.Communication.UnitTests.Datasets.Providers;
using NUnit.Framework;

namespace EVEOnline.ESI.Communication.UnitTests.DeserializationTests.Status
{
    [TestFixture]
    public class DeserializationTests
    {
        private const string FileName = "deserialization.status.json";
        private const string CustomSectionName = "";

        [TestCaseSource(typeof(DeserializationTestCaseSourceProvider<ServerStatus>), nameof(DeserializationTestCaseSourceProvider<ServerStatus>.GetTestData), new object[] { FileName, CustomSectionName })]
        public void Deserialization_Status_ServerStatus(ServerStatus model)
        {
            Assert.That(model, Is.Not.Null);
            Assert.That(model.Players, Is.EqualTo(12345));
            Assert.That(model.ServerVersion, Is.EqualTo("1132976"));
            Assert.That(model.StartTime.Year, Is.EqualTo(2017));
            Assert.That(model.Vip, Is.True);
        }
    }
}
