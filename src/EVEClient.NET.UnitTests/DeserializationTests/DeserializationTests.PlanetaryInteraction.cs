using EVEClient.NET.DataContract;
using EVEClient.NET.UnitTests.Datasets.Providers;
using NUnit.Framework;

namespace EVEClient.NET.UnitTests.DeserializationTests.PlanetaryInteraction
{
    [TestFixture]
    public class DeserializationTests
    {
        private const string FileName = "deserialization.planetaryinteraction.json";
        private const string CustomSectionName = "";

        [TestCaseSource(typeof(DeserializationTestCaseSourceProvider<Colony>), nameof(DeserializationTestCaseSourceProvider<Colony>.GetTestData), new object[] { FileName, CustomSectionName })]
        public void Deserialization_PlanetaryInteraction_Colony(Colony model)
        {
            Assert.That(model, Is.Not.Null);
            Assert.That(model.NumberOfPins, Is.EqualTo(1));
            Assert.That(model.OwnerId, Is.EqualTo(90000001));
            Assert.That(model.PlanetId, Is.EqualTo(40023691));
            Assert.That(model.PlanetType, Is.EqualTo(PlanetType.Plasma));
            Assert.That(model.SolarSystemId, Is.EqualTo(30000379));
            Assert.That(model.UpgradeLevel, Is.EqualTo(1));
            Assert.That(model.LastUpdate.Year, Is.EqualTo(2016));
        }

        [TestCaseSource(typeof(DeserializationTestCaseSourceProvider<SchematicInfo>), nameof(DeserializationTestCaseSourceProvider<SchematicInfo>.GetTestData), new object[] { FileName, CustomSectionName })]
        public void Deserialization_PlanetaryInteraction_SchematicInfo(SchematicInfo model)
        {
            Assert.That(model, Is.Not.Null);
            Assert.That(model.CycleTime, Is.EqualTo(1800));
            Assert.That(model.Name, Is.EqualTo("Bacteria"));
        }

        [TestCaseSource(typeof(DeserializationTestCaseSourceProvider<CustomOffice>), nameof(DeserializationTestCaseSourceProvider<CustomOffice>.GetTestData), new object[] { FileName, CustomSectionName })]
        public void Deserialization_PlanetaryInteraction_CustomOffice(CustomOffice model)
        {
            Assert.That(model, Is.Not.Null);
            Assert.That(model.AllianceTaxRate, Is.EqualTo(0.1f));
            Assert.That(model.AllowAccessWithStandings, Is.True);
            Assert.That(model.AllowAllianceAccess, Is.True);
            Assert.That(model.BadStandingTaxRate, Is.EqualTo(0.2f));
            Assert.That(model.CorporationTaxRate, Is.EqualTo(0.02f));
            Assert.That(model.ExcellentStandingTaxRate, Is.EqualTo(0.05f));
            Assert.That(model.GoodStandingTaxRate, Is.EqualTo(0.2f));
            Assert.That(model.NeutralStandingTaxRate, Is.EqualTo(0.5f));
            Assert.That(model.OfficeId, Is.EqualTo(1000000014530));
            Assert.That(model.ReinforceExitEnd, Is.EqualTo(1));
            Assert.That(model.ReinforceExitStart, Is.EqualTo(23));
            Assert.That(model.StandingLevel, Is.EqualTo(StandingLevel.Neutral));
            Assert.That(model.SystemId, Is.EqualTo(30003657));
            Assert.That(model.TerribleStandingTaxRate, Is.EqualTo(0.4f));
        }

        [TestCaseSource(typeof(DeserializationTestCaseSourceProvider<ColonyLayout>), nameof(DeserializationTestCaseSourceProvider<ColonyLayout>.GetTestData), new object[] { FileName, CustomSectionName })]
        public void Deserialization_PlanetaryInteraction_ColonyLayout(ColonyLayout model)
        {
            Assert.That(model, Is.Not.Null);

            Assert.That(model.Routes, Is.Not.Null);
            Assert.That(model.Pins, Is.Not.Null);
            Assert.That(model.Links, Is.Not.Null);

            Assert.That(model.Routes, Is.Not.Empty);
            Assert.That(model.Pins, Is.Not.Empty);
            Assert.That(model.Links, Is.Not.Empty);

            Assert.That(model.Links.First().LinkLevel, Is.EqualTo(1));
            Assert.That(model.Links.First().DestinationPinId, Is.EqualTo(1000000017022));
            Assert.That(model.Links.First().SourcePinId, Is.EqualTo(1000000017021));

            Assert.That(model.Routes.First().Quantity, Is.EqualTo(20));
            Assert.That(model.Routes.First().DestinationPinId, Is.EqualTo(1000000017030));
            Assert.That(model.Routes.First().ContentTypeId, Is.EqualTo(2393));
            Assert.That(model.Routes.First().RouteId, Is.EqualTo(4));
            Assert.That(model.Routes.First().SourcePinId, Is.EqualTo(1000000017029));
            Assert.That(model.Routes.First().Waypoints, Is.Not.Null);
            Assert.That(model.Routes.First().Waypoints, Has.Exactly(1).EqualTo(6));

            Assert.That(model.Pins.First().Latitude, Is.EqualTo(1.55087844973f));
            Assert.That(model.Pins.First().Longitude, Is.EqualTo(0.717145933308f));
            Assert.That(model.Pins.First().PinId, Is.EqualTo(1000000017021));
            Assert.That(model.Pins.First().SchematicId, Is.EqualTo(7851469));
            Assert.That(model.Pins.First().TypeId, Is.EqualTo(2254));
            Assert.That(model.Pins.First().ExpirationTime!.Value.Year, Is.EqualTo(2016));
            Assert.That(model.Pins.First().InstallTime!.Value.Year, Is.EqualTo(2015));
            Assert.That(model.Pins.First().LastCycleStart!.Value.Year, Is.EqualTo(2017));

            Assert.That(model.Pins.First().FactoryDetails, Is.Not.Null);
            Assert.That(model.Pins.First().FactoryDetails.SchematicId, Is.EqualTo(7852463));

            Assert.That(model.Pins.First().Contents, Is.Not.Null);
            Assert.That(model.Pins.First().Contents, Is.Not.Empty);
            Assert.That(model.Pins.First().Contents.First().Amount, Is.EqualTo(516651965));
            Assert.That(model.Pins.First().Contents.First().TypeId, Is.EqualTo(2458));

            Assert.That(model.Pins.First().ExtractorDetails, Is.Not.Null);
            Assert.That(model.Pins.First().ExtractorDetails.HeadRadius, Is.EqualTo(21.5f));
            Assert.That(model.Pins.First().ExtractorDetails.QuantityPerCycle, Is.EqualTo(789654));
            Assert.That(model.Pins.First().ExtractorDetails.CycleTime, Is.EqualTo(7852));
            Assert.That(model.Pins.First().ExtractorDetails.ProductTypeId, Is.EqualTo(3587));

            Assert.That(model.Pins.First().ExtractorDetails.Heads, Is.Not.Null);
            Assert.That(model.Pins.First().ExtractorDetails.Heads, Is.Not.Empty);
            Assert.That(model.Pins.First().ExtractorDetails.Heads.First().Latitude, Is.EqualTo(3.5f));
            Assert.That(model.Pins.First().ExtractorDetails.Heads.First().Longitude, Is.EqualTo(1.1f));
            Assert.That(model.Pins.First().ExtractorDetails.Heads.First().HeadId, Is.EqualTo(7));
        }
    }
}
