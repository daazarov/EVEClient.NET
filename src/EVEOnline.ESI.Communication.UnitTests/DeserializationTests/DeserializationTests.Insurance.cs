using EVEOnline.ESI.Communication.UnitTests.Datasets.Providers;
using NUnit.Framework;

namespace EVEOnline.ESI.Communication.UnitTests.DeserializationTests.Insurance
{
    [TestFixture]
    public class DeserializationTests
    {
        private const string FileName = "deserialization.insurance.json";
        private const string CustomSectionName = "";

        [TestCaseSource(typeof(DeserializationTestCaseSourceProvider<DataContract.Insurance>), nameof(DeserializationTestCaseSourceProvider<DataContract.Insurance>.GetTestData), new object[] { FileName, CustomSectionName })]
        public void Deserialization_Insurance_Insurance(DataContract.Insurance model)
        {
            Assert.That(model, Is.Not.Null);
            Assert.That(model.TypeId, Is.EqualTo(1));
            Assert.That(model.Levels, Is.Not.Empty);
            Assert.That(model.Levels.First().Name, Is.EqualTo("Basic"));
            Assert.That(model.Levels.First().Payout, Is.EqualTo(20.01f));
            Assert.That(model.Levels.First().Cost, Is.EqualTo(10.01f));
        }
    }
}
