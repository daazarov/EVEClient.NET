using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

using EVEClient.NET.DataContract;
using EVEClient.NET.Extensions;
using EVEClient.NET.Requests;

namespace EVEClient.NET.Logic
{
    internal class ClonesLogic : IClonesLogic
    {
        private readonly IEsiHttpClient _client;
        private readonly IEsiRequestFactory _esiRequestFactory;

        public ClonesLogic(IEsiHttpClient client, IEsiRequestFactory esiRequestFactory)
        {
            _client = client;
            _esiRequestFactory = esiRequestFactory;
        }

        public async Task<EsiResponse<List<int>>> CloneImplants(int characterId, string? token = null, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.CharacterId] = characterId.ToString();
                },
                token: token);

            var response = await _client.Request(ESI.Endpoints.Clones.CloneImplants, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<List<int>>();
        }

        public async Task<EsiResponse<Clones>> CloneList(int characterId, string? token = null, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.CharacterId] = characterId.ToString();
                },
                token: token);

            var response = await _client.Request(ESI.Endpoints.Clones.CloneList, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<Clones>();
        }
    }
}
