using System.Collections.Generic;
using System.Threading.Tasks;

using EVEClient.NET.Attributes;
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
        [ProtectedEndpoint(RequiredScope = "esi-killmails.read_killmails.v1")]
        [Route("/latest/characters/{character_id}/killmails/recent/", Version = EndpointVersion.Latest)]
        [Route("/legacy/characters/{character_id}/killmails/recent/", Version = EndpointVersion.Legacy)]
        [Route("/v1/characters/{character_id}/killmails/recent/", Version = EndpointVersion.V1, Preferred = true)]
        [Route("/dev/characters/{character_id}/killmails/recent/", Version = EndpointVersion.Dev)]
        Task<EsiResponsePagination<List<Killmail>>> CharacterKillmails(int characterId, int page = 1);

        /// <summary>
        /// Get a list of a corporation’s kills and losses going back 90 days
        /// <para>Requires one of the following EVE corporation role(s): Director</para>
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="page">Which page of results to return. Default value : 1</param>
        [ProtectedEndpoint(RequiredScope = "esi-killmails.read_corporation_killmails.v1")]
        [Route("/latest/corporations/{corporation_id}/killmails/recent/", Version = EndpointVersion.Latest)]
        [Route("/legacy/corporations/{corporation_id}/killmails/recent/", Version = EndpointVersion.Legacy)]
        [Route("/v1/corporations/{corporation_id}/killmails/recent/", Version = EndpointVersion.V1, Preferred = true)]
        [Route("/dev/corporations/{corporation_id}/killmails/recent/", Version = EndpointVersion.Dev)]
        Task<EsiResponsePagination<List<Killmail>>> CorporationKillmails(int corporationId, int page = 1);

        /// <summary>
        /// Return a single killmail from its ID and hash
        /// </summary>
        /// <param name="killmailId">The killmail ID to be queried</param>
        /// <param name="killmainHash">The killmail hash for verification</param>
        [PublicEndpoint]
        [Route("/latest/killmails/{killmail_id}/{killmail_hash}/", Version = EndpointVersion.Latest)]
        [Route("/legacy/killmails/{killmail_id}/{killmail_hash}/", Version = EndpointVersion.Legacy)]
        [Route("/v1/killmails/{killmail_id}/{killmail_hash}/", Version = EndpointVersion.V1, Preferred = true)]
        [Route("/dev/killmails/{killmail_id}/{killmail_hash}/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<KillmailInfo>> KillmailInfo(int killmailId, string killmainHash);
    }
}
