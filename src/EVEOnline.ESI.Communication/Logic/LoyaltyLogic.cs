using System.Collections.Generic;
using System.Threading.Tasks;

using EVEOnline.ESI.Communication.DataContract;

using static EVEOnline.ESI.Communication.Models.CommonRequests;

namespace EVEOnline.ESI.Communication.Logic
{
    internal class LoyaltyLogic : ILoyaltyLogic
    {
        private readonly IEsiHttpClient<ILoyaltyLogic> _esiClient;

        public LoyaltyLogic(IEsiHttpClient<ILoyaltyLogic> esiClient)
        {
            _esiClient = esiClient;
        }

        public Task<EsiResponse<List<Offer>>> GetCorporationOffers(int corporationId) =>
            _esiClient.GetRequestAsync<CorporationIdRouteRequest, List<Offer>>(CorporationIdRouteRequest.Create(corporationId));

        public Task<EsiResponse<List<Points>>> GetLoyaltyPoints(int characterId) =>
            _esiClient.GetRequestAsync<CharacterIdRouteRequest, List<Points>>(CharacterIdRouteRequest.Create(characterId));
    }
}
