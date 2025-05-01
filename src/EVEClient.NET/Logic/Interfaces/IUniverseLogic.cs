using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

using EVEClient.NET.DataContract;

namespace EVEClient.NET
{
    public interface IUniverseLogic
    {
        /// <summary>
        /// Get all character ancestries
        /// </summary>
        Task<EsiResponse<List<Ancestry>>>Ancestries(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get information on an asteroid belt
        /// </summary>
        /// <param name="asteroidBeltId">An asteroid belt identifier</param>
        Task<EsiResponse<AsteroidBelt>> AsteroidBeltInfo(int asteroidBeltId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get a list of bloodlines
        /// </summary>
        Task<EsiResponse<List<Bloodline>>> Bloodlines(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get a list of item categories
        /// </summary>
        Task<EsiResponse<List<int>>> ItemCategories(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get information of an item category
        /// </summary>
        /// <param name="categoryId">An Eve item category ID</param>
        Task<EsiResponse<ItemCategory>> ItemCategoryInfo(int categoryId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get a list of constellations
        /// </summary>
        Task<EsiResponse<List<int>>> Constellations(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get information on a constellation
        /// </summary>
        /// <param name="constellationId">An EVE Constellation IDr</param>
        Task<EsiResponse<Constellation>> ConstellationInfo(int constellationId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get a list of factions
        /// </summary>
        Task<EsiResponse<List<Faction>>> Factions(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get a list of graphics
        /// </summary>
        Task<EsiResponse<List<int>>> Graphics(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get information on a graphic
        /// </summary>
        /// <param name="graphicId">An EVE graphic ID</param>
        Task<EsiResponse<Graphic>> GraphicInfo(int graphicId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get a list of item groups
        /// </summary>
        /// <param name="page">Which page of results to return. Default value : 1</param>
        Task<EsiResponsePagination<List<int>>> ItemGroups(int page = 1, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get information on an item group
        /// </summary>
        /// <param name="groupId">An Eve item group ID</param>
        Task<EsiResponse<ItemGroup>> ItemGroupInfo(int groupId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Resolve a set of names to IDs in the following categories: agents, alliances, characters, constellations, corporations factions, inventory_types, regions, stations, and systems.
        /// Only exact matches will be returned. All names searched for are cached for 12 hours
        /// </summary>
        /// <param name="names">The names to resolve</param>
        Task<EsiResponse<IDsLookup>> IDs(string[] names, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get information on a moon
        /// </summary>
        /// <param name="moonId">An Eve moon ID</param>
        Task<EsiResponse<Moon>> MoonInfo(int moonId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get names and categories for a set of IDs
        /// Resolve a set of IDs to names and categories. Supported ID’s for resolving are: Characters, Corporations, Alliances, Stations, Solar Systems, Constellations, Regions, Types, Factions
        /// </summary>
        /// <param name="ids">The ids to resolve</param>
        Task<EsiResponse<List<NamesLookup>>> Names(int[] ids, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get information on a planet
        /// </summary>
        /// <param name="planetId">An Eve planet ID</param>
        Task<EsiResponse<Planet>> PlanetInfo(int planetId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get a list of character races
        /// </summary>
        Task<EsiResponse<List<Race>>> Races(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get a list of regions
        /// </summary>
        Task<EsiResponse<List<int>>> Regions(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get information on a region
        /// </summary>
        /// <param name="regionId">An Eve region ID</param>
        Task<EsiResponse<Region>> RegionInfo(int regionId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get information on a stargate
        /// </summary>
        /// <param name="stargateId">An Eve stargate ID</param>
        Task<EsiResponse<Stargate>> StargateInfo(int stargateId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get information on a star
        /// </summary>
        /// <param name="starId">An Eve star ID</param>
        Task<EsiResponse<Star>> StarInfo(int starId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get information on a station
        /// </summary>
        /// <param name="stationId">An Eve station ID</param>
        Task<EsiResponse<Station>> StationInfo(int stationId, CancellationToken cancellationToken = default);

        /// <summary>
        /// List all public structures
        /// </summary>
        /// <param name="type">Only list public structures that have this service online</param>
        Task<EsiResponse<List<long>>> Structures(StructureType? type, CancellationToken cancellationToken = default);

        /// <summary>
        /// Returns information on requested structure if you are on the ACL. Otherwise, returns “Forbidden” for all inputs.
        /// </summary>
        /// <param name="structureId">An Eve structure ID</param>
        Task<EsiResponse<StructureInfo>> StructureInfo(long structureId, string? token = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the number of jumps in solar systems within the last hour ending at the timestamp of the Last-Modified header, excluding wormhole space.
        /// Only systems with jumps will be listed
        /// </summary>
        Task<EsiResponse<List<JumpInfo>>> SystemJumps(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the number of ship, pod and NPC kills per solar system within the last hour ending at the timestamp of the Last-Modified header, excluding wormhole space.
        /// Only systems with kills will be listed
        /// </summary>
        Task<EsiResponse<List<KillInfo>>> SystemKills(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get a list of solar systems
        /// </summary>
        Task<EsiResponse<List<int>>> SolarSystems(CancellationToken cancellationToken = default);

        /// <summary>
        /// Information about a solar system
        /// </summary>
        /// <param name="systemId">An Eve solar system ID</param>
        Task<EsiResponse<SolarSystemInfo>> SolarSystemInfo(int systemId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get a list of type ids
        /// </summary>
        Task<EsiResponse<List<int>>> Types(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get information on a type
        /// </summary>
        /// <param name="typeId">An Eve item type ID</param>
        Task<EsiResponse<EveType>> TypeInfo(int typeId, CancellationToken cancellationToken = default);
    }
}
