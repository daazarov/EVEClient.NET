using EVEClient.NET.DataContract;
using EVEClient.NET.UnitTests.Datasets.Providers;
using NUnit.Framework;

namespace EVEClient.NET.UnitTests.DeserializationTests.Incursions
{
    [TestFixture]
    public class DeserializationTests
    {
        private const string FileName = "deserialization.incursions.json";
        private const string CustomSectionName = "";

        [TestCaseSource(typeof(DeserializationTestCaseSourceProvider<Incursion>), nameof(DeserializationTestCaseSourceProvider<Incursion>.GetTestData), new object[] { FileName, CustomSectionName })]
        public void Deserialization_Incursions_Incursion(Incursion model)
        {
            Assert.That(model, Is.Not.Null);
            Assert.That(model.ConstellationId, Is.EqualTo(20000607));
            Assert.That(model.FactionId, Is.EqualTo(500019));
            Assert.That(model.HasBoss, Is.True);
            Assert.That(model.Influence, Is.EqualTo(0.9f));
            Assert.That(model.StagingSolarSystemId, Is.EqualTo(30004154));
            Assert.That(model.State, Is.EqualTo(IncursionState.Mobilizing));
            Assert.That(model.Type, Is.EqualTo("Incursion"));
            Assert.That(model.InfestedSolarSystems, Is.Not.Empty);
            Assert.That(model.InfestedSolarSystems, Has.Member(30004152));
        }
    }
}
