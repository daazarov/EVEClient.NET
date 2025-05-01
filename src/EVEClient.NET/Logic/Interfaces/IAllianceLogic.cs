using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

using EVEClient.NET.DataContract;

namespace EVEClient.NET
{
    public interface IAllianceLogic
    {
        /// <summary>
        /// List all active player alliances
        /// </summary>
        Task<EsiResponse<List<int>>> ActiveAlliances(CancellationToken cancellationToken = default);

        /// <summary>
        /// Public information about an alliance
        /// </summary>
        /// <param name="allianceId">An EVE alliance ID</param>
        Task<EsiResponse<Alliance>> PublicInformation(int allianceId, CancellationToken cancellationToken = default);

        /// <summary>
        /// List all current member corporations of an alliance
        /// </summary>
        /// <param name="allianceId">An EVE alliance ID</param>
        Task<EsiResponse<List<int>>> CorporationsInAlliance(int allianceId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the icon urls for a alliance
        /// </summary>
        /// <param name="allianceId">An EVE alliance ID</param>
        /// <returns></returns>
        Task<EsiResponse<AllianceIcon>> AllianceIcon(int allianceId, CancellationToken cancellationToken = default);
    }
}
