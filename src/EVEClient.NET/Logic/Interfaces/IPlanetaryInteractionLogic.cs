using System.Collections.Generic;
using System.Threading.Tasks;

using EVEClient.NET.Attributes;
using EVEClient.NET.DataContract;

namespace EVEClient.NET
{
    public interface IPlanetaryInteractionLogic
    {
        /// <summary>
        /// Returns a list of all planetary colonies owned by a character.
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        [ProtectedEndpoint(RequiredScope = "esi-planets.manage_planets.v1")]
        [Route("/latest/characters/{character_id}/planets/", Version = EndpointVersion.Latest)]
        [Route("/legacy/characters/{character_id}/planets/", Version = EndpointVersion.Legacy)]
        [Route("/v1/characters/{character_id}/planets/", Version = EndpointVersion.V1, Preferred = true)]
        [Route("/dev/characters/{character_id}/planets/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<List<Colony>>> Colonies(int characterId);

        /// <summary>
        /// Returns full details on the layout of a single planetary colony, including links, pins and routes.
        /// <para>Note: Planetary information is only recalculated when the colony is viewed through the client. Information will not update until this criteria is met.</para>
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="planetId">Planet id of the target planet</param>
        [ProtectedEndpoint(RequiredScope = "esi-planets.manage_planets.v1")]
        [Route("/latest/characters/{character_id}/planets/{planet_id}/", Version = EndpointVersion.Latest)]
        [Route("/v3/characters/{character_id}/planets/{planet_id}/", Version = EndpointVersion.V3, Preferred = true)]
        [Route("/dev/characters/{character_id}/planets/{planet_id}/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<ColonyLayout>> ColonyInfo(int characterId, int planetId);

        /// <summary>
        /// List customs offices owned by a corporation
        /// <para>Requires one of the following EVE corporation role(s): Director</para>
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="page">Which page of results to return. Default value: 1</param>
        [ProtectedEndpoint(RequiredScope = "esi-planets.read_customs_offices.v1")]
        [Route("/latest/corporations/{corporation_id}/customs_offices/", Version = EndpointVersion.Latest)]
        [Route("/legacy/corporations/{corporation_id}/customs_offices/", Version = EndpointVersion.Legacy)]
        [Route("/v1/corporations/{corporation_id}/customs_offices/", Version = EndpointVersion.V1, Preferred = true)]
        [Route("/dev/corporations/{corporation_id}/customs_offices/", Version = EndpointVersion.Dev)]
        Task<EsiResponsePagination<List<CustomOffice>>> CorporationCustomOffices(int corporationId, int page = 1);

        /// <summary>
        /// Get information on a planetary factory schematic
        /// </summary>
        /// <param name="schematicId">A PI schematic ID</param>
        [PublicEndpoint]
        [Route("/latest/universe/schematics/{schematic_id}/", Version = EndpointVersion.Latest)]
        [Route("/legacy/universe/schematics/{schematic_id}/", Version = EndpointVersion.Legacy)]
        [Route("/v1/universe/schematics/{schematic_id}/", Version = EndpointVersion.V1, Preferred = true)]
        [Route("/dev/universe/schematics/{schematic_id}/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<SchematicInfo>> SchematicInfo(int schematicId);
    }
}
