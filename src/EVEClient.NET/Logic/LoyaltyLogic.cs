using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

using EVEClient.NET.DataContract;
using EVEClient.NET.Extensions;
using EVEClient.NET.Requests;

namespace EVEClient.NET.Logic
{
    internal class LoyaltyLogic : ILoyaltyLogic
    {
        private readonly IEsiHttpClient _client;
        private readonly IEsiRequestFactory _esiRequestFactory;

        public LoyaltyLogic(IEsiHttpClient client, IEsiRequestFactory esiRequestFactory)
        {
            _client = client;
            _esiRequestFactory = esiRequestFactory;
        }

        public async Task<EsiResponse<List<Offer>>> CorporationOffers(int corporationId, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.CorporationId] = corporationId.ToString();
                });

            var response = await _client.Request(ESI.Endpoints.Loyalty.CorporationOffers, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<List<Offer>>();
        }

        public async Task<EsiResponse<List<Points>>> LoyaltyPoints(int characterId, string? token = null, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.CharacterId] = characterId.ToString();
                },
                token: token);

            var response = await _client.Request(ESI.Endpoints.Loyalty.LoyaltyPoints, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<List<Points>>();
        }
    }
}
