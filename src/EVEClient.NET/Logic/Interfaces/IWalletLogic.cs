using System.Collections.Generic;
using System.Threading.Tasks;

using EVEClient.NET.Attributes;
using EVEClient.NET.DataContract;

namespace EVEClient.NET
{
    public interface IWalletLogic
    {
        /// <summary>
        /// Returns a character’s wallet balance
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        [ProtectedEndpoint(RequiredScope = "esi-wallet.read_character_wallet.v1")]
        [Route("/latest/characters/{character_id}/wallet/", Version = EndpointVersion.Latest)]
        [Route("/legacy/characters/{character_id}/wallet/", Version = EndpointVersion.Legacy)]
        [Route("/v1/characters/{character_id}/wallet/", Version = EndpointVersion.V1, Preferred = true)]
        Task<EsiResponse<double>> WalletBalance(int characterId);

        /// <summary>
        /// Retrieve the given character’s wallet journal going 30 days back
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="page">Which page of results to return. Default value: 1</param>
        [ProtectedEndpoint(RequiredScope = "esi-wallet.read_character_wallet.v1")]
        [Route("/latest/characters/{character_id}/wallet/journal/", Version = EndpointVersion.Latest)]
        [Route("/v6/characters/{character_id}/wallet/journal/", Version = EndpointVersion.V6, Preferred = true)]
        [Route("/dev/characters/{character_id}/wallet/journal/", Version = EndpointVersion.Dev)]
        Task<EsiResponsePagination<List<JournalItem>>> WalletJournal(int characterId, int page = 1);

        /// <summary>
        /// Get wallet transactions of a character
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="fromId">Only show transactions happened before the one referenced by this id</param>
        [ProtectedEndpoint(RequiredScope = "esi-wallet.read_character_wallet.v1")]
        [Route("/latest/characters/{character_id}/wallet/transactions/", Version = EndpointVersion.Latest)]
        [Route("/legacy/characters/{character_id}/wallet/transactions/", Version = EndpointVersion.Legacy)]
        [Route("/v1/characters/{character_id}/wallet/transactions/", Version = EndpointVersion.V1, Preferred = true)]
        [Route("/dev/characters/{character_id}/wallet/transactions/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<List<Transaction>>> WalletTransactions(int characterId, long? fromId = null);

        /// <summary>
        /// Get a corporation’s wallets
        /// </summary>
        /// <remarks>Requires one of the following EVE corporation role(s): Accountant, Junior_Accountant</remarks>
        /// <param name="corporationId">An EVE corporation ID</param>
        [ProtectedEndpoint(RequiredScope = "esi-wallet.read_corporation_wallets.v1")]
        [Route("/latest/corporations/{corporation_id}/wallets/", Version = EndpointVersion.Latest)]
        [Route("/legacy/corporations/{corporation_id}/wallets/", Version = EndpointVersion.Legacy)]
        [Route("/v1/corporations/{corporation_id}/wallets/", Version = EndpointVersion.V1, Preferred = true)]
        [Route("/dev/corporations/{corporation_id}/wallets/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<List<Wallet>>> CorporationWallets(int corporationId);

        /// <summary>
        /// Retrieve the given corporation’s wallet journal for the given division going 30 days back
        /// </summary>
        /// <remarks>Requires one of the following EVE corporation role(s): Accountant, Junior_Accountant</remarks>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="division">Wallet key of the division to fetch journals from</param>
        /// <param name="page">Which page of results to return. Default value: 1</param>
        [ProtectedEndpoint(RequiredScope = "esi-wallet.read_corporation_wallets.v1")]
        [Route("/latest/corporations/{corporation_id}/wallets/{division}/journal/\"", Version = EndpointVersion.Latest)]
        [Route("/v4/corporations/{corporation_id}/wallets/{division}/journal/", Version = EndpointVersion.V4, Preferred = true)]
        [Route("/dev/corporations/{corporation_id}/wallets/{division}/journal/", Version = EndpointVersion.Dev)]
        Task<EsiResponsePagination<List<JournalItem>>> CorporationWalletJournal(int corporationId, int division, int page = 1);

        /// <summary>
        /// Get wallet transactions of a corporation
        /// </summary>
        /// <remarks>Requires one of the following EVE corporation role(s): Accountant, Junior_Accountant</remarks>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="division">Wallet key of the division to fetch journals from</param>
        /// <param name="fromId">Only show journal entries happened before the transaction referenced by this id</param>
        [ProtectedEndpoint(RequiredScope = "esi-wallet.read_corporation_wallets.v1")]
        [Route("/latest/corporations/{corporation_id}/wallets/{division}/transactions/", Version = EndpointVersion.Latest)]
        [Route("/legacy/corporations/{corporation_id}/wallets/{division}/transactions/", Version = EndpointVersion.Legacy)]
        [Route("/v1/corporations/{corporation_id}/wallets/{division}/transactions/", Version = EndpointVersion.V1, Preferred = true)]
        [Route("/dev/corporations/{corporation_id}/wallets/{division}/transactions/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<List<Transaction>>> CorporationWalletTransactions(int corporationId, int division, long? fromId = null);
    }
}
