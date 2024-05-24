using System.Collections.Generic;
using System.Threading.Tasks;

using EVEClient.NET.DataContract;

using static EVEClient.NET.Models.CommonRequests;
using static EVEClient.NET.Models.ContractRequests;

namespace EVEClient.NET.Logic
{
    internal class ContractsLogic : IContractsLogic
    {
        private readonly IEsiHttpClient<IContractsLogic> _esiClient;

        public ContractsLogic(IEsiHttpClient<IContractsLogic> esiClient)
        {
            _esiClient = esiClient;
        }

        public Task<EsiResponsePagination<List<Contract>>> CharacterContracts(int characterId, int page = 1) =>
            _esiClient.GetPaginationRequestAsync<PageBasedCharacterIdRouteRequest, List<Contract>>(PageBasedCharacterIdRouteRequest.Create(characterId, page));

        public Task<EsiResponse<List<Bid>>> CharacterContractBids(int characterId, int contractId) =>
            _esiClient.GetRequestAsync<CharacterContractRouteRequest, List<Bid>>(CharacterContractRouteRequest.Create(characterId, contractId));

        public Task<EsiResponse<List<ContractItem>>> CharacterContractItems(int characterId, int contractId) =>
            _esiClient.GetRequestAsync<CharacterContractRouteRequest, List<ContractItem>>(CharacterContractRouteRequest.Create(characterId, contractId));

        public Task<EsiResponsePagination<List<PublicContract>>> PublicContracts(int regionId, int page = 1) =>
            _esiClient.GetPaginationRequestAsync<PageBasedRegionIdRouteRequest, List<PublicContract>>(PageBasedRegionIdRouteRequest.Create(regionId, page));

        public Task<EsiResponsePagination<List<Bid>>> PublicContractBids(int contractId, int page = 1) =>
            _esiClient.GetPaginationRequestAsync<PageBasedContractIdRouteRequest, List<Bid>>(PageBasedContractIdRouteRequest.Create(contractId, page));

        public Task<EsiResponsePagination<List<ContractItem>>> PublicContractItems(int contractId, int page = 1) =>
            _esiClient.GetPaginationRequestAsync<PageBasedContractIdRouteRequest, List<ContractItem>>(PageBasedContractIdRouteRequest.Create(contractId, page));

        public Task<EsiResponsePagination<List<Contract>>> CorporationContracts(int corporationId, int page = 1) =>
            _esiClient.GetPaginationRequestAsync<PageBasedCorporationIdRouteRequest, List<Contract>>(PageBasedCorporationIdRouteRequest.Create(corporationId, page));

        public Task<EsiResponsePagination<List<Bid>>> CorporationContractBids(int corporationId, int contractId, int page = 1) =>
            _esiClient.GetPaginationRequestAsync<PageBasedCorporationContractRouteRequest, List<Bid>>(PageBasedCorporationContractRouteRequest.Create(corporationId, contractId, page));

        public Task<EsiResponse<List<ContractItem>>> CorporationContractItems(int corporationId, int contractId) =>
            _esiClient.GetRequestAsync<CorporationContractRouteRequest, List<ContractItem>>(CorporationContractRouteRequest.Create(corporationId, contractId));
    }
}
