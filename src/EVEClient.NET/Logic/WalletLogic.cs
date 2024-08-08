using System.Collections.Generic;
using System.Threading.Tasks;

using EVEClient.NET.DataContract;

using static EVEClient.NET.Models.CommonRequests;
using static EVEClient.NET.Models.WalletRequests;

namespace EVEClient.NET.Logic
{
    internal class WalletLogic : IWalletLogic
    {
        private readonly IEsiHttpClient<IWalletLogic> _esiClient;

        public WalletLogic(IEsiHttpClient<IWalletLogic> esiClient)
        {
            _esiClient = esiClient;
        }

        public Task<EsiResponsePagination<List<JournalItem>>> CorporationWalletJournal(int corporationId, int division, int page = 1, string? token = null) =>
            _esiClient.GetPaginationRequestAsync<CorporationWalletTransactionsRequest, List<JournalItem>>(CorporationWalletTransactionsRequest.Create(corporationId, division, page), token);

        public Task<EsiResponse<List<Wallet>>> CorporationWallets(int corporationId, string? token = null) =>
            _esiClient.GetRequestAsync<CorporationIdRouteRequest, List<Wallet>>(CorporationIdRouteRequest.Create(corporationId), token);

        public Task<EsiResponse<List<Transaction>>> CorporationWalletTransactions(int corporationId, int division, long? fromId = null, string? token = null) =>
            _esiClient.GetRequestAsync<CorporationWalletTransactionsRequest, List<Transaction>>(CorporationWalletTransactionsRequest.Create(corporationId, division, fromId), token);

        public Task<EsiResponse<double>> WalletBalance(int characterId, string? token = null) =>
            _esiClient.GetRequestAsync<CharacterIdRouteRequest, double>(CharacterIdRouteRequest.Create(characterId), token);

        public Task<EsiResponsePagination<List<JournalItem>>> WalletJournal(int characterId, int page = 1, string? token = null) =>
            _esiClient.GetPaginationRequestAsync<PageBasedCharacterIdRouteRequest, List<JournalItem>>(PageBasedCharacterIdRouteRequest.Create(characterId, page), token);

        public Task<EsiResponse<List<Transaction>>> WalletTransactions(int characterId, long? fromId = null, string? token = null) =>
            _esiClient.GetRequestAsync<WalletTransactionsRequest, List<Transaction>>(WalletTransactionsRequest.Create(characterId, fromId), token);
    }
}
