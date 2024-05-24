using System.Collections.Generic;
using System.Threading.Tasks;

using EVEClient.NET.DataContract;

using static EVEClient.NET.Models.CommonRequests;

namespace EVEClient.NET.Logic
{
    internal class FactionWarfareLogic : IFactionWarfareLogic
    {
        private readonly IEsiHttpClient<IFactionWarfareLogic> _esiClient;

        public FactionWarfareLogic(IEsiHttpClient<IFactionWarfareLogic> esiClient)
        {
            _esiClient = esiClient;
        }

        public Task<EsiResponse<Leaderboards<CharacterTotal>>> CaractersLeaderboard() =>
            _esiClient.GetRequestAsync<Leaderboards<CharacterTotal>>();

        public Task<EsiResponse<CharacterStats>> CharacterStats(int characterId) =>
            _esiClient.GetRequestAsync<CharacterIdRouteRequest, CharacterStats>(CharacterIdRouteRequest.Create(characterId));

        public Task<EsiResponse<Leaderboards<CorporationTotal>>> CorporationsLeaderboard() =>
            _esiClient.GetRequestAsync<Leaderboards<CorporationTotal>>();

        public Task<EsiResponse<CorporationStats>> CorporationStats(int corporationId) =>
            _esiClient.GetRequestAsync<CorporationIdRouteRequest, CorporationStats>(CorporationIdRouteRequest.Create(corporationId));

        public Task<EsiResponse<Leaderboards<FactionTotal>>> FactionsLeaderboard() =>
            _esiClient.GetRequestAsync<Leaderboards<FactionTotal>>();

        public Task<EsiResponse<FactionStats>> FactionsStats() =>
            _esiClient.GetRequestAsync<FactionStats>();

        public Task<EsiResponse<List<FactionWar>>> Wars() =>
            _esiClient.GetRequestAsync<List<FactionWar>>();

        public Task<EsiResponse<List<FactionWarfareSystem>>> OwnershipSystemOverview() =>
            _esiClient.GetRequestAsync<List<FactionWarfareSystem>>();
    }
}
