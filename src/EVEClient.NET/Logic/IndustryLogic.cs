using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

using EVEClient.NET.DataContract;
using EVEClient.NET.Requests;
using static EVEClient.NET.Models.CommonRequests;
using static EVEClient.NET.Models.IndustryRequests;

namespace EVEClient.NET.Logic
{
    internal class IndustryLogic : IIndustryLogic
    {
        private readonly IEsiHttpClient _client;
        private readonly IEsiRequestFactory _esiRequestFactory;

        public IndustryLogic(IEsiHttpClient client, IEsiRequestFactory esiRequestFactory)
        {
            _client = client;
            _esiRequestFactory = esiRequestFactory;
        }

        public async Task<EsiResponse<List<CharacterIndustryJob>>> CharacterJobs(int characterId, bool includeCompleted = false, string? token = null, CancellationToken cancellationToken = default) =>
            _client.GetRequestAsync<CharacterJobsRequest, List<CharacterIndustryJob>>(CharacterJobsRequest.Create(characterId, includeCompleted), token);

        public async Task<EsiResponsePagination<List<Mining>>> CharacterMiningLedger(int characterId, int page = 1, string? token = null, CancellationToken cancellationToken = default) =>
            _client.GetPaginationRequestAsync<PageBasedCharacterIdRouteRequest, List<Mining>>(PageBasedCharacterIdRouteRequest.Create(characterId, page), token);

        public async Task<EsiResponsePagination<List<Extraction>>> ExtractionTimers(int corporation, int page = 1, string? token = null, CancellationToken cancellationToken = default) =>
            _client.GetPaginationRequestAsync<PageBasedCorporationIdRouteRequest, List<Extraction>>(PageBasedCorporationIdRouteRequest.Create(corporation, page), token);

        public async Task<EsiResponsePagination<List<CorporationIndustryJob>>> CorporationJobs(int corporationId, bool includeCompleted = false, int page = 1, string? token = null, CancellationToken cancellationToken = default) =>
            _client.GetPaginationRequestAsync<CorporationJobsRequest, List<CorporationIndustryJob>>(CorporationJobsRequest.Create(corporationId, includeCompleted, page), token);

        public async Task<EsiResponsePagination<List<ObserverInfo>>> ObserverInfo(int corporation, long observerId, int page = 1, string? token = null, CancellationToken cancellationToken = default) =>
            _client.GetPaginationRequestAsync<CorporationObserverRequest, List<ObserverInfo>>(CorporationObserverRequest.Create(corporation, observerId, page), token);

        public async Task<EsiResponsePagination<List<Observer>>> CorporationObservers(int corporation, int page = 1, string? token = null, CancellationToken cancellationToken = default) =>
            _client.GetPaginationRequestAsync<PageBasedCorporationIdRouteRequest, List<Observer>>(PageBasedCorporationIdRouteRequest.Create(corporation, page), token);

        public async Task<EsiResponse<List<IndustryFacility>>> Facilities(CancellationToken cancellationToken = default) =>
            _client.GetRequestAsync<List<IndustryFacility>>();

        public async Task<EsiResponse<List<SolarSystem>>> SolarSystems(CancellationToken cancellationToken = default) =>
            _client.GetRequestAsync<List<SolarSystem>>();
    }
}
