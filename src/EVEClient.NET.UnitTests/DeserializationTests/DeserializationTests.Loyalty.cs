using EVEClient.NET.DataContract;
using EVEClient.NET.UnitTests.Datasets.Providers;
using NUnit.Framework;

namespace EVEClient.NET.UnitTests.DeserializationTests.Loyalty
{
    [TestFixture]
    public class DeserializationTests
    {
        private const string FileName = "deserialization.loyalty.json";
        private const string CustomSectionName = "";

        [TestCaseSource(typeof(DeserializationTestCaseSourceProvider<Points>), nameof(DeserializationTestCaseSourceProvider<Points>.GetTestData), new object[] { FileName, CustomSectionName })]
        public void Deserialization_Loyalty_Points(Points model)
        {
            Assert.That(model, Is.Not.Null);
            Assert.That(model.CorporationId, Is.EqualTo(123));
            Assert.That(model.LoyaltyPoints, Is.EqualTo(100));
        }

        [TestCaseSource(typeof(DeserializationTestCaseSourceProvider<Offer>), nameof(DeserializationTestCaseSourceProvider<Offer>.GetTestData), new object[] { FileName, CustomSectionName })]
        public void Deserialization_Loyalty_Offer(Offer model)
        {
            Assert.That(model, Is.Not.Null);
            Assert.That(model.AkCost, Is.EqualTo(35000));
            Assert.That(model.IskCost, Is.EqualTo(10));
            Assert.That(model.LpCost, Is.EqualTo(100));
            Assert.That(model.OfferId, Is.EqualTo(1));
            Assert.That(model.Quantity, Is.EqualTo(2));
            Assert.That(model.TypeId, Is.EqualTo(123));

            Assert.That(model.RequiredItems, Is.Not.Empty);
            Assert.That(model.RequiredItems.First().TypeId, Is.EqualTo(1234));
            Assert.That(model.RequiredItems.First().Quantity, Is.EqualTo(10));
        }
    }
}
