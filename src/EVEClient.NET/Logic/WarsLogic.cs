using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

using EVEClient.NET.DataContract;
using EVEClient.NET.Extensions;
using EVEClient.NET.Requests;

namespace EVEClient.NET.Logic
{
    internal class WarsLogic : IWarsLogic
    {
        private readonly IEsiHttpClient _client;
        private readonly IEsiRequestFactory _esiRequestFactory;

        public WarsLogic(IEsiHttpClient client, IEsiRequestFactory esiRequestFactory)
        {
            _client = client;
            _esiRequestFactory = esiRequestFactory;
        }

        public async Task<EsiResponsePagination<List<Kill>>> Kills(int warId, int page = 1, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.WarId] = warId.ToString();
                    parameters.Query[ESI.Parameters.Query.Page] = page.ToString();
                });

            var response = await _client.Request(ESI.Endpoints.Wars.Kills, request, cancellationToken: cancellationToken);

            return await response.ReadPaginatedEsiResponse<List<Kill>>();
        }

        public async Task<EsiResponse<War>> WarDetails(int warId, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.WarId] = warId.ToString();
                });

            var response = await _client.Request(ESI.Endpoints.Wars.WarDetails, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<War>();
        }

        public async Task<EsiResponse<List<int>>> Wars(int? maxWarId, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Query[ESI.Parameters.Query.MaxWarId] = maxWarId.ToString();
                });

            var response = await _client.Request(ESI.Endpoints.Wars.WarList, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<List<int>>();
        }
    }
}
