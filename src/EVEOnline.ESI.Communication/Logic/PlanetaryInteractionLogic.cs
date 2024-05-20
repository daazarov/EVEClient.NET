﻿using System.Collections.Generic;
using System.Threading.Tasks;

using EVEOnline.ESI.Communication.DataContract;

using static EVEOnline.ESI.Communication.Models.CommonRequests;
using static EVEOnline.ESI.Communication.Models.PlanetaryInteractionRequests;

namespace EVEOnline.ESI.Communication.Logic
{
    internal class PlanetaryInteractionLogic : IPlanetaryInteractionLogic
    {
        private readonly IEsiHttpClient<IPlanetaryInteractionLogic> _esiClient;

        public PlanetaryInteractionLogic(IEsiHttpClient<IPlanetaryInteractionLogic> esiClient)
        {
            _esiClient = esiClient;
        }

        public Task<EsiResponse<List<Colony>>> Colonies(int characterId) =>
            _esiClient.GetRequestAsync<CharacterIdRouteRequest, List<Colony>>(CharacterIdRouteRequest.Create(characterId));

        public Task<EsiResponse<ColonyLayout>> ColonyInfo(int characterId, int planetId) =>
            _esiClient.GetRequestAsync<ColonyInfoRequest, ColonyLayout>(ColonyInfoRequest.Create(characterId, planetId));

        public Task<EsiResponsePagination<List<CustomOffice>>> CorporationCustomOffices(int corporationId, int page = 1) =>
            _esiClient.GetPaginationRequestAsync<PageBasedCorporationIdRouteRequest, List<CustomOffice>>(PageBasedCorporationIdRouteRequest.Create(corporationId, page));

        public Task<EsiResponse<SchematicInfo>> SchematicInfo(int schematicId) =>
            _esiClient.GetRequestAsync<SchematicInfoRequest, SchematicInfo>(SchematicInfoRequest.Create(schematicId));
    }
}
