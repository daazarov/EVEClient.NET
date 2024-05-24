using System.Collections.Generic;
using System.Threading.Tasks;

using EVEClient.NET.DataContract;

using static EVEClient.NET.Models.CommonRequests;

namespace EVEClient.NET.Logic
{
    internal class LoyaltyLogic : ILoyaltyLogic
    {
        private readonly IEsiHttpClient<ILoyaltyLogic> _esiClient;

        public LoyaltyLogic(IEsiHttpClient<ILoyaltyLogic> esiClient)
        {
            _esiClient = esiClient;
        }

        public Task<EsiResponse<List<Offer>>> CorporationOffers(int corporationId) =>
            _esiClient.GetRequestAsync<CorporationIdRouteRequest, List<Offer>>(CorporationIdRouteRequest.Create(corporationId));

        public Task<EsiResponse<List<Points>>> LoyaltyPoints(int characterId) =>
            _esiClient.GetRequestAsync<CharacterIdRouteRequest, List<Points>>(CharacterIdRouteRequest.Create(characterId));
    }
}
