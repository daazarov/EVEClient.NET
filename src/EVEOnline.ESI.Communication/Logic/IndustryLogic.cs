using System.Collections.Generic;
using System.Threading.Tasks;

using EVEOnline.ESI.Communication.DataContract;

using static EVEOnline.ESI.Communication.Models.IndustryRequests;

namespace EVEOnline.ESI.Communication.Logic
{
    internal class IndustryLogic : IIndustryLogic
    {
        private readonly IEsiHttpClient<IIndustryLogic> _esiClient;

        public IndustryLogic(IEsiHttpClient<IIndustryLogic> esiClient)
        {
            _esiClient = esiClient;
        }

        public Task<EsiResponse<List<CharacterIndustryJob>>> GetCharacterInductryJobsAsync(int characterId, bool includeCompleted = false) =>
            _esiClient.GetRequestAsync<CharacterJobsRequest, List<CharacterIndustryJob>>(CharacterJobsRequest.Create(characterId, includeCompleted));

        public Task<EsiResponsePagination<List<Mining>>> GetCharacterMiningLedgerAsync(int characterId, int page = 1) =>
            _esiClient.GetPaginationRequestAsync<PageBasedCharacterIdRouteRequest, List<Mining>>(PageBasedCharacterIdRouteRequest.Create(characterId, page));

        public Task<EsiResponsePagination<List<Extraction>>> GetCorporationExtractionTimersAsync(int corporation, int page = 1) =>
            _esiClient.GetPaginationRequestAsync<PageBasedCorporationIdRouteRequest, List<Extraction>>(PageBasedCorporationIdRouteRequest.Create(corporation, page));

        public Task<EsiResponsePagination<List<CorporationIndustryJob>>> GetCorporationInductryJobsAsync(int corporationId, bool includeCompleted = false, int page = 1) =>
            _esiClient.GetPaginationRequestAsync<CorporationJobsRequest, List<CorporationIndustryJob>>(CorporationJobsRequest.Create(corporationId, includeCompleted, page));

        public Task<EsiResponsePagination<List<ObserverInfo>>> GetCorporationObserverInfoAsync(int corporation, long observerId, int page = 1) =>
            _esiClient.GetPaginationRequestAsync<CorporationObserverRequest, List<ObserverInfo>>(CorporationObserverRequest.Create(corporation, observerId, page));

        public Task<EsiResponsePagination<List<Observer>>> GetCorporationObserversAsync(int corporation, int page = 1) =>
            _esiClient.GetPaginationRequestAsync<PageBasedCorporationIdRouteRequest, List<Observer>>(PageBasedCorporationIdRouteRequest.Create(corporation, page));

        public Task<EsiResponse<List<IndustryFacility>>> GetIndustryFacilitiesAsync() =>
            _esiClient.GetRequestAsync<List<IndustryFacility>>();

        public Task<EsiResponse<List<SolarSystem>>> GetSolarSystemCostIndicesAsync() =>
            _esiClient.GetRequestAsync<List<SolarSystem>>();
    }
}
