using EVEClient.NET.DataContract;
using EVEClient.NET.UnitTests.Datasets.Providers;
using NUnit.Framework;

namespace EVEClient.NET.UnitTests.DeserializationTests.Sovereignty
{
    [TestFixture]
    public class DeserializationTests
    {
        private const string FileName = "deserialization.sovereignty.json";
        private const string CustomSectionName = "";

        [TestCaseSource(typeof(DeserializationTestCaseSourceProvider<CampaignSovereignty>), nameof(DeserializationTestCaseSourceProvider<CampaignSovereignty>.GetTestData), new object[] { FileName, CustomSectionName })]
        public void Deserialization_Sovereignty_CampaignSovereignty(CampaignSovereignty model)
        {
            Assert.That(model, Is.Not.Null);
            Assert.That(model.AttackersScore, Is.EqualTo(0.4f));
            Assert.That(model.CampaignId, Is.EqualTo(32833));
            Assert.That(model.ConstellationId, Is.EqualTo(20000125));
            Assert.That(model.DefenderId, Is.EqualTo(1695357456));
            Assert.That(model.DefenderScore, Is.EqualTo(0.6f));
            Assert.That(model.EventType, Is.EqualTo(CampaignEventType.StationDefense));
            Assert.That(model.SolarSystemId, Is.EqualTo(30000856));
            Assert.That(model.StartTime.Year, Is.EqualTo(2016));
            Assert.That(model.StructureId, Is.EqualTo(61001096));

            Assert.That(model.Participants, Is.Not.Null);
            Assert.That(model.Participants, Is.Not.Empty);
            Assert.That(model.Participants.First().AllianceId, Is.EqualTo(6165161));
            Assert.That(model.Participants.First().Score, Is.EqualTo(0.7f));
        }

        [TestCaseSource(typeof(DeserializationTestCaseSourceProvider<SolarSystemSovereignty>), nameof(DeserializationTestCaseSourceProvider<SolarSystemSovereignty>.GetTestData), new object[] { FileName, CustomSectionName })]
        public void Deserialization_Sovereignty_SolarSystemSovereignty(SolarSystemSovereignty model)
        {
            Assert.That(model, Is.Not.Null);
            Assert.That(model.AllianceId, Is.EqualTo(74523743));
            Assert.That(model.CorporationId, Is.EqualTo(756755311));
            Assert.That(model.FactionId, Is.EqualTo(500001));
            Assert.That(model.SystemId, Is.EqualTo(30045334));
        }

        [TestCaseSource(typeof(DeserializationTestCaseSourceProvider<StructureSovereignty>), nameof(DeserializationTestCaseSourceProvider<StructureSovereignty>.GetTestData), new object[] { FileName, CustomSectionName })]
        public void Deserialization_Sovereignty_StructureSovereignty(StructureSovereignty model)
        {
            Assert.That(model, Is.Not.Null);
            Assert.That(model.AllianceId, Is.EqualTo(498125261));
            Assert.That(model.SolarSystemId, Is.EqualTo(30000570));
            Assert.That(model.StructureId, Is.EqualTo(1018253388776));
            Assert.That(model.StructureTypeId, Is.EqualTo(32226));
            Assert.That(model.VulnerabilityOccupancyLevel, Is.EqualTo(2f));
            Assert.That(model.VulnerableEndTime.HasValue, Is.True);
            Assert.That(model.VulnerableEndTime.Value.Year, Is.EqualTo(2017));
            Assert.That(model.VulnerableStartTime.HasValue, Is.True);
            Assert.That(model.VulnerableStartTime.Value.Year, Is.EqualTo(2016));
        }
    }
}
