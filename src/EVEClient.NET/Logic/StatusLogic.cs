using System.Threading;
using System.Threading.Tasks;

using EVEClient.NET.DataContract;
using EVEClient.NET.Extensions;
using EVEClient.NET.Requests;

namespace EVEClient.NET.Logic
{
    internal class StatusLogic : IStatusLogic
    {
        private readonly IEsiHttpClient _client;
        private readonly IEsiRequestFactory _esiRequestFactory;

        public StatusLogic(IEsiHttpClient client, IEsiRequestFactory esiRequestFactory)
        {
            _client = client;
            _esiRequestFactory = esiRequestFactory;
        }

        public async Task<EsiResponse<ServerStatus>> ServerStatus(CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateEmptyRequest();

            var response = await _client.Request(ESI.Endpoints.Status.ServerStatus, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<ServerStatus>();
        }
    }
}
