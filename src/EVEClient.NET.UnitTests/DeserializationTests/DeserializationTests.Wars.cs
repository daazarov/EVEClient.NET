using EVEClient.NET.DataContract;
using EVEClient.NET.UnitTests.Datasets.Providers;
using NUnit.Framework;

namespace EVEClient.NET.UnitTests.DeserializationTests.Wars
{
    [TestFixture]
    public class DeserializationTests
    {
        private const string FileName = "deserialization.wars.json";
        private const string CustomSectionName = "";

        [TestCaseSource(typeof(DeserializationTestCaseSourceProvider<War>), nameof(DeserializationTestCaseSourceProvider<War>.GetTestData), new object[] { FileName, CustomSectionName })]
        public void Deserialization_Wars_War(War model)
        {
            Assert.That(model, Is.Not.Null);
            Assert.That(model.Aggressor.AllianceId, Is.EqualTo(514777854));
            Assert.That(model.Aggressor.CorporationId, Is.EqualTo(986665792));
            Assert.That(model.Aggressor.IskDestroyed, Is.EqualTo(1000));
            Assert.That(model.Aggressor.ShipsKilled, Is.EqualTo(2000));
            Assert.That(model.Allies.First().AllianceId, Is.EqualTo(6516566));
            Assert.That(model.Allies.First().CorporationId, Is.EqualTo(6985214));
            Assert.That(model.Declared.Year, Is.EqualTo(2004));
            Assert.That(model.Defender, Is.Not.Null);
            Assert.That(model.Finished.Value.Year, Is.EqualTo(2005));
            Assert.That(model.ID, Is.EqualTo(1941));
            Assert.That(model.Mutual, Is.True);
            Assert.That(model.OpenForAllies, Is.True);
            Assert.That(model.Retracted.Value.Year, Is.EqualTo(2006));
            Assert.That(model.Started.Value.Year, Is.EqualTo(2007));
        }

        [TestCaseSource(typeof(DeserializationTestCaseSourceProvider<Kill>), nameof(DeserializationTestCaseSourceProvider<Kill>.GetTestData), new object[] { FileName, CustomSectionName })]
        public void Deserialization_Wars_Kill(Kill model)
        {
            Assert.That(model, Is.Not.Null);
            Assert.That(model.KillmailHash, Is.EqualTo("8eef5e8fb6b88fe3407c489df33822b2e3b57a5e"));
            Assert.That(model.KillmailId, Is.EqualTo(2));
        }
    }
}
