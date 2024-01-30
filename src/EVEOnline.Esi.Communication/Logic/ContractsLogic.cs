using System.Collections.Generic;
using System.Threading.Tasks;

using EVEOnline.Esi.Communication.DataContract;

using static EVEOnline.Esi.Communication.DataContract.Requests.Internal.ContractRequests;

namespace EVEOnline.Esi.Communication.Logic
{
    internal class ContractsLogic : IContractsLogic
    {
        private readonly IEsiHttpClient<IContractsLogic> _esiClient;

        public ContractsLogic(IEsiHttpClient<IContractsLogic> esiClient)
        {
            _esiClient = esiClient;
        }

        public Task<EsiResponsePagination<List<Contract>>> GetCharacterContractsAsync(int characterId, int page = 1) =>
            _esiClient.GetPaginationRequestAsync<PageBasedCharacterIdRouteRequest, List<Contract>>(PageBasedCharacterIdRouteRequest.Create(characterId, page));

        public Task<EsiResponse<List<Bid>>> GetCharacterContractBidsAsync(int characterId, int contractId) =>
            _esiClient.GetRequestAsync<CharacterContractRouteRequest, List<Bid>>(CharacterContractRouteRequest.Create(characterId, contractId));

        public Task<EsiResponse<List<ContractItem>>> GetCharacterContractItemsAsync(int characterId, int contractId) =>
            _esiClient.GetRequestAsync<CharacterContractRouteRequest, List<ContractItem>>(CharacterContractRouteRequest.Create(characterId, contractId));

        public Task<EsiResponsePagination<List<PublicContract>>> GetPublicContractsAsync(int regionId, int page = 1) =>
            _esiClient.GetPaginationRequestAsync<PageBasedRegionIdRouteRequest, List<PublicContract>>(PageBasedRegionIdRouteRequest.Create(regionId, page));

        public Task<EsiResponsePagination<List<Bid>>> GetPublicContractBidsAsync(int contractId, int page = 1) =>
            _esiClient.GetPaginationRequestAsync<PageBasedContractIdRouteRequest, List<Bid>>(PageBasedContractIdRouteRequest.Create(contractId, page));

        public Task<EsiResponsePagination<List<ContractItem>>> GetPublicContractItemsAsync(int contractId, int page = 1) =>
            _esiClient.GetPaginationRequestAsync<PageBasedContractIdRouteRequest, List<ContractItem>>(PageBasedContractIdRouteRequest.Create(contractId, page));

        public Task<EsiResponsePagination<List<Contract>>> GetCorporationContractsAsync(int corporationId, int page = 1) =>
            _esiClient.GetPaginationRequestAsync<PageBasedCorporationIdRouteRequest, List<Contract>>(PageBasedCorporationIdRouteRequest.Create(corporationId, page));

        public Task<EsiResponsePagination<List<Bid>>> GetCorporationContractsBidsAsync(int corporationId, int contractId, int page = 1) =>
            _esiClient.GetPaginationRequestAsync<PageBasedCorporationContractRouteRequest, List<Bid>>(PageBasedCorporationContractRouteRequest.Create(corporationId, contractId, page));

        public Task<EsiResponse<List<ContractItem>>> GetCorporationContractItemsAsync(int corporationId, int contractId) =>
            _esiClient.GetRequestAsync<CorporationContractRouteRequest, List<ContractItem>>(CorporationContractRouteRequest.Create(corporationId, contractId));
    }
}
