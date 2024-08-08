using System.Threading.Tasks;

using EVEClient.NET.DataContract;

using static EVEClient.NET.Models.CommonRequests;

namespace EVEClient.NET.Logic
{
    internal class LocationLogic : ILocationLogic
    {
        private readonly IEsiHttpClient<ILocationLogic> _esiClient;

        public LocationLogic(IEsiHttpClient<ILocationLogic> esiClient)
        {
            _esiClient = esiClient;
        }

        public Task<EsiResponse<Location>> CurrentLocation(int characterId, string? token = null) =>
            _esiClient.GetRequestAsync<CharacterIdRouteRequest, Location>(CharacterIdRouteRequest.Create(characterId), token);

        public Task<EsiResponse<Activity>> Online(int characterId, string? token = null) =>
            _esiClient.GetRequestAsync<CharacterIdRouteRequest, Activity>(CharacterIdRouteRequest.Create(characterId), token);

        public Task<EsiResponse<Ship>> CurrentShip(int characterId, string? token = null) =>
            _esiClient.GetRequestAsync<CharacterIdRouteRequest, Ship>(CharacterIdRouteRequest.Create(characterId), token);
    }
}
