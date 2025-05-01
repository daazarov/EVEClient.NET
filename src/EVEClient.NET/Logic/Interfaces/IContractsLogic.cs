using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

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
        Task<EsiResponsePagination<List<Contract>>> CharacterContracts(int characterId, int page = 1, string? token = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Lists bids on a particular auction contract
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="contractId">ID of a contract</param>
        Task<EsiResponse<List<Bid>>> CharacterContractBids(int characterId, int contractId, string? token = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Lists items of a particular contract
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="contractId">ID of a contract</param>
        Task<EsiResponse<List<ContractItem>>> CharacterContractItems(int characterId, int contractId, string? token = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Returns a paginated list of all public contracts in the given region
        /// </summary>
        /// <param name="regionId">An EVE region id</param>
        /// <param name="page">Which page of results to return. Default value: 1</param>
        Task<EsiResponsePagination<List<PublicContract>>> PublicContracts(int regionId, int page = 1, CancellationToken cancellationToken = default);

        /// <summary>
        /// Lists bids on a public auction contract
        /// </summary>
        /// <param name="contractId">ID of a contract</param>
        /// <param name="page">Which page of results to return. Default value: 1</param>
        Task<EsiResponsePagination<List<Bid>>> PublicContractBids(int contractId, int page = 1, CancellationToken cancellationToken = default);

        /// <summary>
        /// Lists items of a public contract
        /// </summary>
        /// <param name="contractId">ID of a contract</param>
        /// <param name="page">Which page of results to return. Default value: 1</param>
        Task<EsiResponsePagination<List<ContractItem>>> PublicContractItems(int contractId, int page = 1, CancellationToken cancellationToken = default);

        /// <summary>
        /// Returns contracts available to a corporation, only if the corporation is issuer, acceptor or assignee.
        /// Only returns contracts no older than 30 days, or if the status is "in_progress".
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="page">Which page of results to return. Default value: 1</param>
        Task<EsiResponsePagination<List<Contract>>> CorporationContracts(int corporationId, int page = 1, string? token = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Lists bids on a particular auction contract
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="contractId">ID of a contract</param>
        /// <param name="page">Which page of results to return. Default value: 1</param>
        Task<EsiResponsePagination<List<Bid>>> CorporationContractBids(int corporationId, int contractId, int page = 1, string? token = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Lists items of a particular contract
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="contractId">ID of a contract</param>
        Task<EsiResponse<List<ContractItem>>> CorporationContractItems(int corporationId, int contractId, string? token = null, CancellationToken cancellationToken = default);
    }
}
