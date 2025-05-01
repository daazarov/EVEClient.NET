using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

using EVEClient.NET.DataContract;

namespace EVEClient.NET
{
    public interface ILoyaltyLogic
    {
        /// <summary>
        /// Return a list of loyalty points for all corporations the character has worked for
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        Task<EsiResponse<List<Points>>> LoyaltyPoints(int characterId, string? token = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Return a list of offers from a specific corporation’s loyalty store
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        Task<EsiResponse<List<Offer>>> CorporationOffers(int corporationId, CancellationToken cancellationToken = default);
    }
}
