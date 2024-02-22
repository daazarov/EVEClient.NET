using EVEOnline.ESI.Communication.DataContract;
using EVEOnline.ESI.Communication.UnitTests.Datasets.Providers;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVEOnline.ESI.Communication.UnitTests.DeserializationTests.Market
{
    [TestFixture]
    public class DeserializationTests
    {
        private const string FileName = "deserialization.market.json";
        private const string CustomSectionName = "";

        [TestCaseSource(typeof(DeserializationTestCaseSourceProvider<Price>), nameof(DeserializationTestCaseSourceProvider<Price>.GetTestData), new object[] { FileName, CustomSectionName })]
        public void Deserialization_Market_Price(Price model)
        {
            Assert.That(model, Is.Not.Null);
            Assert.That(model.AdjustedPrice, Is.EqualTo(306988.09d));
            Assert.That(model.AveragePrice, Is.EqualTo(306292.67d));
            Assert.That(model.TypeId, Is.EqualTo(32772));
        }

        [TestCaseSource(typeof(DeserializationTestCaseSourceProvider<Statistic>), nameof(DeserializationTestCaseSourceProvider<Statistic>.GetTestData), new object[] { FileName, CustomSectionName })]
        public void Deserialization_Market_Statistic(Statistic model)
        {
            Assert.That(model, Is.Not.Null);
            Assert.That(model.Average, Is.EqualTo(5.25d));
            Assert.That(model.Highest, Is.EqualTo(5.27d));
            Assert.That(model.Lowest, Is.EqualTo(5.11d));
            Assert.That(model.OrderCount, Is.EqualTo(2267));
            Assert.That(model.Volume, Is.EqualTo(16276782035));
            Assert.That(model.Date.Year, Is.EqualTo(2015));
        }

        [TestCaseSource(typeof(DeserializationTestCaseSourceProvider<MarketGroup>), nameof(DeserializationTestCaseSourceProvider<MarketGroup>.GetTestData), new object[] { FileName, CustomSectionName })]
        public void Deserialization_Market_MarketGroup(MarketGroup model)
        {
            Assert.That(model, Is.Not.Null);
            Assert.That(model.Description, Is.EqualTo("Small, fast vessels suited to a variety of purposes."));
            Assert.That(model.MarketGroupId, Is.EqualTo(5));
            Assert.That(model.Name, Is.EqualTo("Standard Frigates"));
            Assert.That(model.ParentGroupId, Is.EqualTo(1361));
            Assert.That(model.Types, Is.Not.Null);
            Assert.That(model.Types, Is.Not.Empty);
            Assert.That(model.Types.Count(), Is.EqualTo(2));
        }

        [TestCaseSource(typeof(DeserializationTestCaseSourceProvider<OrderBase>), nameof(DeserializationTestCaseSourceProvider<OrderBase>.GetTestData), new object[] { FileName, CustomSectionName })]
        public void Deserialization_Market_OrderBase(OrderBase model)
        {
            Assert.That(model, Is.Not.Null);
            Assert.That(model.Duration, Is.EqualTo(90));
            Assert.That(model.Escrow, Is.EqualTo(6516.641d));
            Assert.That(model.IsBuyOrder, Is.True);
            Assert.That(model.IsCorporation, Is.True);
            Assert.That(model.Issued.Year, Is.EqualTo(2016));
            Assert.That(model.IssuedBy, Is.EqualTo(5116111));
            Assert.That(model.LocationId, Is.EqualTo(60005599));
            Assert.That(model.MinVolume, Is.EqualTo(1));
            Assert.That(model.OrderId, Is.EqualTo(4623824223));
            Assert.That(model.Price, Is.EqualTo(9.9d));
            Assert.That(model.Range, Is.EqualTo(OrderRange.Region));
            Assert.That(model.OrderId, Is.EqualTo(4623824223));
            Assert.That(model.SystemId, Is.EqualTo(30000053));
            Assert.That(model.RegionId, Is.EqualTo(1000001));
            Assert.That(model.State, Is.EqualTo(OrderState.Cancelled));
            Assert.That(model.TypeId, Is.EqualTo(34));
            Assert.That(model.VolumeRemain, Is.EqualTo(1296000));
            Assert.That(model.VolumeTotal, Is.EqualTo(2000000));
            Assert.That(model.WalletDivision, Is.EqualTo(6));
        }
    }
}
