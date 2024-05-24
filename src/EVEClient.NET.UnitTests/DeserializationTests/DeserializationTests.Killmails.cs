using EVEClient.NET.DataContract;
using EVEClient.NET.UnitTests.Datasets.Providers;
using NUnit.Framework;

namespace EVEClient.NET.UnitTests.DeserializationTests.Killmails
{
    [TestFixture]
    public class DeserializationTests
    {
        private const string FileName = "deserialization.killmails.json";
        private const string CustomSectionName = "";

        [TestCaseSource(typeof(DeserializationTestCaseSourceProvider<Killmail>), nameof(DeserializationTestCaseSourceProvider<Killmail>.GetTestData), new object[] { FileName, CustomSectionName })]
        public void Deserialization_Killmails_Killmail(Killmail model)
        {
            Assert.That(model, Is.Not.Null);
            Assert.That(model.Id, Is.EqualTo(2));
            Assert.That(model.Hash, Is.EqualTo("8eef5e8fb6b88fe3407c489df33822b2e3b57a5e"));
        }

        [TestCaseSource(typeof(DeserializationTestCaseSourceProvider<KillmailInfo>), nameof(DeserializationTestCaseSourceProvider<KillmailInfo>.GetTestData), new object[] { FileName, CustomSectionName })]
        public void Deserialization_Killmails_KillmailInfo(KillmailInfo model)
        {
            Assert.That(model, Is.Not.Null);
            Assert.That(model.KillmailId, Is.EqualTo(56733821));
            Assert.That(model.SolarSystemId, Is.EqualTo(30002976));
            Assert.That(model.MoonId, Is.EqualTo(145424));
            Assert.That(model.WarId, Is.EqualTo(785412));
            Assert.That(model.KillmailTime.Year, Is.EqualTo(2016));

            Assert.That(model.Attackers, Is.Not.Empty);
            Assert.That(model.Attackers.First().CharacterId, Is.EqualTo(95810944));
            Assert.That(model.Attackers.First().CorporationId, Is.EqualTo(1000179));
            Assert.That(model.Attackers.First().AllianceId, Is.EqualTo(65165161));
            Assert.That(model.Attackers.First().DamageDone, Is.EqualTo(5745));
            Assert.That(model.Attackers.First().FactionId, Is.EqualTo(500003));
            Assert.That(model.Attackers.First().FinalBlow, Is.True);
            Assert.That(model.Attackers.First().SecurityStatus, Is.EqualTo(-0.3f));
            Assert.That(model.Attackers.First().ShipTypeId, Is.EqualTo(17841));
            Assert.That(model.Attackers.First().WeaponTypeId, Is.EqualTo(3074));

            Assert.That(model.Victim, Is.Not.Null);
            Assert.That(model.Victim.AllianceId, Is.EqualTo(621338554));
            Assert.That(model.Victim.CharacterId, Is.EqualTo(92796241));
            Assert.That(model.Victim.CorporationId, Is.EqualTo(841363671));
            Assert.That(model.Victim.DamageTaken, Is.EqualTo(5745));
            Assert.That(model.Victim.FactionId, Is.EqualTo(7485963));
            Assert.That(model.Victim.ShipTypeId, Is.EqualTo(17812));

            Assert.That(model.Victim.Position, Is.Not.Null);
            Assert.That(model.Victim.Position.X, Is.EqualTo(452186600569.4748d));
            Assert.That(model.Victim.Position.Y, Is.EqualTo(146704961490.90222d));
            Assert.That(model.Victim.Position.Z, Is.EqualTo(109514596532.54477d));

            Assert.That(model.Victim.Items, Is.Not.Null);
            Assert.That(model.Victim.Items, Is.Not.Empty);
            Assert.That(model.Victim.Items.First().Flag, Is.EqualTo(20));
            Assert.That(model.Victim.Items.First().ItemTypeId, Is.EqualTo(5973));
            Assert.That(model.Victim.Items.First().QuantityDestroyed, Is.EqualTo(9265261547));
            Assert.That(model.Victim.Items.First().QuantityDropped, Is.EqualTo(1));
            Assert.That(model.Victim.Items.First().Singleton, Is.EqualTo(0));

            Assert.That(model.Victim.Items.First().Items, Is.Not.Null);
            Assert.That(model.Victim.Items.First().Items, Is.Not.Empty);
            Assert.That(model.Victim.Items.First().Items.First().Flag, Is.EqualTo(21));
            Assert.That(model.Victim.Items.First().Items.First().ItemTypeId, Is.EqualTo(5975));
            Assert.That(model.Victim.Items.First().Items.First().QuantityDestroyed, Is.EqualTo(9265261548));
            Assert.That(model.Victim.Items.First().Items.First().QuantityDropped, Is.EqualTo(10));
            Assert.That(model.Victim.Items.First().Items.First().Singleton, Is.EqualTo(1));
        }
    }
}
