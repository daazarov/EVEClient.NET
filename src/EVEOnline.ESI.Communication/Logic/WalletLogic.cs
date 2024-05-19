using System.Collections.Generic;
using System.Threading.Tasks;

using EVEOnline.ESI.Communication.DataContract;

using static EVEOnline.ESI.Communication.Models.CommonRequests;
using static EVEOnline.ESI.Communication.Models.WalletRequests;

namespace EVEOnline.ESI.Communication.Logic
{
    internal class WalletLogic : IWalletLogic
    {
        private readonly IEsiHttpClient<IWalletLogic> _esiClient;

        public WalletLogic(IEsiHttpClient<IWalletLogic> esiClient)
        {
            _esiClient = esiClient;
        }

        public Task<EsiResponsePagination<List<JournalItem>>> CorporationWalletJournal(int corporationId, int division, int page = 1) =>
            _esiClient.GetPaginationRequestAsync<CorporationWalletTransactionsRequest, List<JournalItem>>(CorporationWalletTransactionsRequest.Create(corporationId, division, page));

        public Task<EsiResponse<List<Wallet>>> CorporationWallets(int corporationId) =>
            _esiClient.GetRequestAsync<CorporationIdRouteRequest, List<Wallet>>(CorporationIdRouteRequest.Create(corporationId));

        public Task<EsiResponse<List<Transaction>>> CorporationWalletTransactions(int corporationId, int division, long? fromId = null) =>
            _esiClient.GetRequestAsync<CorporationWalletTransactionsRequest, List<Transaction>>(CorporationWalletTransactionsRequest.Create(corporationId, division, fromId));

        public Task<EsiResponse<double>> WalletBalance(int characterId) =>
            _esiClient.GetRequestAsync<CharacterIdRouteRequest, double>(CharacterIdRouteRequest.Create(characterId));

        public Task<EsiResponsePagination<List<JournalItem>>> WalletJournal(int characterId, int page = 1) =>
            _esiClient.GetPaginationRequestAsync<PageBasedCharacterIdRouteRequest, List<JournalItem>>(PageBasedCharacterIdRouteRequest.Create(characterId, page));

        public Task<EsiResponse<List<Transaction>>> WalletTransactions(int characterId, long? fromId = null) =>
            _esiClient.GetRequestAsync<WalletTransactionsRequest, List<Transaction>>(WalletTransactionsRequest.Create(characterId, fromId));
    }
}
