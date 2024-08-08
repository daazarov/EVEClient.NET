using System.Collections.Generic;
using System.Threading.Tasks;

using EVEClient.NET.DataContract;

using static EVEClient.NET.Models.CommonRequests;
using static EVEClient.NET.Models.KillmailsRequests;

namespace EVEClient.NET.Logic
{
    internal class KillmailsLogic : IKillmailsLogic
    {
        private readonly IEsiHttpClient<IKillmailsLogic> _esiClient;

        public KillmailsLogic(IEsiHttpClient<IKillmailsLogic> esiClient)
        {
            _esiClient = esiClient;
        }

        public Task<EsiResponsePagination<List<Killmail>>> CharacterKillmails(int characterId, int page = 1, string? token = null) =>
            _esiClient.GetPaginationRequestAsync<PageBasedCharacterIdRouteRequest, List<Killmail>>(PageBasedCharacterIdRouteRequest.Create(characterId, page), token);

        public Task<EsiResponsePagination<List<Killmail>>> CorporationKillmails(int corporationId, int page = 1, string? token = null) =>
            _esiClient.GetPaginationRequestAsync<PageBasedCorporationIdRouteRequest, List<Killmail>>(PageBasedCorporationIdRouteRequest.Create(corporationId, page), token);

        public Task<EsiResponse<KillmailInfo>> KillmailInfo(int killmailId, string killmainHash) =>
            _esiClient.GetRequestAsync<KillmailInfoRequest, KillmailInfo>(KillmailInfoRequest.Create(killmailId, killmainHash));
    }
}
