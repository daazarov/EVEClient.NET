﻿using System.Collections.Generic;
using System.Threading.Tasks;
using EVEClient.NET.Attributes;
using EVEClient.NET.DataContract;

namespace EVEClient.NET
{
    public interface IContractsLogic
    {
        /// <summary>
        /// Returns contracts available to a character, only if the character is issuer, acceptor or assignee.
        /// Only returns contracts no older than 30 days, or if the status is "in_progress".
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="page">Which page of results to return. Default value: 1</param>
        [ProtectedEndpoint(RequiredScope = "esi-contracts.read_character_contracts.v1")]
        [Route("/latest/characters/{character_id}/contracts/", Version = EndpointVersion.Latest)]
        [Route("/legacy/characters/{character_id}/contracts/", Version = EndpointVersion.Legacy)]
        [Route("/v1/characters/{character_id}/contracts/", Version = EndpointVersion.V1, Preferred = true)]
        [Route("/dev/characters/{character_id}/contracts/", Version = EndpointVersion.Dev)]
        Task<EsiResponsePagination<List<Contract>>> CharacterContracts(int characterId, int page = 1, string? token = null);

        /// <summary>
        /// Lists bids on a particular auction contract
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="contractId">ID of a contract</param>
        [ProtectedEndpoint(RequiredScope = "esi-contracts.read_character_contracts.v1")]
        [Route("/latest/characters/{character_id}/contracts/{contract_id}/bids/", Version = EndpointVersion.Latest)]
        [Route("/legacy/characters/{character_id}/contracts/{contract_id}/bids/", Version = EndpointVersion.Legacy)]
        [Route("/v1/characters/{character_id}/contracts/{contract_id}/bids/", Version = EndpointVersion.V1, Preferred = true)]
        [Route("/dev/characters/{character_id}/contracts/{contract_id}/bids/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<List<Bid>>> CharacterContractBids(int characterId, int contractId, string? token = null);

        /// <summary>
        /// Lists items of a particular contract
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="contractId">ID of a contract</param>
        [ProtectedEndpoint(RequiredScope = "esi-contracts.read_character_contracts.v1")]
        [Route("/latest/characters/{character_id}/contracts/{contract_id}/items/", Version = EndpointVersion.Latest)]
        [Route("/legacy/characters/{character_id}/contracts/{contract_id}/items/", Version = EndpointVersion.Legacy)]
        [Route("/v1/characters/{character_id}/contracts/{contract_id}/items/", Version = EndpointVersion.V1, Preferred = true)]
        [Route("/dev/characters/{character_id}/contracts/{contract_id}/items/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<List<ContractItem>>> CharacterContractItems(int characterId, int contractId, string? token = null);

        /// <summary>
        /// Returns a paginated list of all public contracts in the given region
        /// </summary>
        /// <param name="regionId">An EVE region id</param>
        /// <param name="page">Which page of results to return. Default value: 1</param>
        [PublicEndpoint]
        [Route("/latest/contracts/public/{region_id}/", Version = EndpointVersion.Latest)]
        [Route("/legacy/contracts/public/{region_id}/", Version = EndpointVersion.Legacy)]
        [Route("/v1/contracts/public/{region_id}/", Version = EndpointVersion.V1, Preferred = true)]
        [Route("/dev/contracts/public/{region_id}/", Version = EndpointVersion.Dev)]
        Task<EsiResponsePagination<List<PublicContract>>> PublicContracts(int regionId, int page = 1);

        /// <summary>
        /// Lists bids on a public auction contract
        /// </summary>
        /// <param name="contractId">ID of a contract</param>
        /// <param name="page">Which page of results to return. Default value: 1</param>
        [PublicEndpoint]
        [Route("/latest/contracts/public/bids/{contract_id}/", Version = EndpointVersion.Latest)]
        [Route("/legacy/contracts/public/bids/{contract_id}/", Version = EndpointVersion.Legacy)]
        [Route("/v1/contracts/public/bids/{contract_id}/", Version = EndpointVersion.V1, Preferred = true)]
        [Route("/dev/contracts/public/bids/{contract_id}/", Version = EndpointVersion.Dev)]
        Task<EsiResponsePagination<List<Bid>>> PublicContractBids(int contractId, int page = 1);

        /// <summary>
        /// Lists items of a public contract
        /// </summary>
        /// <param name="contractId">ID of a contract</param>
        /// <param name="page">Which page of results to return. Default value: 1</param>
        [PublicEndpoint]
        [Route("/latest/contracts/public/items/{contract_id}/", Version = EndpointVersion.Latest)]
        [Route("/legacy/contracts/public/items/{contract_id}/", Version = EndpointVersion.Legacy)]
        [Route("/v1/contracts/public/items/{contract_id}/", Version = EndpointVersion.V1, Preferred = true)]
        [Route("/dev/contracts/public/items/{contract_id}/", Version = EndpointVersion.Dev)]
        Task<EsiResponsePagination<List<ContractItem>>> PublicContractItems(int contractId, int page = 1);

        /// <summary>
        /// Returns contracts available to a corporation, only if the corporation is issuer, acceptor or assignee.
        /// Only returns contracts no older than 30 days, or if the status is "in_progress".
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="page">Which page of results to return. Default value: 1</param>
        [ProtectedEndpoint(RequiredScope = "esi-contracts.read_corporation_contracts.v1")]
        [Route("/latest/corporations/{corporation_id}/contracts/", Version = EndpointVersion.Latest)]
        [Route("/legacy/corporations/{corporation_id}/contracts/", Version = EndpointVersion.Legacy)]
        [Route("/v1/corporations/{corporation_id}/contracts/", Version = EndpointVersion.V1, Preferred = true)]
        [Route("/dev/corporations/{corporation_id}/contracts/", Version = EndpointVersion.Dev)]
        Task<EsiResponsePagination<List<Contract>>> CorporationContracts(int corporationId, int page = 1, string? token = null);

        /// <summary>
        /// Lists bids on a particular auction contract
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="contractId">ID of a contract</param>
        /// <param name="page">Which page of results to return. Default value: 1</param>
        [ProtectedEndpoint(RequiredScope = "esi-contracts.read_corporation_contracts.v1")]
        [Route("/latest/corporations/{corporation_id}/contracts/{contract_id}/bids/", Version = EndpointVersion.Latest)]
        [Route("/legacy/corporations/{corporation_id}/contracts/{contract_id}/bids/", Version = EndpointVersion.Legacy)]
        [Route("/v1/corporations/{corporation_id}/contracts/{contract_id}/bids/", Version = EndpointVersion.V1, Preferred = true)]
        [Route("/dev/corporations/{corporation_id}/contracts/{contract_id}/bids/", Version = EndpointVersion.Dev)]
        Task<EsiResponsePagination<List<Bid>>> CorporationContractBids(int corporationId, int contractId, int page = 1, string? token = null);

        /// <summary>
        /// Lists items of a particular contract
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="contractId">ID of a contract</param>
        [ProtectedEndpoint(RequiredScope = "esi-contracts.read_corporation_contracts.v1")]
        [Route("/latest/corporations/{corporation_id}/contracts/{contract_id}/items/", Version = EndpointVersion.Latest)]
        [Route("/legacy/corporations/{corporation_id}/contracts/{contract_id}/items/", Version = EndpointVersion.Legacy)]
        [Route("/v1/corporations/{corporation_id}/contracts/{contract_id}/items/", Version = EndpointVersion.V1, Preferred = true)]
        [Route("/dev/corporations/{corporation_id}/contracts/{contract_id}/items/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<List<ContractItem>>> CorporationContractItems(int corporationId, int contractId, string? token = null);
    }
}
