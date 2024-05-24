using System.Collections.Generic;
using System.Threading.Tasks;

using EVEClient.NET.DataContract;

using static EVEClient.NET.Models.CommonRequests;
using static EVEClient.NET.Models.CorporationRequests;

namespace EVEClient.NET
{
    internal class CorporationLogic : ICorporationLogic
    {
        private readonly IEsiHttpClient<ICorporationLogic> _esiClient;

        public CorporationLogic(IEsiHttpClient<ICorporationLogic> esiClient)
        {
            _esiClient = esiClient;
        }

        public Task<EsiResponse<CorporationInfo>> Information(int corporationId) =>
            _esiClient.GetRequestAsync<CorporationIdRouteRequest, CorporationInfo>(CorporationIdRouteRequest.Create(corporationId));

        public Task<EsiResponse<List<AllianceHistory>>> AllianceHistory(int corporationId) =>
            _esiClient.GetRequestAsync<CorporationIdRouteRequest, List<AllianceHistory>>(CorporationIdRouteRequest.Create(corporationId));

        public Task<EsiResponsePagination<List<Blueprint>>> Blueprints(int corporationId, int page = 1) =>
            _esiClient.GetPaginationRequestAsync<PageBasedCorporationIdRouteRequest, List<Blueprint>>(PageBasedCorporationIdRouteRequest.Create(corporationId, page));

        public Task<EsiResponsePagination<List<ContainerLog>>> ContainersLogs(int corporationId, int page = 1) =>
            _esiClient.GetPaginationRequestAsync<PageBasedCorporationIdRouteRequest, List<ContainerLog>>(PageBasedCorporationIdRouteRequest.Create(corporationId, page));

        public Task<EsiResponse<Divisions>> Divisions(int corporationId) =>
            _esiClient.GetRequestAsync<CorporationIdRouteRequest, Divisions>(CorporationIdRouteRequest.Create(corporationId));

        public Task<EsiResponse<List<Facility>>> Facilities(int corporationId) =>
            _esiClient.GetRequestAsync<CorporationIdRouteRequest, List<Facility>>(CorporationIdRouteRequest.Create(corporationId));

        public Task<EsiResponse<CorporationIcon>> Icons(int corporationId) =>
            _esiClient.GetRequestAsync<CorporationIdRouteRequest, CorporationIcon>(CorporationIdRouteRequest.Create(corporationId));

        public Task<EsiResponsePagination<List<CorporationMedal>>> Medals(int corporationId, int page = 1) =>
            _esiClient.GetPaginationRequestAsync<PageBasedCorporationIdRouteRequest, List<CorporationMedal>>(PageBasedCorporationIdRouteRequest.Create(corporationId, page));

        public Task<EsiResponsePagination<List<CorporationIssuedMedal>>> IssuedMedals(int corporationId, int page = 1) =>
            _esiClient.GetPaginationRequestAsync<PageBasedCorporationIdRouteRequest, List<CorporationIssuedMedal>>(PageBasedCorporationIdRouteRequest.Create(corporationId, page));

        public Task<EsiResponse<List<int>>> Members(int corporationId) =>
            _esiClient.GetRequestAsync<CorporationIdRouteRequest, List<int>>(CorporationIdRouteRequest.Create(corporationId));

        public Task<EsiResponse<int>> MembersLimit(int corporationId) =>
            _esiClient.GetRequestAsync<CorporationIdRouteRequest, int>(CorporationIdRouteRequest.Create(corporationId));

        public Task<EsiResponse<List<MemberTitle>>> MembersTitles(int corporationId) =>
            _esiClient.GetRequestAsync<CorporationIdRouteRequest, List<MemberTitle>>(CorporationIdRouteRequest.Create(corporationId));

        public Task<EsiResponse<List<MemberTracking>>> MemberTracking(int corporationId) =>
            _esiClient.GetRequestAsync<CorporationIdRouteRequest, List<MemberTracking>>(CorporationIdRouteRequest.Create(corporationId));

        public Task<EsiResponse<List<MemberRole>>> Roles(int corporationId) =>
            _esiClient.GetRequestAsync<CorporationIdRouteRequest, List<MemberRole>>(CorporationIdRouteRequest.Create(corporationId));

        public Task<EsiResponsePagination<List<MemberRoleHistory>>> RolesHistory(int corporationId, int page = 1) =>
            _esiClient.GetPaginationRequestAsync<PageBasedCorporationIdRouteRequest, List<MemberRoleHistory>>(PageBasedCorporationIdRouteRequest.Create(corporationId, page));

        public Task<EsiResponsePagination<List<Shareholder>>> Shareholders(int corporationId, int page = 1) =>
            _esiClient.GetPaginationRequestAsync<PageBasedCorporationIdRouteRequest, List<Shareholder>>(PageBasedCorporationIdRouteRequest.Create(corporationId, page));

        public Task<EsiResponsePagination<List<CorporationStanding>>> Standings(int corporationId, int page = 1) =>
            _esiClient.GetPaginationRequestAsync<PageBasedCorporationIdRouteRequest, List<CorporationStanding>>(PageBasedCorporationIdRouteRequest.Create(corporationId, page));

        public Task<EsiResponsePagination<List<Starbase>>> Starbases(int corporationId, int page = 1) =>
            _esiClient.GetPaginationRequestAsync<PageBasedCorporationIdRouteRequest, List<Starbase>>(PageBasedCorporationIdRouteRequest.Create(corporationId, page));

        public Task<EsiResponse<StarbaseInfo>> StarbaseInfo(int corporationId, long starbaseId, int systemId) =>
            _esiClient.GetRequestAsync<StarbaseInfoRequest, StarbaseInfo>(StarbaseInfoRequest.Create(corporationId, starbaseId, systemId));

        public Task<EsiResponsePagination<List<Structure>>> Structures(int corporationId, int page = 1) =>
            _esiClient.GetPaginationRequestAsync<PageBasedCorporationIdRouteRequest, List<Structure>>(PageBasedCorporationIdRouteRequest.Create(corporationId, page));

        public Task<EsiResponse<List<Title>>> Titles(int corporationId) =>
            _esiClient.GetRequestAsync<CorporationIdRouteRequest, List<Title>>(CorporationIdRouteRequest.Create(corporationId));

        public Task<EsiResponse<List<int>>> NpcCorporations() =>
            _esiClient.GetRequestAsync<List<int>>();
    }
}
