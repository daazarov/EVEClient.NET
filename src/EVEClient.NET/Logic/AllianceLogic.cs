using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

using EVEClient.NET.DataContract;
using EVEClient.NET.Extensions;
using EVEClient.NET.Requests;

namespace EVEClient.NET.Logic
{
    internal class AllianceLogic : IAllianceLogic
    {
        private readonly IEsiHttpClient _client;
        private readonly IEsiRequestFactory _esiRequestFactory;

        public AllianceLogic(IEsiHttpClient client, IEsiRequestFactory esiRequestFactory)
        {
            _client = client;
            _esiRequestFactory = esiRequestFactory;
        }

        public async Task<EsiResponse<List<int>>> CorporationsInAlliance(int allianceId, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.AllianceId] = allianceId.ToString();
                });

            var response = await _client.Request(ESI.Endpoints.Alliances.CorporationsInAlliance, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<List<int>>();
        }

        public async Task<EsiResponse<AllianceIcon>> AllianceIcon(int allianceId, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.AllianceId] = allianceId.ToString();
                });

            var response = await _client.Request(ESI.Endpoints.Alliances.AllianceIcon, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<AllianceIcon>();
        }

        public async Task<EsiResponse<Alliance>> PublicInformation(int allianceId, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.AllianceId] = allianceId.ToString();
                });

            var response = await _client.Request(ESI.Endpoints.Alliances.PublicInformation, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<Alliance>();
        }

        public async Task<EsiResponse<List<int>>> ActiveAlliances(CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateEmptyRequest();

            var response = await _client.Request(ESI.Endpoints.Alliances.ActiveAlliances, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<List<int>>();
        }
    }
}
