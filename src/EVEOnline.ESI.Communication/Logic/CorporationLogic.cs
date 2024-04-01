using System.Collections.Generic;
using System.Threading.Tasks;

using EVEOnline.ESI.Communication.DataContract;

using static EVEOnline.ESI.Communication.Models.CommonRequests;
using static EVEOnline.ESI.Communication.Models.CorporationRequests;

namespace EVEOnline.ESI.Communication
{
    internal class CorporationLogic : ICorporationLogic
    {
        private readonly IEsiHttpClient<ICorporationLogic> _esiClient;

        public CorporationLogic(IEsiHttpClient<ICorporationLogic> esiClient)
        {
            _esiClient = esiClient;
        }

        public Task<EsiResponse<CorporationInfo>> GetCorporationInfoAsync(int corporationId) =>
            _esiClient.GetRequestAsync<CorporationIdRouteRequest, CorporationInfo>(CorporationIdRouteRequest.Create(corporationId));

        public Task<EsiResponse<List<AllianceHistory>>> GetCorporationAllianceHistoryAsync(int corporationId) =>
            _esiClient.GetRequestAsync<CorporationIdRouteRequest, List<AllianceHistory>>(CorporationIdRouteRequest.Create(corporationId));

        public Task<EsiResponsePagination<List<Blueprint>>> GetCorporationBlueprintsAsync(int corporationId, int page = 1) =>
            _esiClient.GetPaginationRequestAsync<PageBasedCorporationIdRouteRequest, List<Blueprint>>(PageBasedCorporationIdRouteRequest.Create(corporationId, page));

        public Task<EsiResponsePagination<List<ContainerLog>>> GetCorporationContainerLogsAsync(int corporationId, int page = 1) =>
            _esiClient.GetPaginationRequestAsync<PageBasedCorporationIdRouteRequest, List<ContainerLog>>(PageBasedCorporationIdRouteRequest.Create(corporationId, page));

        public Task<EsiResponse<Divisions>> GetCorporationDivisionsAsync(int corporationId) =>
            _esiClient.GetRequestAsync<CorporationIdRouteRequest, Divisions>(CorporationIdRouteRequest.Create(corporationId));

        public Task<EsiResponse<List<Facility>>> GetCorporationFacilitiesAsync(int corporationId) =>
            _esiClient.GetRequestAsync<CorporationIdRouteRequest, List<Facility>>(CorporationIdRouteRequest.Create(corporationId));

        public Task<EsiResponse<CorporationIcon>> GetCorporationIconAsync(int corporationId) =>
            _esiClient.GetRequestAsync<CorporationIdRouteRequest, CorporationIcon>(CorporationIdRouteRequest.Create(corporationId));

        public Task<EsiResponsePagination<List<CorporationMedal>>> GetCorporationMedalsAsync(int corporationId, int page = 1) =>
            _esiClient.GetPaginationRequestAsync<PageBasedCorporationIdRouteRequest, List<CorporationMedal>>(PageBasedCorporationIdRouteRequest.Create(corporationId, page));

        public Task<EsiResponsePagination<List<CorporationIssuedMedal>>> GetCorporationIssuedMedalsAsync(int corporationId, int page = 1) =>
            _esiClient.GetPaginationRequestAsync<PageBasedCorporationIdRouteRequest, List<CorporationIssuedMedal>>(PageBasedCorporationIdRouteRequest.Create(corporationId, page));

        public Task<EsiResponse<List<int>>> GetCorporationMembersAsync(int corporationId) =>
            _esiClient.GetRequestAsync<CorporationIdRouteRequest, List<int>>(CorporationIdRouteRequest.Create(corporationId));

        public Task<EsiResponse<int>> GetCorporationMemberLimitAsync(int corporationId) =>
            _esiClient.GetRequestAsync<CorporationIdRouteRequest, int>(CorporationIdRouteRequest.Create(corporationId));

        public Task<EsiResponse<List<MemberTitle>>> GetCorporationMemberTitlesAsync(int corporationId) =>
            _esiClient.GetRequestAsync<CorporationIdRouteRequest, List<MemberTitle>>(CorporationIdRouteRequest.Create(corporationId));

        public Task<EsiResponse<List<MemberTracking>>> GetCorporationMemberTrackingAsync(int corporationId) =>
            _esiClient.GetRequestAsync<CorporationIdRouteRequest, List<MemberTracking>>(CorporationIdRouteRequest.Create(corporationId));

        public Task<EsiResponse<List<MemberRole>>> GetCorporationMemberRolesAsync(int corporationId) =>
            _esiClient.GetRequestAsync<CorporationIdRouteRequest, List<MemberRole>>(CorporationIdRouteRequest.Create(corporationId));

        public Task<EsiResponsePagination<List<MemberRoleHistory>>> GetCorporationMemberRolesHistoryAsync(int corporationId, int page = 1) =>
            _esiClient.GetPaginationRequestAsync<PageBasedCorporationIdRouteRequest, List<MemberRoleHistory>>(PageBasedCorporationIdRouteRequest.Create(corporationId, page));

        public Task<EsiResponsePagination<List<Shareholder>>> GetCorporationShareholdersAsync(int corporationId, int page = 1) =>
            _esiClient.GetPaginationRequestAsync<PageBasedCorporationIdRouteRequest, List<Shareholder>>(PageBasedCorporationIdRouteRequest.Create(corporationId, page));

        public Task<EsiResponsePagination<List<CorporationStanding>>> GetCorporationStandingsAsync(int corporationId, int page = 1) =>
            _esiClient.GetPaginationRequestAsync<PageBasedCorporationIdRouteRequest, List<CorporationStanding>>(PageBasedCorporationIdRouteRequest.Create(corporationId, page));

        public Task<EsiResponsePagination<List<Starbase>>> GetCorporationStarbasesAsync(int corporationId, int page = 1) =>
            _esiClient.GetPaginationRequestAsync<PageBasedCorporationIdRouteRequest, List<Starbase>>(PageBasedCorporationIdRouteRequest.Create(corporationId, page));

        public Task<EsiResponse<StarbaseInfo>> GetStarbaseInfoAsync(int corporationId, long starbaseId, int systemId) =>
            _esiClient.GetRequestAsync<StarbaseInfoRequest, StarbaseInfo>(StarbaseInfoRequest.Create(corporationId, starbaseId, systemId));

        public Task<EsiResponsePagination<List<Structure>>> GetCorporationStructuresAsync(int corporationId, int page = 1) =>
            _esiClient.GetPaginationRequestAsync<PageBasedCorporationIdRouteRequest, List<Structure>>(PageBasedCorporationIdRouteRequest.Create(corporationId, page));

        public Task<EsiResponse<List<Title>>> GetCorporationTitlesAsync(int corporationId) =>
            _esiClient.GetRequestAsync<CorporationIdRouteRequest, List<Title>>(CorporationIdRouteRequest.Create(corporationId));

        public Task<EsiResponse<List<int>>> GetNpcCorporationsAsync() =>
            _esiClient.GetRequestAsync<List<int>>();
    }
}
