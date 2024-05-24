using EVEClient.NET.DataContract;
using EVEClient.NET.UnitTests.Datasets.Providers;
using NUnit.Framework;

namespace EVEClient.NET.UnitTests.DeserializationTests.Industry
{
    [TestFixture]
    public class DeserializationTests
    {
        private const string FileName = "deserialization.industry.json";
        private const string CustomSectionName = "";

        [TestCaseSource(typeof(DeserializationTestCaseSourceProvider<CharacterIndustryJob>), nameof(DeserializationTestCaseSourceProvider<CharacterIndustryJob>.GetTestData), new object[] { FileName, CustomSectionName })]
        public void Deserialization_Industry_CharacterIndustryJob(CharacterIndustryJob model)
        {
            Assert.That(model, Is.Not.Null);
            Assert.That(model.ActivityId, Is.EqualTo(1));
            Assert.That(model.BlueprintId, Is.EqualTo(1015116533326));
            Assert.That(model.BlueprintLocationId, Is.EqualTo(60006382));
            Assert.That(model.BlueprintTypeId, Is.EqualTo(2047));
            Assert.That(model.Cost, Is.EqualTo(118.01d));
            Assert.That(model.Duration, Is.EqualTo(548));
            Assert.That(model.EndDate.Year, Is.EqualTo(2014));
            Assert.That(model.FacilityId, Is.EqualTo(60006382));
            Assert.That(model.InstallerId, Is.EqualTo(498338451));
            Assert.That(model.JobId, Is.EqualTo(229136101));
            Assert.That(model.LicensedRuns, Is.EqualTo(200));
            Assert.That(model.OutputLocationId, Is.EqualTo(60006382));
            Assert.That(model.Runs, Is.EqualTo(1));
            Assert.That(model.StartDate.Year, Is.EqualTo(2014));
            Assert.That(model.StationId, Is.EqualTo(60006382));
            Assert.That(model.Status, Is.EqualTo(JobStatus.Active));
            Assert.That(model.CompletedCharacterId, Is.EqualTo(6516145));
            Assert.That(model.CompletedDate.HasValue, Is.True);
            Assert.That(model.CompletedDate.Value.Year, Is.EqualTo(2015));
            Assert.That(model.PauseDate.HasValue, Is.True);
            Assert.That(model.PauseDate.Value.Year, Is.EqualTo(2014));
            Assert.That(model.Probability, Is.EqualTo(87.2f));
            Assert.That(model.ProductTypeId, Is.EqualTo(6161));
            Assert.That(model.SuccessfulRuns, Is.EqualTo(10));
        }

        [TestCaseSource(typeof(DeserializationTestCaseSourceProvider<CorporationIndustryJob>), nameof(DeserializationTestCaseSourceProvider<CorporationIndustryJob>.GetTestData), new object[] { FileName, CustomSectionName })]
        public void Deserialization_Industry_CorporationIndustryJob(CorporationIndustryJob model)
        {
            Assert.That(model, Is.Not.Null);
            Assert.That(model.ActivityId, Is.EqualTo(1));
            Assert.That(model.BlueprintId, Is.EqualTo(1015116533326));
            Assert.That(model.BlueprintLocationId, Is.EqualTo(60006382));
            Assert.That(model.BlueprintTypeId, Is.EqualTo(2047));
            Assert.That(model.Cost, Is.EqualTo(118.01d));
            Assert.That(model.Duration, Is.EqualTo(548));
            Assert.That(model.EndDate.Year, Is.EqualTo(2014));
            Assert.That(model.FacilityId, Is.EqualTo(60006382));
            Assert.That(model.InstallerId, Is.EqualTo(498338451));
            Assert.That(model.JobId, Is.EqualTo(229136101));
            Assert.That(model.LicensedRuns, Is.EqualTo(200));
            Assert.That(model.OutputLocationId, Is.EqualTo(60006382));
            Assert.That(model.Runs, Is.EqualTo(1));
            Assert.That(model.StartDate.Year, Is.EqualTo(2014));
            Assert.That(model.LocationId, Is.EqualTo(60006382));
            Assert.That(model.Status, Is.EqualTo(JobStatus.Active));
            Assert.That(model.CompletedCharacterId, Is.EqualTo(6516145));
            Assert.That(model.CompletedDate.HasValue, Is.True);
            Assert.That(model.CompletedDate.Value.Year, Is.EqualTo(2015));
            Assert.That(model.PauseDate.HasValue, Is.True);
            Assert.That(model.PauseDate.Value.Year, Is.EqualTo(2014));
            Assert.That(model.Probability, Is.EqualTo(87.2f));
            Assert.That(model.ProductTypeId, Is.EqualTo(6161));
            Assert.That(model.SuccessfulRuns, Is.EqualTo(10));
        }

        [TestCaseSource(typeof(DeserializationTestCaseSourceProvider<Mining>), nameof(DeserializationTestCaseSourceProvider<Mining>.GetTestData), new object[] { FileName, CustomSectionName })]
        public void Deserialization_Industry_Mining(Mining model)
        {
            Assert.That(model, Is.Not.Null);
            Assert.That(model.Date.Year, Is.EqualTo(2017));
            Assert.That(model.Quantity, Is.EqualTo(7004));
            Assert.That(model.SolarSystemId, Is.EqualTo(30003707));
            Assert.That(model.TypeId, Is.EqualTo(17471));
        }

        [TestCaseSource(typeof(DeserializationTestCaseSourceProvider<Extraction>), nameof(DeserializationTestCaseSourceProvider<Extraction>.GetTestData), new object[] { FileName, CustomSectionName })]
        public void Deserialization_Industry_Extraction(Extraction model)
        {
            Assert.That(model, Is.Not.Null);
            Assert.That(model.MoonId, Is.EqualTo(40307229));
            Assert.That(model.StructureId, Is.EqualTo(1000000010579));
            Assert.That(model.ChunkArrivalTime.Year, Is.EqualTo(2017));
            Assert.That(model.ExtractionStartTime.Year, Is.EqualTo(2018));
            Assert.That(model.NaturalDecayTime.Year, Is.EqualTo(2019));
        }

        [TestCaseSource(typeof(DeserializationTestCaseSourceProvider<Observer>), nameof(DeserializationTestCaseSourceProvider<Observer>.GetTestData), new object[] { FileName, CustomSectionName })]
        public void Deserialization_Industry_Observer(Observer model)
        {
            Assert.That(model, Is.Not.Null);
            Assert.That(model.LastUpdated.Year, Is.EqualTo(2017));
            Assert.That(model.ObserverType, Is.EqualTo("structure"));
            Assert.That(model.ObserverId, Is.EqualTo(1));
        }

        [TestCaseSource(typeof(DeserializationTestCaseSourceProvider<ObserverInfo>), nameof(DeserializationTestCaseSourceProvider<ObserverInfo>.GetTestData), new object[] { FileName, CustomSectionName })]
        public void Deserialization_Industry_ObserverInfo(ObserverInfo model)
        {
            Assert.That(model, Is.Not.Null);
            Assert.That(model.LastUpdated.Year, Is.EqualTo(2017));
            Assert.That(model.CharacterId, Is.EqualTo(95465499));
            Assert.That(model.Quantity, Is.EqualTo(500));
            Assert.That(model.RecordedCorporationId, Is.EqualTo(109299958));
            Assert.That(model.TypeId, Is.EqualTo(1230));
        }


        [TestCaseSource(typeof(DeserializationTestCaseSourceProvider<IndustryFacility>), nameof(DeserializationTestCaseSourceProvider<IndustryFacility>.GetTestData), new object[] { FileName, CustomSectionName })]
        public void Deserialization_Industry_IndustryFacility(IndustryFacility model)
        {
            Assert.That(model, Is.Not.Null);
            Assert.That(model.FacilityId, Is.EqualTo(60012544));
            Assert.That(model.OwnerId, Is.EqualTo(1000126));
            Assert.That(model.RegionId, Is.EqualTo(10000001));
            Assert.That(model.SolarSystemId, Is.EqualTo(30000032));
            Assert.That(model.Tax, Is.EqualTo(0.1f));
            Assert.That(model.TypeId, Is.EqualTo(2502));
        }

        [TestCaseSource(typeof(DeserializationTestCaseSourceProvider<SolarSystem>), nameof(DeserializationTestCaseSourceProvider<SolarSystem>.GetTestData), new object[] { FileName, CustomSectionName })]
        public void Deserialization_Industry_SolarSystem(SolarSystem model)
        {
            Assert.That(model, Is.Not.Null);
            Assert.That(model.SolarSystemId, Is.EqualTo(30011392));
            Assert.That(model.CostIndices, Is.Not.Empty);
            Assert.That(model.CostIndices.First().CostIndex, Is.EqualTo(0.0048f));
            Assert.That(model.CostIndices.First().Activity, Is.EqualTo(SolarSystemActivity.Invention));
        }
    }
}
