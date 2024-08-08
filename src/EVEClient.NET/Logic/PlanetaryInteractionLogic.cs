using System.Collections.Generic;
using System.Threading.Tasks;

using EVEClient.NET.DataContract;

using static EVEClient.NET.Models.CommonRequests;
using static EVEClient.NET.Models.PlanetaryInteractionRequests;

namespace EVEClient.NET.Logic
{
    internal class PlanetaryInteractionLogic : IPlanetaryInteractionLogic
    {
        private readonly IEsiHttpClient<IPlanetaryInteractionLogic> _esiClient;

        public PlanetaryInteractionLogic(IEsiHttpClient<IPlanetaryInteractionLogic> esiClient)
        {
            _esiClient = esiClient;
        }

        public Task<EsiResponse<List<Colony>>> Colonies(int characterId, string? token = null) =>
            _esiClient.GetRequestAsync<CharacterIdRouteRequest, List<Colony>>(CharacterIdRouteRequest.Create(characterId), token);

        public Task<EsiResponse<ColonyLayout>> ColonyInfo(int characterId, int planetId, string? token = null) =>
            _esiClient.GetRequestAsync<ColonyInfoRequest, ColonyLayout>(ColonyInfoRequest.Create(characterId, planetId), token);

        public Task<EsiResponsePagination<List<CustomOffice>>> CorporationCustomOffices(int corporationId, int page = 1, string? token = null) =>
            _esiClient.GetPaginationRequestAsync<PageBasedCorporationIdRouteRequest, List<CustomOffice>>(PageBasedCorporationIdRouteRequest.Create(corporationId, page), token);

        public Task<EsiResponse<SchematicInfo>> SchematicInfo(int schematicId) =>
            _esiClient.GetRequestAsync<SchematicInfoRequest, SchematicInfo>(SchematicInfoRequest.Create(schematicId));
    }
}
