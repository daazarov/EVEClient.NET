using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

using EVEClient.NET.DataContract;
using EVEClient.NET.Extensions;
using EVEClient.NET.Requests;

namespace EVEClient.NET.Logic
{
    internal class WalletLogic : IWalletLogic
    {
        private readonly IEsiHttpClient _client;
        private readonly IEsiRequestFactory _esiRequestFactory;

        public WalletLogic(IEsiHttpClient client, IEsiRequestFactory esiRequestFactory)
        {
            _client = client;
            _esiRequestFactory = esiRequestFactory;
        }

        public async Task<EsiResponsePagination<List<JournalItem>>> CorporationWalletJournal(int corporationId, int division, int page = 1, string? token = null, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.CorporationId] = corporationId.ToString();
                    parameters.Route[ESI.Parameters.Route.Division] = division.ToString();
                    parameters.Query[ESI.Parameters.Query.Page] = page.ToString();
                },
                token: token);

            var response = await _client.Request(ESI.Endpoints.Wallet.CorporationWalletJournal, request, cancellationToken: cancellationToken);

            return await response.ReadPaginatedEsiResponse<List<JournalItem>>();
        }

        public async Task<EsiResponse<List<Wallet>>> CorporationWallets(int corporationId, string? token = null, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.CorporationId] = corporationId.ToString();
                },
                token: token);

            var response = await _client.Request(ESI.Endpoints.Wallet.CorporationWallets, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<List<Wallet>>();
        }

        public async Task<EsiResponse<List<Transaction>>> CorporationWalletTransactions(int corporationId, int division, long? fromId = null, string? token = null, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.CorporationId] = corporationId.ToString();
                    parameters.Route[ESI.Parameters.Route.Division] = division.ToString();
                },
                token: token);

            var response = await _client.Request(ESI.Endpoints.Wallet.CorporationWalletTransactions, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<List<Transaction>>();
        }

        public async Task<EsiResponse<double>> WalletBalance(int characterId, string? token = null, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.CharacterId] = characterId.ToString();
                },
                token: token);

            var response = await _client.Request(ESI.Endpoints.Wallet.WalletBalance, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<double>();
        }

        public async Task<EsiResponsePagination<List<JournalItem>>> WalletJournal(int characterId, int page = 1, string? token = null, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.CharacterId] = characterId.ToString();
                    parameters.Query[ESI.Parameters.Query.Page] = page.ToString();
                },
                token: token);

            var response = await _client.Request(ESI.Endpoints.Wallet.WalletJournal, request, cancellationToken: cancellationToken);

            return await response.ReadPaginatedEsiResponse<List<JournalItem>>();
        }

        public async Task<EsiResponse<List<Transaction>>> WalletTransactions(int characterId, long? fromId = null, string? token = null, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.CharacterId] = characterId.ToString();
                    parameters.Query[ESI.Parameters.Query.FromId] = fromId.ToString();
                },
                token: token);

            var response = await _client.Request(ESI.Endpoints.Wallet.WalletTransactions, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<List<Transaction>>();
        }
    }
}
