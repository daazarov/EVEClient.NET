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

        public Task<EsiResponse<Location>> CurrentLocation(int characterId) =>
            _esiClient.GetRequestAsync<CharacterIdRouteRequest, Location>(CharacterIdRouteRequest.Create(characterId));

        public Task<EsiResponse<Activity>> Online(int characterId) =>
            _esiClient.GetRequestAsync<CharacterIdRouteRequest, Activity>(CharacterIdRouteRequest.Create(characterId));

        public Task<EsiResponse<Ship>> CurrentShip(int characterId) =>
            _esiClient.GetRequestAsync<CharacterIdRouteRequest, Ship>(CharacterIdRouteRequest.Create(characterId));
    }
}
