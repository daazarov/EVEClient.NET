using EVEClient.NET.DataContract;
using EVEClient.NET.UnitTests.Datasets.Providers;
using NUnit.Framework;

namespace EVEClient.NET.UnitTests.DeserializationTests.Location
{
    [TestFixture]
    public class DeserializationTests
    {
        private const string FileName = "deserialization.location.json";
        private const string CustomSectionName = "";

        [TestCaseSource(typeof(DeserializationTestCaseSourceProvider<DataContract.Location>), nameof(DeserializationTestCaseSourceProvider<DataContract.Location>.GetTestData), new object[] { FileName, CustomSectionName })]
        public void Deserialization_Location_Location(DataContract.Location model)
        {
            Assert.That(model, Is.Not.Null);
            Assert.That(model.SolarSystemId, Is.EqualTo(30002505));
            Assert.That(model.StructureId, Is.EqualTo(1000000016989));
            Assert.That(model.StationId, Is.EqualTo(651111114));
        }

        [TestCaseSource(typeof(DeserializationTestCaseSourceProvider<Activity>), nameof(DeserializationTestCaseSourceProvider<Activity>.GetTestData), new object[] { FileName, CustomSectionName })]
        public void Deserialization_Location_Activity(Activity model)
        {
            Assert.That(model, Is.Not.Null);
            Assert.That(model.Logins, Is.EqualTo(9001));
            Assert.That(model.LastLogin.HasValue, Is.True);
            Assert.That(model.LastLogin.Value.Year, Is.EqualTo(2018));
            Assert.That(model.LastLogout.HasValue, Is.True);
            Assert.That(model.LastLogout.Value.Year, Is.EqualTo(2017));
            Assert.That(model.Online, Is.True);
        }

        [TestCaseSource(typeof(DeserializationTestCaseSourceProvider<Ship>), nameof(DeserializationTestCaseSourceProvider<Ship>.GetTestData), new object[] { FileName, CustomSectionName })]
        public void Deserialization_Location_Ship(Ship model)
        {
            Assert.That(model, Is.Not.Null);
            Assert.That(model.ShipItemId, Is.EqualTo(1000000016991));
            Assert.That(model.ShipName, Is.EqualTo("SPACESHIPS!!!"));
            Assert.That(model.ShipTypeId, Is.EqualTo(1233));
        }
    }
}
