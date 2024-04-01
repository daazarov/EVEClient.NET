using System.Collections.Generic;
using System.Threading.Tasks;

using EVEOnline.ESI.Communication.DataContract;

using static EVEOnline.ESI.Communication.Models.CommonRequests;

namespace EVEOnline.ESI.Communication.Logic
{
    internal class FactionWarfareLogic : IFactionWarfareLogic
    {
        private readonly IEsiHttpClient<IFactionWarfareLogic> _esiClient;

        public FactionWarfareLogic(IEsiHttpClient<IFactionWarfareLogic> esiClient)
        {
            _esiClient = esiClient;
        }

        public Task<EsiResponse<Leaderboards<CharacterTotal>>> GetCaractersLeaderboardAsync() =>
            _esiClient.GetRequestAsync<Leaderboards<CharacterTotal>>();

        public Task<EsiResponse<CharacterStats>> GetCharacterStatsAsync(int characterId) =>
            _esiClient.GetRequestAsync<CharacterIdRouteRequest, CharacterStats>(CharacterIdRouteRequest.Create(characterId));

        public Task<EsiResponse<Leaderboards<CorporationTotal>>> GetCorporationsLeaderboardAsync() =>
            _esiClient.GetRequestAsync<Leaderboards<CorporationTotal>>();

        public Task<EsiResponse<CorporationStats>> GetCorporationStatsAsync(int corporationId) =>
            _esiClient.GetRequestAsync<CorporationIdRouteRequest, CorporationStats>(CorporationIdRouteRequest.Create(corporationId));

        public Task<EsiResponse<Leaderboards<FactionTotal>>> GetFactionsLeaderboardAsync() =>
            _esiClient.GetRequestAsync<Leaderboards<FactionTotal>>();

        public Task<EsiResponse<FactionStats>> GetFactionsStatsAsync() =>
            _esiClient.GetRequestAsync<FactionStats>();

        public Task<EsiResponse<List<War>>> GetWarsAsync() =>
            _esiClient.GetRequestAsync<List<War>>();

        public Task<EsiResponse<List<FactionWarfareSystem>>> OwnershipSystemOverviewAsync() =>
            _esiClient.GetRequestAsync<List<FactionWarfareSystem>>();
    }
}
