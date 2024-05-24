using EVEClient.NET.DataContract;
using EVEClient.NET.UnitTests.Datasets.Providers;
using NUnit.Framework;

namespace EVEClient.NET.UnitTests.DeserializationTests.FactionWarfare
{
    [TestFixture]
    public class DeserializationTests
    {
        private const string FileName = "deserialization.factionwarfare.json";
        private const string CustomSectionName = "";

        [TestCaseSource(typeof(DeserializationTestCaseSourceProvider<FactionWar>), nameof(DeserializationTestCaseSourceProvider<FactionWar>.GetTestData), new object[] { FileName, CustomSectionName })]
        public void Deserialization_FactionWarfare_War(FactionWar model)
        {
            Assert.That(model, Is.Not.Null);
            Assert.That(model.AgainstId, Is.EqualTo(500002));
            Assert.That(model.FactionId, Is.EqualTo(500001));
        }

        [TestCaseSource(typeof(DeserializationTestCaseSourceProvider<FactionWarfareSystem>), nameof(DeserializationTestCaseSourceProvider<FactionWarfareSystem>.GetTestData), new object[] { FileName, CustomSectionName })]
        public void Deserialization_FactionWarfare_FactionWarfareSystem(FactionWarfareSystem model)
        {
            Assert.That(model, Is.Not.Null);
            Assert.That(model.Contested, Is.EqualTo(Contested.Uncontested));
            Assert.That(model.OccupierFactionId, Is.EqualTo(500001));
            Assert.That(model.VictoryPoints, Is.EqualTo(60));
            Assert.That(model.VictoryPointsThreshold, Is.EqualTo(3000));
            Assert.That(model.OwnerFactionId, Is.EqualTo(500001));
            Assert.That(model.SolarSystemId, Is.EqualTo(30002096));
        }

        [TestCaseSource(typeof(DeserializationTestCaseSourceProvider<FactionStats>), nameof(DeserializationTestCaseSourceProvider<FactionStats>.GetTestData), new object[] { FileName, CustomSectionName })]
        public void Deserialization_FactionWarfare_FactionStats(FactionStats model)
        {
            Assert.That(model, Is.Not.Null);
            Assert.That(model.Kills, Is.Not.Null);
            Assert.That(model.VictoryPoints, Is.Not.Null);
            Assert.That(model.Pilots, Is.EqualTo(28863));
            Assert.That(model.FactionId, Is.EqualTo(500001));
            Assert.That(model.SystemsControlled, Is.EqualTo(20));
            Assert.That(model.Kills.LastWeek, Is.EqualTo(893));
            Assert.That(model.Kills.Total, Is.EqualTo(684350));
            Assert.That(model.Kills.Yesterday, Is.EqualTo(136));
            Assert.That(model.VictoryPoints.LastWeek, Is.EqualTo(102640));
            Assert.That(model.VictoryPoints.Total, Is.EqualTo(52658260));
            Assert.That(model.VictoryPoints.Yesterday, Is.EqualTo(15980));
        }

        [TestCaseSource(typeof(DeserializationTestCaseSourceProvider<CharacterStats>), nameof(DeserializationTestCaseSourceProvider<CharacterStats>.GetTestData), new object[] { FileName, CustomSectionName })]
        public void Deserialization_FactionWarfare_CharacterStats(CharacterStats model)
        {
            Assert.That(model, Is.Not.Null);
            Assert.That(model.Kills, Is.Not.Null);
            Assert.That(model.VictoryPoints, Is.Not.Null);
            Assert.That(model.EnlistedOn.HasValue, Is.True);
            Assert.That(model.EnlistedOn.Value.Year, Is.EqualTo(2017));
            Assert.That(model.CurrentRank, Is.EqualTo(125));
            Assert.That(model.FactionId, Is.EqualTo(500001));
            Assert.That(model.HighestRank, Is.EqualTo(95));
            Assert.That(model.Kills.LastWeek, Is.EqualTo(893));
            Assert.That(model.Kills.Total, Is.EqualTo(684350));
            Assert.That(model.Kills.Yesterday, Is.EqualTo(136));
            Assert.That(model.VictoryPoints.LastWeek, Is.EqualTo(102640));
            Assert.That(model.VictoryPoints.Total, Is.EqualTo(52658260));
            Assert.That(model.VictoryPoints.Yesterday, Is.EqualTo(15980));
        }

        [TestCaseSource(typeof(DeserializationTestCaseSourceProvider<CorporationStats>), nameof(DeserializationTestCaseSourceProvider<CorporationStats>.GetTestData), new object[] { FileName, CustomSectionName })]
        public void Deserialization_FactionWarfare_CorporationStats(CorporationStats model)
        {
            Assert.That(model, Is.Not.Null);
            Assert.That(model.Kills, Is.Not.Null);
            Assert.That(model.VictoryPoints, Is.Not.Null);
            Assert.That(model.EnlistedOn.HasValue, Is.True);
            Assert.That(model.EnlistedOn.Value.Year, Is.EqualTo(2017));
            Assert.That(model.Pilots, Is.EqualTo(28863));
            Assert.That(model.FactionId, Is.EqualTo(500001));
            Assert.That(model.Kills.LastWeek, Is.EqualTo(893));
            Assert.That(model.Kills.Total, Is.EqualTo(684350));
            Assert.That(model.Kills.Yesterday, Is.EqualTo(136));
            Assert.That(model.VictoryPoints.LastWeek, Is.EqualTo(102640));
            Assert.That(model.VictoryPoints.Total, Is.EqualTo(52658260));
            Assert.That(model.VictoryPoints.Yesterday, Is.EqualTo(15980));
        }

        [TestCaseSource(typeof(DeserializationTestCaseSourceProvider<Leaderboards<FactionTotal>>), nameof(DeserializationTestCaseSourceProvider<Leaderboards<FactionTotal>>.GetTestData), new object[] { FileName, "FactionLeaderboards" })]
        public void Deserialization_FactionWarfare_FactionLeaderboards(Leaderboards<FactionTotal> model)
        {
            Assert.That(model, Is.Not.Null);
            Assert.That(model.Kills, Is.Not.Null);
            Assert.That(model.Kills.ActiveTotal, Is.Not.Null);
            Assert.That(model.Kills.ActiveTotal, Is.Not.Empty);
            Assert.That(model.Kills.Yesterday, Is.Not.Null);
            Assert.That(model.Kills.Yesterday, Is.Not.Empty);
            Assert.That(model.Kills.LastWeek, Is.Not.Null);
            Assert.That(model.Kills.LastWeek, Is.Not.Empty);
            Assert.That(model.Kills.ActiveTotal.First().FactionId, Is.EqualTo(500004));
            Assert.That(model.Kills.ActiveTotal.First().Amount, Is.EqualTo(832273));
            Assert.That(model.Kills.LastWeek.First().FactionId, Is.EqualTo(500001));
            Assert.That(model.Kills.LastWeek.First().Amount, Is.EqualTo(730));
            Assert.That(model.Kills.Yesterday.First().FactionId, Is.EqualTo(500001));
            Assert.That(model.Kills.Yesterday.First().Amount, Is.EqualTo(100));
            Assert.That(model.VictoryPoints, Is.Not.Null);
            Assert.That(model.VictoryPoints.ActiveTotal, Is.Not.Null);
            Assert.That(model.VictoryPoints.ActiveTotal, Is.Not.Empty);
            Assert.That(model.VictoryPoints.Yesterday, Is.Not.Null);
            Assert.That(model.VictoryPoints.Yesterday, Is.Not.Empty);
            Assert.That(model.VictoryPoints.LastWeek, Is.Not.Null);
            Assert.That(model.VictoryPoints.LastWeek, Is.Not.Empty);
            Assert.That(model.VictoryPoints.ActiveTotal.First().FactionId, Is.EqualTo(500001));
            Assert.That(model.VictoryPoints.ActiveTotal.First().Amount, Is.EqualTo(53130500));
            Assert.That(model.VictoryPoints.LastWeek.First().FactionId, Is.EqualTo(500001));
            Assert.That(model.VictoryPoints.LastWeek.First().Amount, Is.EqualTo(97360));
            Assert.That(model.VictoryPoints.Yesterday.First().FactionId, Is.EqualTo(500002));
            Assert.That(model.VictoryPoints.Yesterday.First().Amount, Is.EqualTo(5000));
        }

        [TestCaseSource(typeof(DeserializationTestCaseSourceProvider<Leaderboards<CharacterTotal>>), nameof(DeserializationTestCaseSourceProvider<Leaderboards<CharacterTotal>>.GetTestData), new object[] { FileName, "CharacterLeaderboards" })]
        public void Deserialization_FactionWarfare_CharacterLeaderboards(Leaderboards<CharacterTotal> model)
        {
            Assert.That(model, Is.Not.Null);
            Assert.That(model.Kills, Is.Not.Null);
            Assert.That(model.Kills.ActiveTotal, Is.Not.Null);
            Assert.That(model.Kills.ActiveTotal, Is.Not.Empty);
            Assert.That(model.Kills.Yesterday, Is.Not.Null);
            Assert.That(model.Kills.Yesterday, Is.Not.Empty);
            Assert.That(model.Kills.LastWeek, Is.Not.Null);
            Assert.That(model.Kills.LastWeek, Is.Not.Empty);
            Assert.That(model.Kills.ActiveTotal.First().CharacterId, Is.EqualTo(2112625428));
            Assert.That(model.Kills.ActiveTotal.First().Amount, Is.EqualTo(10000));
            Assert.That(model.Kills.LastWeek.First().CharacterId, Is.EqualTo(2112625428));
            Assert.That(model.Kills.LastWeek.First().Amount, Is.EqualTo(100));
            Assert.That(model.Kills.Yesterday.First().CharacterId, Is.EqualTo(2112625428));
            Assert.That(model.Kills.Yesterday.First().Amount, Is.EqualTo(34));
            Assert.That(model.VictoryPoints, Is.Not.Null);
            Assert.That(model.VictoryPoints.ActiveTotal, Is.Not.Null);
            Assert.That(model.VictoryPoints.ActiveTotal, Is.Not.Empty);
            Assert.That(model.VictoryPoints.Yesterday, Is.Not.Null);
            Assert.That(model.VictoryPoints.Yesterday, Is.Not.Empty);
            Assert.That(model.VictoryPoints.LastWeek, Is.Not.Null);
            Assert.That(model.VictoryPoints.LastWeek, Is.Not.Empty);
            Assert.That(model.VictoryPoints.ActiveTotal.First().CharacterId, Is.EqualTo(2112625428));
            Assert.That(model.VictoryPoints.ActiveTotal.First().Amount, Is.EqualTo(1239158));
            Assert.That(model.VictoryPoints.LastWeek.First().CharacterId, Is.EqualTo(2112625428));
            Assert.That(model.VictoryPoints.LastWeek.First().Amount, Is.EqualTo(2660));
            Assert.That(model.VictoryPoints.Yesterday.First().CharacterId, Is.EqualTo(2112625428));
            Assert.That(model.VictoryPoints.Yesterday.First().Amount, Is.EqualTo(620));
        }

        [TestCaseSource(typeof(DeserializationTestCaseSourceProvider<Leaderboards<CorporationTotal>>), nameof(DeserializationTestCaseSourceProvider<Leaderboards<CorporationTotal>>.GetTestData), new object[] { FileName, "CorporationLeaderboards" })]
        public void Deserialization_FactionWarfare_CorporationLeaderboards(Leaderboards<CorporationTotal> model)
        {
            Assert.That(model, Is.Not.Null);
            Assert.That(model.Kills, Is.Not.Null);
            Assert.That(model.Kills.ActiveTotal, Is.Not.Null);
            Assert.That(model.Kills.ActiveTotal, Is.Not.Empty);
            Assert.That(model.Kills.Yesterday, Is.Not.Null);
            Assert.That(model.Kills.Yesterday, Is.Not.Empty);
            Assert.That(model.Kills.LastWeek, Is.Not.Null);
            Assert.That(model.Kills.LastWeek, Is.Not.Empty);
            Assert.That(model.Kills.ActiveTotal.First().CorporationId, Is.EqualTo(1000180));
            Assert.That(model.Kills.ActiveTotal.First().Amount, Is.EqualTo(81692));
            Assert.That(model.Kills.LastWeek.First().CorporationId, Is.EqualTo(1000180));
            Assert.That(model.Kills.LastWeek.First().Amount, Is.EqualTo(290));
            Assert.That(model.Kills.Yesterday.First().CorporationId, Is.EqualTo(1000180));
            Assert.That(model.Kills.Yesterday.First().Amount, Is.EqualTo(51));
            Assert.That(model.VictoryPoints, Is.Not.Null);
            Assert.That(model.VictoryPoints.ActiveTotal, Is.Not.Null);
            Assert.That(model.VictoryPoints.ActiveTotal, Is.Not.Empty);
            Assert.That(model.VictoryPoints.Yesterday, Is.Not.Null);
            Assert.That(model.VictoryPoints.Yesterday, Is.Not.Empty);
            Assert.That(model.VictoryPoints.LastWeek, Is.Not.Null);
            Assert.That(model.VictoryPoints.LastWeek, Is.Not.Empty);
            Assert.That(model.VictoryPoints.ActiveTotal.First().CorporationId, Is.EqualTo(1000180));
            Assert.That(model.VictoryPoints.ActiveTotal.First().Amount, Is.EqualTo(18640927));
            Assert.That(model.VictoryPoints.LastWeek.First().CorporationId, Is.EqualTo(1000180));
            Assert.That(model.VictoryPoints.LastWeek.First().Amount, Is.EqualTo(91980));
            Assert.That(model.VictoryPoints.Yesterday.First().CorporationId, Is.EqualTo(1000180));
            Assert.That(model.VictoryPoints.Yesterday.First().Amount, Is.EqualTo(12600));
        }
    }
}
