using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

using EVEClient.NET.DataContract;

namespace EVEClient.NET
{
    public interface IPlanetaryInteractionLogic
    {
        /// <summary>
        /// Returns a list of all planetary colonies owned by a character.
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        Task<EsiResponse<List<Colony>>> Colonies(int characterId, string? token = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Returns full details on the layout of a single planetary colony, including links, pins and routes.
        /// <para>Note: Planetary information is only recalculated when the colony is viewed through the client. Information will not update until this criteria is met.</para>
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="planetId">Planet id of the target planet</param>
        Task<EsiResponse<ColonyLayout>> ColonyInfo(int characterId, int planetId, string? token = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// List customs offices owned by a corporation
        /// <para>Requires one of the following EVE corporation role(s): Director</para>
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="page">Which page of results to return. Default value: 1</param>
        Task<EsiResponsePagination<List<CustomOffice>>> CorporationCustomOffices(int corporationId, int page = 1, string? token = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get information on a planetary factory schematic
        /// </summary>
        /// <param name="schematicId">A PI schematic ID</param>
        Task<EsiResponse<SchematicInfo>> SchematicInfo(int schematicId, CancellationToken cancellationToken = default);
    }
}
