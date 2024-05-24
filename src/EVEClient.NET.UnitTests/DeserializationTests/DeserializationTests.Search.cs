using EVEClient.NET.DataContract;
using EVEClient.NET.UnitTests.Datasets.Providers;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVEClient.NET.UnitTests.DeserializationTests.Search
{
    [TestFixture]
    public class DeserializationTests
    {
        private const string FileName = "deserialization.search.json";
        private const string CustomSectionName = "";

        [TestCaseSource(typeof(DeserializationTestCaseSourceProvider<SearchResult>), nameof(DeserializationTestCaseSourceProvider<SearchResult>.GetTestData), new object[] { FileName, CustomSectionName })]
        public void Deserialization_Search_SearchResult(SearchResult model)
        {
            Assert.That(model, Is.Not.Null);
            Assert.That(model.Regions, Is.Not.Null);
            Assert.That(model.Regions, Is.Not.Empty);

            Assert.That(model.SolarSystems, Is.Not.Null);
            Assert.That(model.SolarSystems, Is.Not.Empty);

            Assert.That(model.Stations, Is.Not.Null);
            Assert.That(model.Stations, Is.Not.Empty);

            Assert.That(model.Agents, Is.Not.Null);
            Assert.That(model.Agents, Is.Not.Empty);

            Assert.That(model.Alliances, Is.Not.Null);
            Assert.That(model.Alliances, Is.Not.Empty);

            Assert.That(model.Characters, Is.Not.Null);
            Assert.That(model.Characters, Is.Not.Empty);

            Assert.That(model.Constellations, Is.Not.Null);
            Assert.That(model.Constellations, Is.Not.Empty);

            Assert.That(model.Corporations, Is.Not.Null);
            Assert.That(model.Corporations, Is.Not.Empty);

            Assert.That(model.Factions, Is.Not.Null);
            Assert.That(model.Factions, Is.Not.Empty);

            Assert.That(model.InventoryTypes, Is.Not.Null);
            Assert.That(model.InventoryTypes, Is.Not.Empty);

            Assert.That(model.Structures, Is.Not.Null);
            Assert.That(model.Structures, Is.Not.Empty);
        }
    }
}
