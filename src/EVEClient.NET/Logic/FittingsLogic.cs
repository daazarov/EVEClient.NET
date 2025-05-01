using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

using EVEClient.NET.DataContract;
using EVEClient.NET.Extensions;
using EVEClient.NET.Requests;

namespace EVEClient.NET.Logic
{
    internal class FittingsLogic : IFittingsLogic
    {
        private readonly IEsiHttpClient _client;
        private readonly IEsiRequestFactory _esiRequestFactory;

        public FittingsLogic(IEsiHttpClient client, IEsiRequestFactory esiRequestFactory)
        {
            _client = client;
            _esiRequestFactory = esiRequestFactory;
        }

        public async Task<EsiResponse> DeleteFitting(int characterId, int fittingId, string? token = null, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.CharacterId] = characterId.ToString();
                    parameters.Route[ESI.Parameters.Route.FittingId] = fittingId.ToString();
                },
                token: token);

            var response = await _client.Request(ESI.Endpoints.Fittings.DeleteFitting, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse();
        }

        public async Task<EsiResponse<List<Fitting>>> GetFittings(int characterId, string? token = null, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.CharacterId] = characterId.ToString();
                },
                token: token);

            var response = await _client.Request(ESI.Endpoints.Fittings.GetFittings, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<List<Fitting>>();
        }

        public async Task<EsiResponse<NewFittingResponse>> NewFitting(int characterId, NewFitting fitting, string? token = null, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.CharacterId] = characterId.ToString();
                    parameters.Body = fitting;
                },
                token: token);

            var response = await _client.Request(ESI.Endpoints.Fittings.NewFitting, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<NewFittingResponse>();
        }
    }
}
