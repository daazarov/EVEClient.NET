using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

using EVEClient.NET.DataContract;
using EVEClient.NET.Extensions;
using EVEClient.NET.Requests;

namespace EVEClient.NET.Logic
{
    internal class ContractsLogic : IContractsLogic
    {
        private readonly IEsiHttpClient _client;
        private readonly IEsiRequestFactory _esiRequestFactory;

        public ContractsLogic(IEsiHttpClient client, IEsiRequestFactory esiRequestFactory)
        {
            _client = client;
            _esiRequestFactory = esiRequestFactory;
        }

        public async Task<EsiResponsePagination<List<Contract>>> CharacterContracts(int characterId, int page = 1, string? token = null, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.CharacterId] = characterId.ToString();
                    parameters.Query[ESI.Parameters.Query.Page] = page.ToString();
                },
                token: token);

            var response = await _client.Request(ESI.Endpoints.Contracts.CharacterContracts, request, cancellationToken: cancellationToken);

            return await response.ReadPaginatedEsiResponse<List<Contract>>();
        }

        public async Task<EsiResponse<List<Bid>>> CharacterContractBids(int characterId, int contractId, string? token = null, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.CharacterId] = characterId.ToString();
                    parameters.Route[ESI.Parameters.Route.ContractId] = contractId.ToString();
                },
                token: token);

            var response = await _client.Request(ESI.Endpoints.Contracts.CharacterContractBids, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<List<Bid>>();
        }

        public async Task<EsiResponse<List<ContractItem>>> CharacterContractItems(int characterId, int contractId, string? token = null, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.CharacterId] = characterId.ToString();
                    parameters.Route[ESI.Parameters.Route.ContractId] = contractId.ToString();
                },
                token: token);

            var response = await _client.Request(ESI.Endpoints.Contracts.CharacterContractItems, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<List<ContractItem>>();
        }

        public async Task<EsiResponsePagination<List<PublicContract>>> PublicContracts(int regionId, int page = 1, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.RegionId] = regionId.ToString();
                    parameters.Query[ESI.Parameters.Query.Page] = page.ToString();
                });

            var response = await _client.Request(ESI.Endpoints.Contracts.PublicContracts, request, cancellationToken: cancellationToken);

            return await response.ReadPaginatedEsiResponse<List<PublicContract>>();
        }

        public async Task<EsiResponsePagination<List<Bid>>> PublicContractBids(int contractId, int page = 1, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.ContractId] = contractId.ToString();
                    parameters.Query[ESI.Parameters.Query.Page] = page.ToString();
                });

            var response = await _client.Request(ESI.Endpoints.Contracts.PublicContractBids, request, cancellationToken: cancellationToken);

            return await response.ReadPaginatedEsiResponse<List<Bid>>();
        }

        public async Task<EsiResponsePagination<List<ContractItem>>> PublicContractItems(int contractId, int page = 1, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.ContractId] = contractId.ToString();
                    parameters.Query[ESI.Parameters.Query.Page] = page.ToString();
                });

            var response = await _client.Request(ESI.Endpoints.Contracts.PublicContractItems, request, cancellationToken: cancellationToken);

            return await response.ReadPaginatedEsiResponse<List<ContractItem>>();
        }

        public async Task<EsiResponsePagination<List<Contract>>> CorporationContracts(int corporationId, int page = 1, string? token = null, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.CorporationId] = corporationId.ToString();
                    parameters.Query[ESI.Parameters.Query.Page] = page.ToString();
                },
                token: token);

            var response = await _client.Request(ESI.Endpoints.Contracts.CorporationContracts, request, cancellationToken: cancellationToken);

            return await response.ReadPaginatedEsiResponse<List<Contract>>();
        }

        public async Task<EsiResponsePagination<List<Bid>>> CorporationContractBids(int corporationId, int contractId, int page = 1, string? token = null, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.CorporationId] = corporationId.ToString();
                    parameters.Route[ESI.Parameters.Route.ContractId] = contractId.ToString();
                    parameters.Query[ESI.Parameters.Query.Page] = page.ToString();
                },
                token: token);

            var response = await _client.Request(ESI.Endpoints.Contracts.CorporationContractBids, request, cancellationToken: cancellationToken);

            return await response.ReadPaginatedEsiResponse<List<Bid>>();
        }

        public async Task<EsiResponse<List<ContractItem>>> CorporationContractItems(int corporationId, int contractId, string? token = null, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.CorporationId] = corporationId.ToString();
                    parameters.Route[ESI.Parameters.Route.ContractId] = contractId.ToString();
                },
                token: token);

            var response = await _client.Request(ESI.Endpoints.Contracts.CorporationContractItems, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<List<ContractItem>>();
        }
    }
}
