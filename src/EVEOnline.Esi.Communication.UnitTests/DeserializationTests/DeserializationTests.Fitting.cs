using EVEOnline.Esi.Communication.DataContract;
using EVEOnline.Esi.Communication.UnitTests.Datasets.Providers;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVEOnline.Esi.Communication.UnitTests.DeserializationTests.Fitting
{
    [TestFixture]
    public class DeserializationTests
    {
        private const string FileName = "deserialization.fitting.json";
        private const string CustomSectionName = "";

        [TestCaseSource(typeof(DeserializationTestCaseSourceProvider<NewFittingResponse>), nameof(DeserializationTestCaseSourceProvider<NewFittingResponse>.GetTestData), new object[] { FileName, CustomSectionName })]
        public void Deserialization_Fittings_NewFittingResponse(NewFittingResponse model)
        {
            Assert.That(model, Is.Not.Null);
            Assert.That(model.FittingId, Is.EqualTo(2));
        }

        [TestCaseSource(typeof(DeserializationTestCaseSourceProvider<DataContract.Fitting>), nameof(DeserializationTestCaseSourceProvider<DataContract.Fitting>.GetTestData), new object[] { FileName, CustomSectionName })]
        public void Deserialization_Fittings_Fitting(DataContract.Fitting model)
        {
            Assert.That(model, Is.Not.Null);
            Assert.That(model.Items, Is.Not.Empty);
            Assert.That(model.Items.First().Flag, Is.EqualTo(FittingFlag.Cargo));
            Assert.That(model.Items.First().Quantity, Is.EqualTo(1));
            Assert.That(model.Items.First().TypeId, Is.EqualTo(1234));
            Assert.That(model.FittingId, Is.EqualTo(1));
            Assert.That(model.Description, Is.EqualTo("Awesome Vindi fitting"));
            Assert.That(model.Name, Is.EqualTo("Best Vindicator"));
            Assert.That(model.ShipTypeId, Is.EqualTo(123));
        }
    }
}
