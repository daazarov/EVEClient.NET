using System.Threading;
using System.Threading.Tasks;

using EVEClient.NET.DataContract;
using EVEClient.NET.Extensions;
using EVEClient.NET.Requests;

namespace EVEClient.NET.Logic
{
    internal class LocationLogic : ILocationLogic
    {
        private readonly IEsiHttpClient _client;
        private readonly IEsiRequestFactory _esiRequestFactory;

        public LocationLogic(IEsiHttpClient client, IEsiRequestFactory esiRequestFactory)
        {
            _client = client;
            _esiRequestFactory = esiRequestFactory;
        }

        public async Task<EsiResponse<Location>> CurrentLocation(int characterId, string? token = null, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
               configure: parameters =>
               {
                   parameters.Route[ESI.Parameters.Route.CharacterId] = characterId.ToString();
               },
            token: token);

            var response = await _client.Request(ESI.Endpoints.Location.CurrentLocation, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<Location>();
        }

        public async Task<EsiResponse<Activity>> Online(int characterId, string? token = null, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
               configure: parameters =>
               {
                   parameters.Route[ESI.Parameters.Route.CharacterId] = characterId.ToString();
               },
            token: token);

            var response = await _client.Request(ESI.Endpoints.Location.Online, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<Activity>();
        }

        public async Task<EsiResponse<Ship>> CurrentShip(int characterId, string? token = null, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
               configure: parameters =>
               {
                   parameters.Route[ESI.Parameters.Route.CharacterId] = characterId.ToString();
               },
            token: token);

            var response = await _client.Request(ESI.Endpoints.Location.CurrentShip, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<Ship>();
        }
    }
}
