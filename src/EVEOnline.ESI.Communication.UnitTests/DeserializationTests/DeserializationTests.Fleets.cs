using EVEOnline.ESI.Communication.DataContract;
using EVEOnline.ESI.Communication.UnitTests.Datasets.Providers;
using NUnit.Framework;

namespace EVEOnline.ESI.Communication.UnitTests.DeserializationTests.Fleets
{
    [TestFixture]
    public class DeserializationTests
    {
        private const string FileName = "deserialization.fleets.json";
        private const string CustomSectionName = "";

        [TestCaseSource(typeof(DeserializationTestCaseSourceProvider<NewWing>), nameof(DeserializationTestCaseSourceProvider<NewWing>.GetTestData), new object[] { FileName, CustomSectionName })]
        public void Deserialization_Fleets_NewWing(NewWing model)
        {
            Assert.That(model, Is.Not.Null);
            Assert.That(model.WingId, Is.EqualTo(123));
        }

        [TestCaseSource(typeof(DeserializationTestCaseSourceProvider<NewSquad>), nameof(DeserializationTestCaseSourceProvider<NewSquad>.GetTestData), new object[] { FileName, CustomSectionName })]
        public void Deserialization_Fleets_NewSquad(NewSquad model)
        {
            Assert.That(model, Is.Not.Null);
            Assert.That(model.SquadId, Is.EqualTo(123));
        }

        [TestCaseSource(typeof(DeserializationTestCaseSourceProvider<FleetSettings>), nameof(DeserializationTestCaseSourceProvider<FleetSettings>.GetTestData), new object[] { FileName, CustomSectionName })]
        public void Deserialization_Fleets_FleetSettings(FleetSettings model)
        {
            Assert.That(model, Is.Not.Null);
            Assert.That(model.IsRegistered, Is.True);
            Assert.That(model.IsVoiceEnabled, Is.True);
            Assert.That(model.IsFreeMove, Is.True);
            Assert.That(model.Motd, Is.EqualTo("This is an <b>awesome</b> fleet!"));
        }

        [TestCaseSource(typeof(DeserializationTestCaseSourceProvider<FleetInfo>), nameof(DeserializationTestCaseSourceProvider<FleetInfo>.GetTestData), new object[] { FileName, CustomSectionName })]
        public void Deserialization_Fleets_FleetInfo(FleetInfo model)
        {
            Assert.That(model, Is.Not.Null);
            Assert.That(model.FleetId, Is.EqualTo(1234567890));
            Assert.That(model.Role, Is.EqualTo(FleetRole.FleetCommander));
            Assert.That(model.SquadId, Is.EqualTo(-1));
            Assert.That(model.WingId, Is.EqualTo(-1));
        }

        [TestCaseSource(typeof(DeserializationTestCaseSourceProvider<Wing>), nameof(DeserializationTestCaseSourceProvider<Wing>.GetTestData), new object[] { FileName, CustomSectionName })]
        public void Deserialization_Fleets_Wing(Wing model)
        {
            Assert.That(model, Is.Not.Null);
            Assert.That(model.Id, Is.EqualTo(2073711261968));
            Assert.That(model.Name, Is.EqualTo("Wing 1"));
            Assert.That(model.Squads, Is.Not.Empty);
            Assert.That(model.Squads.First().Name, Is.EqualTo("Squad 1"));
            Assert.That(model.Squads.First().Id, Is.EqualTo(3129411261968));
        }

        [TestCaseSource(typeof(DeserializationTestCaseSourceProvider<FleetMember>), nameof(DeserializationTestCaseSourceProvider<FleetMember>.GetTestData), new object[] { FileName, CustomSectionName })]
        public void Deserialization_Fleets_FleetMember(FleetMember model)
        {
            Assert.That(model, Is.Not.Null);
            Assert.That(model.CharacterId, Is.EqualTo(93265215));
            Assert.That(model.Role, Is.EqualTo(FleetRole.SquadCommander));
            Assert.That(model.SquadId, Is.EqualTo(3129411261968));
            Assert.That(model.WingId, Is.EqualTo(2073711261968));
            Assert.That(model.TakesFleetWarp, Is.True);
            Assert.That(model.StationId, Is.EqualTo(61000180));
            Assert.That(model.SolarSystemId, Is.EqualTo(30003729));
            Assert.That(model.ShipTypeId, Is.EqualTo(33328));
            Assert.That(model.RoleName, Is.EqualTo("Squad Commander (Boss)"));
            Assert.That(model.JoinTime.Year, Is.EqualTo(2016));
        }
    }
}
