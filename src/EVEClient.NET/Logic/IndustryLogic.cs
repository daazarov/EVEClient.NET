using System.Collections.Generic;
using System.Threading.Tasks;

using EVEClient.NET.DataContract;

using static EVEClient.NET.Models.CommonRequests;
using static EVEClient.NET.Models.IndustryRequests;

namespace EVEClient.NET.Logic
{
    internal class IndustryLogic : IIndustryLogic
    {
        private readonly IEsiHttpClient<IIndustryLogic> _esiClient;

        public IndustryLogic(IEsiHttpClient<IIndustryLogic> esiClient)
        {
            _esiClient = esiClient;
        }

        public Task<EsiResponse<List<CharacterIndustryJob>>> CharacterJobs(int characterId, bool includeCompleted = false, string? token = null) =>
            _esiClient.GetRequestAsync<CharacterJobsRequest, List<CharacterIndustryJob>>(CharacterJobsRequest.Create(characterId, includeCompleted), token);

        public Task<EsiResponsePagination<List<Mining>>> CharacterMiningLedger(int characterId, int page = 1, string? token = null) =>
            _esiClient.GetPaginationRequestAsync<PageBasedCharacterIdRouteRequest, List<Mining>>(PageBasedCharacterIdRouteRequest.Create(characterId, page), token);

        public Task<EsiResponsePagination<List<Extraction>>> ExtractionTimers(int corporation, int page = 1, string? token = null) =>
            _esiClient.GetPaginationRequestAsync<PageBasedCorporationIdRouteRequest, List<Extraction>>(PageBasedCorporationIdRouteRequest.Create(corporation, page), token);

        public Task<EsiResponsePagination<List<CorporationIndustryJob>>> CorporationJobs(int corporationId, bool includeCompleted = false, int page = 1, string? token = null) =>
            _esiClient.GetPaginationRequestAsync<CorporationJobsRequest, List<CorporationIndustryJob>>(CorporationJobsRequest.Create(corporationId, includeCompleted, page), token);

        public Task<EsiResponsePagination<List<ObserverInfo>>> ObserverInfo(int corporation, long observerId, int page = 1, string? token = null) =>
            _esiClient.GetPaginationRequestAsync<CorporationObserverRequest, List<ObserverInfo>>(CorporationObserverRequest.Create(corporation, observerId, page), token);

        public Task<EsiResponsePagination<List<Observer>>> CorporationObservers(int corporation, int page = 1, string? token = null) =>
            _esiClient.GetPaginationRequestAsync<PageBasedCorporationIdRouteRequest, List<Observer>>(PageBasedCorporationIdRouteRequest.Create(corporation, page), token);

        public Task<EsiResponse<List<IndustryFacility>>> Facilities() =>
            _esiClient.GetRequestAsync<List<IndustryFacility>>();

        public Task<EsiResponse<List<SolarSystem>>> SolarSystems() =>
            _esiClient.GetRequestAsync<List<SolarSystem>>();
    }
}
