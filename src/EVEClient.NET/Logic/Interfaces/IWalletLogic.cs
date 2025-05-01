using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

using EVEClient.NET.DataContract;

namespace EVEClient.NET
{
    public interface IWalletLogic
    {
        /// <summary>
        /// Returns a character’s wallet balance
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        Task<EsiResponse<double>> WalletBalance(int characterId, string? token = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieve the given character’s wallet journal going 30 days back
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="page">Which page of results to return. Default value: 1</param>
        Task<EsiResponsePagination<List<JournalItem>>> WalletJournal(int characterId, int page = 1, string? token = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get wallet transactions of a character
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="fromId">Only show transactions happened before the one referenced by this id</param>
        Task<EsiResponse<List<Transaction>>> WalletTransactions(int characterId, long? fromId = null, string? token = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get a corporation’s wallets
        /// </summary>
        /// <remarks>Requires one of the following EVE corporation role(s): Accountant, Junior_Accountant</remarks>
        /// <param name="corporationId">An EVE corporation ID</param>
        Task<EsiResponse<List<Wallet>>> CorporationWallets(int corporationId, string? token = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieve the given corporation’s wallet journal for the given division going 30 days back
        /// </summary>
        /// <remarks>Requires one of the following EVE corporation role(s): Accountant, Junior_Accountant</remarks>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="division">Wallet key of the division to fetch journals from</param>
        /// <param name="page">Which page of results to return. Default value: 1</param>
        Task<EsiResponsePagination<List<JournalItem>>> CorporationWalletJournal(int corporationId, int division, int page = 1, string? token = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get wallet transactions of a corporation
        /// </summary>
        /// <remarks>Requires one of the following EVE corporation role(s): Accountant, Junior_Accountant</remarks>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="division">Wallet key of the division to fetch journals from</param>
        /// <param name="fromId">Only show journal entries happened before the transaction referenced by this id</param>
        Task<EsiResponse<List<Transaction>>> CorporationWalletTransactions(int corporationId, int division, long? fromId = null, string? token = null, CancellationToken cancellationToken = default);
    }
}
