using System.Collections.Generic;
using System.Threading.Tasks;

using EVEOnline.ESI.Communication.DataContract;

using static EVEOnline.ESI.Communication.Models.CommonRequests;
using static EVEOnline.ESI.Communication.Models.KillmailsRequests;

namespace EVEOnline.ESI.Communication.Logic
{
    internal class KillmailsLogic : IKillmailsLogic
    {
        private readonly IEsiHttpClient<IKillmailsLogic> _esiClient;

        public KillmailsLogic(IEsiHttpClient<IKillmailsLogic> esiClient)
        {
            _esiClient = esiClient;
        }

        public Task<EsiResponsePagination<List<Killmail>>> CharacterKillmails(int characterId, int page = 1) =>
            _esiClient.GetPaginationRequestAsync<PageBasedCharacterIdRouteRequest, List<Killmail>>(PageBasedCharacterIdRouteRequest.Create(characterId, page));

        public Task<EsiResponsePagination<List<Killmail>>> CorporationKillmails(int corporationId, int page = 1) =>
            _esiClient.GetPaginationRequestAsync<PageBasedCorporationIdRouteRequest, List<Killmail>>(PageBasedCorporationIdRouteRequest.Create(corporationId, page));

        public Task<EsiResponse<KillmailInfo>> KillmailInfo(int killmailId, string killmainHash) =>
            _esiClient.GetRequestAsync<KillmailInfoRequest, KillmailInfo>(KillmailInfoRequest.Create(killmailId, killmainHash));
    }
}
