using System.Collections.Generic;
using System.Threading.Tasks;

using EVEClient.NET.Attributes;
using EVEClient.NET.DataContract;

namespace EVEClient.NET
{
    public interface IUniverseLogic
    {
        /// <summary>
        /// Get all character ancestries
        /// </summary>
        [PublicEndpoint]
        [Route("/latest/universe/ancestries/", Version = EndpointVersion.Latest)]
        [Route("/legacy/universe/ancestries/", Version = EndpointVersion.Legacy)]
        [Route("/v1/universe/ancestries/", Version = EndpointVersion.V1, Preferred = true)]
        Task<EsiResponse<List<Ancestry>>>Ancestries();

        /// <summary>
        /// Get information on an asteroid belt
        /// </summary>
        /// <param name="asteroidBeltId">An asteroid belt identifier</param>
        [PublicEndpoint]
        [Route("/latest/universe/asteroid_belts/{asteroid_belt_id}/", Version = EndpointVersion.Latest)]
        [Route("/legacy/universe/asteroid_belts/{asteroid_belt_id}/", Version = EndpointVersion.Legacy)]
        [Route("/v1/universe/asteroid_belts/{asteroid_belt_id}/", Version = EndpointVersion.V1, Preferred = true)]
        Task<EsiResponse<AsteroidBelt>> AsteroidBeltInfo(int asteroidBeltId);

        /// <summary>
        /// Get a list of bloodlines
        /// </summary>
        [PublicEndpoint]
        [Route("/latest/universe/bloodlines/", Version = EndpointVersion.Latest)]
        [Route("/legacy/universe/bloodlines/", Version = EndpointVersion.Legacy)]
        [Route("/v1/universe/bloodlines/", Version = EndpointVersion.V1, Preferred = true)]
        Task<EsiResponse<List<Bloodline>>> Bloodlines();

        /// <summary>
        /// Get a list of item categories
        /// </summary>
        [PublicEndpoint]
        [Route("/latest/universe/categories/", Version = EndpointVersion.Latest)]
        [Route("/legacy/universe/categories/", Version = EndpointVersion.Legacy)]
        [Route("/v1/universe/categories/", Version = EndpointVersion.V1, Preferred = true)]
        Task<EsiResponse<List<int>>> ItemCategories();

        /// <summary>
        /// Get information of an item category
        /// </summary>
        /// <param name="categoryId">An Eve item category ID</param>
        [PublicEndpoint]
        [Route("/latest/universe/categories/{category_id}/", Version = EndpointVersion.Latest)]
        [Route("/legacy/universe/categories/{category_id}/", Version = EndpointVersion.Legacy)]
        [Route("/v1/universe/categories/{category_id}/", Version = EndpointVersion.V1, Preferred = true)]
        Task<EsiResponse<ItemCategory>> ItemCategoryInfo(int categoryId);

        /// <summary>
        /// Get a list of constellations
        /// </summary>
        [PublicEndpoint]
        [Route("/latest/universe/constellations/", Version = EndpointVersion.Latest)]
        [Route("/legacy/universe/constellations/", Version = EndpointVersion.Legacy)]
        [Route("/v1/universe/constellations/", Version = EndpointVersion.V1, Preferred = true)]
        Task<EsiResponse<List<int>>> Constellations();

        /// <summary>
        /// Get information on a constellation
        /// </summary>
        /// <param name="constellationId">An EVE Constellation IDr</param>
        [PublicEndpoint]
        [Route("/latest/universe/constellations/{constellation_id}/", Version = EndpointVersion.Latest)]
        [Route("/legacy/universe/constellations/{constellation_id}/", Version = EndpointVersion.Legacy)]
        [Route("/v1/universe/constellations/{constellation_id}/", Version = EndpointVersion.V1, Preferred = true)]
        Task<EsiResponse<Constellation>> ConstellationInfo(int constellationId);

        /// <summary>
        /// Get a list of factions
        /// </summary>
        [PublicEndpoint]
        [Route("/latest/universe/factions/", Version = EndpointVersion.Latest)]
        [Route("/dev/universe/factions/", Version = EndpointVersion.Dev)]
        [Route("/v2/universe/factions/", Version = EndpointVersion.V2, Preferred = true)]
        Task<EsiResponse<List<Faction>>> Factions();

        /// <summary>
        /// Get a list of graphics
        /// </summary>
        [PublicEndpoint]
        [Route("/latest/universe/graphics/", Version = EndpointVersion.Latest)]
        [Route("/legacy/universe/graphics/", Version = EndpointVersion.Legacy)]
        [Route("/v1/universe/graphics/", Version = EndpointVersion.V1, Preferred = true)]
        Task<EsiResponse<List<int>>> Graphics();

        /// <summary>
        /// Get information on a graphic
        /// </summary>
        /// <param name="graphicId">An EVE graphic ID</param>
        [PublicEndpoint]
        [Route("/latest/universe/graphics/{graphic_id}/", Version = EndpointVersion.Latest)]
        [Route("/legacy/universe/graphics/{graphic_id}/", Version = EndpointVersion.Legacy)]
        [Route("/v1/universe/graphics/{graphic_id}/", Version = EndpointVersion.V1, Preferred = true)]
        [Route("/dev/universe/graphics/{graphic_id}/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<Graphic>> GraphicInfo(int graphicId);

        /// <summary>
        /// Get a list of item groups
        /// </summary>
        /// <param name="page">Which page of results to return. Default value : 1</param>
        [PublicEndpoint]
        [Route("/latest/universe/groups/", Version = EndpointVersion.Latest)]
        [Route("/legacy/universe/groups/", Version = EndpointVersion.Legacy)]
        [Route("/v1/universe/groups/", Version = EndpointVersion.V1, Preferred = true)]
        Task<EsiResponsePagination<List<int>>> ItemGroups(int page = 1);

        /// <summary>
        /// Get information on an item group
        /// </summary>
        /// <param name="groupId">An Eve item group ID</param>
        [PublicEndpoint]
        [Route("/latest/universe/groups/{group_id}/", Version = EndpointVersion.Latest)]
        [Route("/legacy/universe/groups/{group_id}/", Version = EndpointVersion.Legacy)]
        [Route("/v1/universe/groups/{group_id}/", Version = EndpointVersion.V1, Preferred = true)]
        [Route("/dev/universe/groups/{group_id}/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<ItemGroup>> ItemGroupInfo(int groupId);

        /// <summary>
        /// Resolve a set of names to IDs in the following categories: agents, alliances, characters, constellations, corporations factions, inventory_types, regions, stations, and systems.
        /// Only exact matches will be returned. All names searched for are cached for 12 hours
        /// </summary>
        /// <param name="names">The names to resolve</param>
        [PublicEndpoint]
        [Route("/latest/universe/ids/", Version = EndpointVersion.Latest)]
        [Route("/legacy/universe/ids/", Version = EndpointVersion.Legacy)]
        [Route("/v1/universe/ids/", Version = EndpointVersion.V1, Preferred = true)]
        [Route("/dev/universe/ids/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<IDsLookup>> IDs(string[] names);

        /// <summary>
        /// Get information on a moon
        /// </summary>
        /// <param name="moonId">An Eve moon ID</param>
        [PublicEndpoint]
        [Route("/latest/universe/moons/{moon_id}/", Version = EndpointVersion.Latest)]
        [Route("/legacy/universe/moons/{moon_id}/", Version = EndpointVersion.Legacy)]
        [Route("/v1/universe/moons/{moon_id}/", Version = EndpointVersion.V1, Preferred = true)]
        Task<EsiResponse<Moon>> MoonInfo(int moonId);

        /// <summary>
        /// Get names and categories for a set of IDs
        /// Resolve a set of IDs to names and categories. Supported ID’s for resolving are: Characters, Corporations, Alliances, Stations, Solar Systems, Constellations, Regions, Types, Factions
        /// </summary>
        /// <param name="ids">The ids to resolve</param>
        [PublicEndpoint]
        [Route("/latest/universe/names/", Version = EndpointVersion.Latest)]
        [Route("/v3/universe/names/", Version = EndpointVersion.V3, Preferred = true)]
        [Route("/dev/universe/names/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<List<NamesLookup>>> Names(int[] ids);

        /// <summary>
        /// Get information on a planet
        /// </summary>
        /// <param name="planetId">An Eve planet ID</param>
        [PublicEndpoint]
        [Route("/latest/universe/planets/{planet_id}/", Version = EndpointVersion.Latest)]
        [Route("/legacy/universe/planets/{planet_id}/", Version = EndpointVersion.Legacy)]
        [Route("/v1/universe/planets/{planet_id}/", Version = EndpointVersion.V1, Preferred = true)]
        Task<EsiResponse<Planet>> PlanetInfo(int planetId);

        /// <summary>
        /// Get a list of character races
        /// </summary>
        [PublicEndpoint]
        [Route("/latest/universe/races/", Version = EndpointVersion.Latest)]
        [Route("/legacy/universe/races/", Version = EndpointVersion.Legacy)]
        [Route("/v1/universe/races/", Version = EndpointVersion.V1, Preferred = true)]
        [Route("/dev/universe/races/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<List<Race>>> Races();

        /// <summary>
        /// Get a list of regions
        /// </summary>
        [PublicEndpoint]
        [Route("/latest/universe/regions/", Version = EndpointVersion.Latest)]
        [Route("/legacy/universe/regions/", Version = EndpointVersion.Legacy)]
        [Route("/v1/universe/regions/", Version = EndpointVersion.V1, Preferred = true)]
        Task<EsiResponse<List<int>>> Regions();

        /// <summary>
        /// Get information on a region
        /// </summary>
        /// <param name="regionId">An Eve region ID</param>
        [PublicEndpoint]
        [Route("/latest/universe/regions/{region_id}/", Version = EndpointVersion.Latest)]
        [Route("/legacy/universe/regions/{region_id}/", Version = EndpointVersion.Legacy)]
        [Route("/v1/universe/regions/{region_id}/", Version = EndpointVersion.V1, Preferred = true)]
        Task<EsiResponse<Region>> RegionInfo(int regionId);

        /// <summary>
        /// Get information on a stargate
        /// </summary>
        /// <param name="stargateId">An Eve stargate ID</param>
        [PublicEndpoint]
        [Route("/latest/universe/stargates/{stargate_id}/", Version = EndpointVersion.Latest)]
        [Route("/legacy/universe/stargates/{stargate_id}/", Version = EndpointVersion.Legacy)]
        [Route("/v1/universe/stargates/{stargate_id}/", Version = EndpointVersion.V1, Preferred = true)]
        Task<EsiResponse<Stargate>> StargateInfo(int stargateId);

        /// <summary>
        /// Get information on a star
        /// </summary>
        /// <param name="starId">An Eve star ID</param>
        [PublicEndpoint]
        [Route("/latest/universe/stars/{star_id}/", Version = EndpointVersion.Latest)]
        [Route("/legacy/universe/stars/{star_id}/", Version = EndpointVersion.Legacy)]
        [Route("/v1/universe/stars/{star_id}/", Version = EndpointVersion.V1, Preferred = true)]
        Task<EsiResponse<Star>> StarInfo(int starId);

        /// <summary>
        /// Get information on a station
        /// </summary>
        /// <param name="stationId">An Eve station ID</param>
        [PublicEndpoint]
        [Route("/latest/universe/stations/{station_id}/", Version = EndpointVersion.Latest)]
        [Route("/v2/universe/stations/{station_id}/", Version = EndpointVersion.V2, Preferred = true)]
        [Route("/dev/universe/stations/{station_id}/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<Station>> StationInfo(int stationId);

        /// <summary>
        /// List all public structures
        /// </summary>
        /// <param name="type">Only list public structures that have this service online</param>
        [PublicEndpoint]
        [Route("/latest/universe/structures/", Version = EndpointVersion.Latest)]
        [Route("/legacy/universe/structures/", Version = EndpointVersion.Legacy)]
        [Route("/v1/universe/structures/", Version = EndpointVersion.V1, Preferred = true)]
        [Route("/dev/universe/structures/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<List<long>>> Structures(StructureType? type);

        /// <summary>
        /// Returns information on requested structure if you are on the ACL. Otherwise, returns “Forbidden” for all inputs.
        /// </summary>
        /// <param name="structureId">An Eve structure ID</param>
        [ProtectedEndpoint(RequiredScope = "esi-universe.read_structures.v1")]
        [Route("/latest/universe/structures/{structure_id}/", Version = EndpointVersion.Latest)]
        [Route("/v2/universe/structures/{structure_id}/", Version = EndpointVersion.V2, Preferred = true)]
        Task<EsiResponse<StructureInfo>> StructureInfo(long structureId);

        /// <summary>
        /// Get the number of jumps in solar systems within the last hour ending at the timestamp of the Last-Modified header, excluding wormhole space.
        /// Only systems with jumps will be listed
        /// </summary>
        [PublicEndpoint]
        [Route("/latest/universe/system_jumps/", Version = EndpointVersion.Latest)]
        [Route("/legacy/universe/system_jumps/", Version = EndpointVersion.Legacy)]
        [Route("/v1/universe/system_jumps/", Version = EndpointVersion.V1, Preferred = true)]
        Task<EsiResponse<List<JumpInfo>>> SystemJumps();

        /// <summary>
        /// Get the number of ship, pod and NPC kills per solar system within the last hour ending at the timestamp of the Last-Modified header, excluding wormhole space.
        /// Only systems with kills will be listed
        /// </summary>
        [PublicEndpoint]
        [Route("/latest/universe/system_kills/", Version = EndpointVersion.Latest)]
        [Route("/v2/universe/system_kills/", Version = EndpointVersion.V2, Preferred = true)]
        Task<EsiResponse<List<KillInfo>>> SystemKills();

        /// <summary>
        /// Get a list of solar systems
        /// </summary>
        [PublicEndpoint]
        [Route("/latest/universe/systems/", Version = EndpointVersion.Latest)]
        [Route("/legacy/universe/systems/", Version = EndpointVersion.Legacy)]
        [Route("/v1/universe/systems/", Version = EndpointVersion.V1, Preferred = true)]
        [Route("/dev/universe/systems/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<List<int>>> SolarSystems();

        /// <summary>
        /// Information about a solar system
        /// </summary>
        /// <param name="systemId">An Eve solar system ID</param>
        [PublicEndpoint]
        [Route("/latest/universe/systems/{system_id}/", Version = EndpointVersion.Latest)]
        [Route("/v4/universe/systems/{system_id}/", Version = EndpointVersion.V4, Preferred = true)]
        [Route("/dev/universe/systems/{system_id}/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<SolarSystemInfo>> SolarSystemInfo(int systemId);

        /// <summary>
        /// Get a list of type ids
        /// </summary>
        [PublicEndpoint]
        [Route("/latest/universe/types/", Version = EndpointVersion.Latest)]
        [Route("/legacy/universe/types/", Version = EndpointVersion.Legacy)]
        [Route("/v1/universe/types/", Version = EndpointVersion.V1, Preferred = true)]
        Task<EsiResponse<List<int>>> Types();

        /// <summary>
        /// Get information on a type
        /// </summary>
        /// <param name="typeId">An Eve item type ID</param>
        [PublicEndpoint]
        [Route("/latest/universe/types/{type_id}/", Version = EndpointVersion.Latest)]
        [Route("/v3/universe/types/{type_id}/", Version = EndpointVersion.V3, Preferred = true)]
        [Route("/dev/universe/types/{type_id}/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<EveType>> TypeInfo(int typeId);
    }
}
