using EVEClient.NET.DataContract;
using EVEClient.NET.UnitTests.Datasets.Providers;
using NUnit.Framework;

namespace EVEClient.NET.UnitTests.DeserializationTests.Universr
{
    [TestFixture]
    public class DeserializationTests
    {
        private const string FileName = "deserialization.universe.json";
        private const string CustomSectionName = "";

        [TestCaseSource(typeof(DeserializationTestCaseSourceProvider<Ancestry>), nameof(DeserializationTestCaseSourceProvider<Ancestry>.GetTestData), new object[] { FileName, CustomSectionName })]
        public void Deserialization_Universe_Ancestry(Ancestry model)
        {
            Assert.That(model, Is.Not.Null);
            Assert.That(model.BloodlineId, Is.EqualTo(1));
            Assert.That(model.Description, Is.EqualTo("Acutely aware of the small population..."));
            Assert.That(model.Id, Is.EqualTo(12));
            Assert.That(model.IconId, Is.EqualTo(5));
            Assert.That(model.Name, Is.EqualTo("Tube Child"));
            Assert.That(model.ShortDescription, Is.EqualTo("Manufactured citizens of the State."));
        }

        [TestCaseSource(typeof(DeserializationTestCaseSourceProvider<AsteroidBelt>), nameof(DeserializationTestCaseSourceProvider<AsteroidBelt>.GetTestData), new object[] { FileName, CustomSectionName })]
        public void Deserialization_Universe_AsteroidBelt(AsteroidBelt model)
        {
            Assert.That(model, Is.Not.Null);
            Assert.That(model.Name, Is.EqualTo("Tanoo I - Asteroid Belt 1"));
            Assert.That(model.SystemId, Is.EqualTo(30000001));
            Assert.That(model.Position, Is.Not.Null);
            Assert.That(model.Position.X, Is.EqualTo(161967513600));
            Assert.That(model.Position.Y, Is.EqualTo(21288837120));
            Assert.That(model.Position.Z, Is.EqualTo(-73505464320));
        }

        [TestCaseSource(typeof(DeserializationTestCaseSourceProvider<Bloodline>), nameof(DeserializationTestCaseSourceProvider<Bloodline>.GetTestData), new object[] { FileName, CustomSectionName })]
        public void Deserialization_Universe_Bloodline(Bloodline model)
        {
            Assert.That(model, Is.Not.Null);
            Assert.That(model.BloodlineId, Is.EqualTo(1));
            Assert.That(model.Charisma, Is.EqualTo(6));
            Assert.That(model.CorporationId, Is.EqualTo(1000006));
            Assert.That(model.Description, Is.EqualTo("The Deteis are regarded as ..."));
            Assert.That(model.Intelligence, Is.EqualTo(7));
            Assert.That(model.Memory, Is.EqualTo(8));
            Assert.That(model.Name, Is.EqualTo("Deteis"));
            Assert.That(model.Perception, Is.EqualTo(5));
            Assert.That(model.RaceId, Is.EqualTo(1));
            Assert.That(model.ShipTypeId, Is.EqualTo(601));
            Assert.That(model.Willpower, Is.EqualTo(5));
        }

        [TestCaseSource(typeof(DeserializationTestCaseSourceProvider<Constellation>), nameof(DeserializationTestCaseSourceProvider<Constellation>.GetTestData), new object[] { FileName, CustomSectionName })]
        public void Deserialization_Universe_Constellation(Constellation model)
        {
            Assert.That(model, Is.Not.Null);
            Assert.That(model.ConstellationId, Is.EqualTo(20000009));
            Assert.That(model.Name, Is.EqualTo("Mekashtad"));
            Assert.That(model.Position, Is.Not.Null);
            Assert.That(model.RegionId, Is.EqualTo(10000001));
            Assert.That(model.Systems, Is.Not.Null);
            Assert.That(model.Systems, Is.Not.Empty);
            Assert.That(model.Systems, Has.Member(20000303));
        }

        [TestCaseSource(typeof(DeserializationTestCaseSourceProvider<EveType>), nameof(DeserializationTestCaseSourceProvider<EveType>.GetTestData), new object[] { FileName, CustomSectionName })]
        public void Deserialization_Universe_EveType(EveType model)
        {
            Assert.That(model, Is.Not.Null);
            Assert.That(model.Description, Is.EqualTo("The Rifter is a..."));
            Assert.That(model.GroupId, Is.EqualTo(25));
            Assert.That(model.Name, Is.EqualTo("Rifter"));
            Assert.That(model.Published, Is.True);
            Assert.That(model.TypeId, Is.EqualTo(587));
            Assert.That(model.Capacity, Is.EqualTo(651.848f));
            Assert.That(model.GraphicId, Is.EqualTo(145879));
            Assert.That(model.IconId, Is.EqualTo(9654));
            Assert.That(model.MarketGroupId, Is.EqualTo(689658));
            Assert.That(model.Mass, Is.EqualTo(4589.2647f));
            Assert.That(model.PackagedVolume, Is.EqualTo(54963.02154f));
            Assert.That(model.PortionSize, Is.EqualTo(52));
            Assert.That(model.Radius, Is.EqualTo(85470121.316f));
            Assert.That(model.Volume, Is.EqualTo(9658.3256f));
            Assert.That(model.DogmaAttributes, Is.Not.Null);
            Assert.That(model.DogmaAttributes, Is.Not.Empty);
            Assert.That(model.DogmaEffects, Is.Not.Null);
            Assert.That(model.DogmaEffects, Is.Not.Empty);
            Assert.That(model.DogmaAttributes.First().Value, Is.EqualTo(414.65f));
            Assert.That(model.DogmaAttributes.First().AttributeId, Is.EqualTo(65151651));
            Assert.That(model.DogmaEffects.First().EffectId, Is.EqualTo(65165877));
            Assert.That(model.DogmaEffects.First().IsDefault, Is.True);
        }

        [TestCaseSource(typeof(DeserializationTestCaseSourceProvider<Faction>), nameof(DeserializationTestCaseSourceProvider<Faction>.GetTestData), new object[] { FileName, CustomSectionName })]
        public void Deserialization_Universe_Faction(Faction model)
        {
            Assert.That(model, Is.Not.Null);
            Assert.That(model.CorporationId, Is.EqualTo(456));
            Assert.That(model.Description, Is.EqualTo("blah blah"));
            Assert.That(model.IsUnique, Is.True);
            Assert.That(model.FactionId, Is.EqualTo(1));
            Assert.That(model.Name, Is.EqualTo("Faction"));
            Assert.That(model.SizeFactor, Is.EqualTo(1));
            Assert.That(model.SolarSystemId, Is.EqualTo(123));
            Assert.That(model.StationCount, Is.EqualTo(1000));
            Assert.That(model.StationSystemCount, Is.EqualTo(100));
            Assert.That(model.MilitiaCorporationId, Is.EqualTo(85931144));
        }

        [TestCaseSource(typeof(DeserializationTestCaseSourceProvider<Graphic>), nameof(DeserializationTestCaseSourceProvider<Graphic>.GetTestData), new object[] { FileName, CustomSectionName })]
        public void Deserialization_Universe_Graphic(Graphic model)
        {
            Assert.That(model, Is.Not.Null);
            Assert.That(model.GraphicFile, Is.EqualTo("res:/dx9/model/worldobject/planet/moon.red"));
            Assert.That(model.CollisionFile, Is.EqualTo("res:/dx8/model/worldobject/planet/moon.red"));
            Assert.That(model.IconFolder, Is.EqualTo("test/test/test"));
            Assert.That(model.SofDna, Is.EqualTo("sof_dna"));
            Assert.That(model.SofFationName, Is.EqualTo("sof_fation_name"));
            Assert.That(model.SofHullName, Is.EqualTo("sof_hull_name"));
            Assert.That(model.SofRaceName, Is.EqualTo("sof_race_name"));
            Assert.That(model.GraphicId, Is.EqualTo(10));
        }

        [TestCaseSource(typeof(DeserializationTestCaseSourceProvider<IDsLookup>), nameof(DeserializationTestCaseSourceProvider<IDsLookup>.GetTestData), new object[] { FileName, CustomSectionName })]
        public void Deserialization_Universe_IDsLookup(IDsLookup model)
        {
            Assert.That(model, Is.Not.Null);
            Assert.That(model.Characters, Is.Not.Null);
            Assert.That(model.Characters, Is.Not.Empty);
            Assert.That(model.Characters.First().Name, Is.EqualTo("CCP Bartender"));
            Assert.That(model.Characters.First().ID, Is.EqualTo(95465499));
            Assert.That(model.Stations, Is.Not.Null);
            Assert.That(model.Stations, Is.Not.Empty);
            Assert.That(model.Regions, Is.Not.Null);
            Assert.That(model.Regions, Is.Not.Empty);
            Assert.That(model.Alliances, Is.Not.Null);
            Assert.That(model.Alliances, Is.Not.Empty);
            Assert.That(model.Agents, Is.Not.Null);
            Assert.That(model.Agents, Is.Not.Empty);
            Assert.That(model.Systems, Is.Not.Null);
            Assert.That(model.Systems, Is.Not.Empty);
            Assert.That(model.InventoryTypes, Is.Not.Null);
            Assert.That(model.InventoryTypes, Is.Not.Empty);
            Assert.That(model.Constellations, Is.Not.Null);
            Assert.That(model.Constellations, Is.Not.Empty);
            Assert.That(model.Corporations, Is.Not.Null);
            Assert.That(model.Corporations, Is.Not.Empty);
            Assert.That(model.Factions, Is.Not.Null);
            Assert.That(model.Factions, Is.Not.Empty);
        }

        [TestCaseSource(typeof(DeserializationTestCaseSourceProvider<ItemCategory>), nameof(DeserializationTestCaseSourceProvider<ItemCategory>.GetTestData), new object[] { FileName, CustomSectionName })]
        public void Deserialization_Universe_ItemCategory(ItemCategory model)
        {
            Assert.That(model, Is.Not.Null);
            Assert.That(model.CategoryId, Is.EqualTo(6));
            Assert.That(model.Name, Is.EqualTo("Ship"));
            Assert.That(model.Published, Is.True);
            Assert.That(model.Groups, Has.Member(25));
        }

        [TestCaseSource(typeof(DeserializationTestCaseSourceProvider<ItemGroup>), nameof(DeserializationTestCaseSourceProvider<ItemGroup>.GetTestData), new object[] { FileName, CustomSectionName })]
        public void Deserialization_Universe_ItemGroup(ItemGroup model)
        {
            Assert.That(model, Is.Not.Null);
            Assert.That(model.CategoryId, Is.EqualTo(6));
            Assert.That(model.Name, Is.EqualTo("Frigate"));
            Assert.That(model.Published, Is.True);
            Assert.That(model.GroupId, Is.EqualTo(25));
            Assert.That(model.Types, Has.Member(587));
        }

        [TestCaseSource(typeof(DeserializationTestCaseSourceProvider<JumpInfo>), nameof(DeserializationTestCaseSourceProvider<JumpInfo>.GetTestData), new object[] { FileName, CustomSectionName })]
        public void Deserialization_Universe_JumpInfo(JumpInfo model)
        {
            Assert.That(model, Is.Not.Null);
            Assert.That(model.ShipJumps, Is.EqualTo(42));
            Assert.That(model.SystemId, Is.EqualTo(30002410));
        }

        [TestCaseSource(typeof(DeserializationTestCaseSourceProvider<KillInfo>), nameof(DeserializationTestCaseSourceProvider<KillInfo>.GetTestData), new object[] { FileName, CustomSectionName })]
        public void Deserialization_Universe_KillInfo(KillInfo model)
        {
            Assert.That(model, Is.Not.Null);
            Assert.That(model.NpcKills, Is.EqualTo(1));
            Assert.That(model.PodKills, Is.EqualTo(24));
            Assert.That(model.ShipKills, Is.EqualTo(42));
            Assert.That(model.SystemId, Is.EqualTo(30002410));
        }

        [TestCaseSource(typeof(DeserializationTestCaseSourceProvider<Moon>), nameof(DeserializationTestCaseSourceProvider<Moon>.GetTestData), new object[] { FileName, CustomSectionName })]
        public void Deserialization_Universe_Moon(Moon model)
        {
            Assert.That(model, Is.Not.Null);
            Assert.That(model.MoonId, Is.EqualTo(40000042));
            Assert.That(model.Name, Is.EqualTo("Akpivem I - Moon 1"));
            Assert.That(model.Position, Is.Not.Null);
            Assert.That(model.SystemId, Is.EqualTo(30000003));
        }

        [TestCaseSource(typeof(DeserializationTestCaseSourceProvider<NamesLookup>), nameof(DeserializationTestCaseSourceProvider<NamesLookup>.GetTestData), new object[] { FileName, CustomSectionName })]
        public void Deserialization_Universe_NamesLookup(NamesLookup model)
        {
            Assert.That(model, Is.Not.Null);
            Assert.That(model.Category, Is.EqualTo(NameCategory.Character));
            Assert.That(model.ID, Is.EqualTo(95465499));
            Assert.That(model.Name, Is.EqualTo("CCP Bartender"));
        }

        [TestCaseSource(typeof(DeserializationTestCaseSourceProvider<Planet>), nameof(DeserializationTestCaseSourceProvider<Planet>.GetTestData), new object[] { FileName, CustomSectionName })]
        public void Deserialization_Universe_Planet(Planet model)
        {
            Assert.That(model, Is.Not.Null);
            Assert.That(model.PlanetId, Is.EqualTo(40000046));
            Assert.That(model.Name, Is.EqualTo("Akpivem III"));
            Assert.That(model.Position, Is.Not.Null);
            Assert.That(model.SystemId, Is.EqualTo(30000003));
            Assert.That(model.TypeId, Is.EqualTo(13));
        }

        [TestCaseSource(typeof(DeserializationTestCaseSourceProvider<Race>), nameof(DeserializationTestCaseSourceProvider<Race>.GetTestData), new object[] { FileName, CustomSectionName })]
        public void Deserialization_Universe_Race(Race model)
        {
            Assert.That(model, Is.Not.Null);
            Assert.That(model.AllianceId, Is.EqualTo(500001));
            Assert.That(model.Description, Is.EqualTo("Founded on the tenets of patriotism and hard work..."));
            Assert.That(model.Name, Is.EqualTo("Caldari"));
            Assert.That(model.RaceId, Is.EqualTo(1));
        }

        [TestCaseSource(typeof(DeserializationTestCaseSourceProvider<Region>), nameof(DeserializationTestCaseSourceProvider<Region>.GetTestData), new object[] { FileName, CustomSectionName })]
        public void Deserialization_Universe_Region(Region model)
        {
            Assert.That(model, Is.Not.Null);
            Assert.That(model.Constellations, Has.Member(20000303));
            Assert.That(model.Description, Is.EqualTo("It has long been an established fact of civilization..."));
            Assert.That(model.Name, Is.EqualTo("Metropolis"));
            Assert.That(model.RegionId, Is.EqualTo(10000042));
        }

        [TestCaseSource(typeof(DeserializationTestCaseSourceProvider<SolarSystemInfo>), nameof(DeserializationTestCaseSourceProvider<SolarSystemInfo>.GetTestData), new object[] { FileName, CustomSectionName })]
        public void Deserialization_Universe_SolarSystemInfo(SolarSystemInfo model)
        {
            Assert.That(model, Is.Not.Null);
            Assert.That(model.ConstellationId, Is.EqualTo(20000001));
            Assert.That(model.Name, Is.EqualTo("Akpivem"));
            Assert.That(model.SecurityClass, Is.EqualTo("B"));
            Assert.That(model.SecurityStatus, Is.EqualTo(0.8462923765182495f));
            Assert.That(model.StarId, Is.EqualTo(40000040));
            Assert.That(model.SystemId, Is.EqualTo(30000003));
            Assert.That(model.Position, Is.Not.Null);
            Assert.That(model.Stations, Has.Member(68797979));
            Assert.That(model.Stargates, Has.Member(50000342));
            Assert.That(model.Planets, Is.Not.Empty);
            Assert.That(model.Planets.First().PlanetId, Is.EqualTo(40000041));
            Assert.That(model.Planets.First().Moons, Has.Member(40000042));
            Assert.That(model.Planets.First().AsteroidBelts, Has.Member(65466666));
        }

        [TestCaseSource(typeof(DeserializationTestCaseSourceProvider<Star>), nameof(DeserializationTestCaseSourceProvider<Star>.GetTestData), new object[] { FileName, CustomSectionName })]
        public void Deserialization_Universe_Star(Star model)
        {
            Assert.That(model, Is.Not.Null);
            Assert.That(model.Age, Is.EqualTo(9398686722));
            Assert.That(model.Luminosity, Is.EqualTo(0.06615000218153f));
            Assert.That(model.Name, Is.EqualTo("BKG-Q2 - Star"));
            Assert.That(model.Radius, Is.EqualTo(346600000));
            Assert.That(model.SolarSystemId, Is.EqualTo(30004333));
            Assert.That(model.SpectralClass, Is.EqualTo("K2 V"));
            Assert.That(model.Temperature, Is.EqualTo(3953));
            Assert.That(model.TypeId, Is.EqualTo(45033));
        }

        [TestCaseSource(typeof(DeserializationTestCaseSourceProvider<Stargate>), nameof(DeserializationTestCaseSourceProvider<Stargate>.GetTestData), new object[] { FileName, CustomSectionName })]
        public void Deserialization_Universe_Stargate(Stargate model)
        {
            Assert.That(model, Is.Not.Null);
            Assert.That(model.StargateId, Is.EqualTo(65166516));
            Assert.That(model.SystemId, Is.EqualTo(30000003));
            Assert.That(model.Name, Is.EqualTo("Stargate (Tanoo)"));
            Assert.That(model.TypeId, Is.EqualTo(29624));
            Assert.That(model.Destination, Is.Not.Null);
            Assert.That(model.Position, Is.Not.Null);
            Assert.That(model.Destination.SystemId, Is.EqualTo(30000001));
            Assert.That(model.Destination.StargateId, Is.EqualTo(50000056));
        }

        [TestCaseSource(typeof(DeserializationTestCaseSourceProvider<Station>), nameof(DeserializationTestCaseSourceProvider<Station>.GetTestData), new object[] { FileName, CustomSectionName })]
        public void Deserialization_Universe_Station(Station model)
        {
            Assert.That(model, Is.Not.Null);
            Assert.That(model.MaxDockableShipVolume, Is.EqualTo(50000000));
            Assert.That(model.OfficeRentalCost, Is.EqualTo(10000f));
            Assert.That(model.Name, Is.EqualTo("Jakanerva III - Moon 15 - Prompt Delivery Storage"));
            Assert.That(model.Owner, Is.EqualTo(1000003));
            Assert.That(model.RaceId, Is.EqualTo(1));
            Assert.That(model.Position, Is.Not.Null);
            Assert.That(model.ReprocessingEfficiency, Is.EqualTo(0.5f));
            Assert.That(model.ReprocessingStationsTake, Is.EqualTo(0.05f));
            Assert.That(model.StationId, Is.EqualTo(60000277));
            Assert.That(model.SystemId, Is.EqualTo(30000148));
            Assert.That(model.TypeId, Is.EqualTo(1531));
            Assert.That(model.Services, Has.Member(Service.CourierMissions));
            Assert.That(model.Services, Has.Member(Service.ReprocessingPlant));
        }

        [TestCaseSource(typeof(DeserializationTestCaseSourceProvider<StructureInfo>), nameof(DeserializationTestCaseSourceProvider<StructureInfo>.GetTestData), new object[] { FileName, CustomSectionName })]
        public void Deserialization_Universe_StructureInfo(StructureInfo model)
        {
            Assert.That(model, Is.Not.Null);
            Assert.That(model.OwnerId, Is.EqualTo(109299958));
            Assert.That(model.SolarSystemId, Is.EqualTo(30000142));
            Assert.That(model.Name, Is.EqualTo("V-3YG7 VI - The Capital"));
            Assert.That(model.TypeId, Is.EqualTo(855558));
            Assert.That(model.Position, Is.Not.Null);
        }
    }
}
