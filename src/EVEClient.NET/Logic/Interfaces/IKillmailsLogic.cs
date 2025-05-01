using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

using EVEClient.NET.DataContract;

namespace EVEClient.NET
{
    public interface IKillmailsLogic
    {
        /// <summary>
        /// Return a list of a character’s kills and losses going back 90 days
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="page">Which page of results to return. Default value : 1</param>
        Task<EsiResponsePagination<List<Killmail>>> CharacterKillmails(int characterId, int page = 1, string? token = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get a list of a corporation’s kills and losses going back 90 days
        /// <para>Requires one of the following EVE corporation role(s): Director</para>
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="page">Which page of results to return. Default value : 1</param>
        Task<EsiResponsePagination<List<Killmail>>> CorporationKillmails(int corporationId, int page = 1, string? token = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Return a single killmail from its ID and hash
        /// </summary>
        /// <param name="killmailId">The killmail ID to be queried</param>
        /// <param name="killmainHash">The killmail hash for verification</param>
        Task<EsiResponse<KillmailInfo>> KillmailInfo(int killmailId, string killmainHash, CancellationToken cancellationToken = default);
    }
}
