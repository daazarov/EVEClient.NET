using System.Collections.Generic;
using System.Threading.Tasks;

using EVEOnline.ESI.Communication.Attributes;
using EVEOnline.ESI.Communication.DataContract;

namespace EVEOnline.ESI.Communication
{
    public interface ILoyaltyLogic
    {
        /// <summary>
        /// Return a list of loyalty points for all corporations the character has worked for
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        [ProtectedEndpoint(RequiredScope = "esi-characters.read_loyalty.v1")]
        [Route("/latest/characters/{character_id}/loyalty/points/", Version = EndpointVersion.Latest)]
        [Route("/legacy/characters/{character_id}/loyalty/points/", Version = EndpointVersion.Legacy)]
        [Route("/v1/characters/{character_id}/loyalty/points/", Version = EndpointVersion.V1, Preferred = true)]
        [Route("/dev/characters/{character_id}/loyalty/points/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<List<Points>>> LoyaltyPoints(int characterId);

        /// <summary>
        /// Return a list of offers from a specific corporation’s loyalty store
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        [PublicEndpoint]
        [Route("/latest/loyalty/stores/{corporation_id}/offers/", Version = EndpointVersion.Latest)]
        [Route("/legacy/loyalty/stores/{corporation_id}/offers/", Version = EndpointVersion.Legacy)]
        [Route("/v1/loyalty/stores/{corporation_id}/offers/", Version = EndpointVersion.V1, Preferred = true)]
        [Route("/dev/loyalty/stores/{corporation_id}/offers/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<List<Offer>>> CorporationOffers(int corporationId);
    }
}
