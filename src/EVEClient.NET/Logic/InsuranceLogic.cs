using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

using EVEClient.NET.DataContract;
using EVEClient.NET.Extensions;
using EVEClient.NET.Requests;

namespace EVEClient.NET.Logic
{
    internal class InsuranceLogic : IInsuranceLogic
    {
        private readonly IEsiHttpClient _client;
        private readonly IEsiRequestFactory _esiRequestFactory;

        public InsuranceLogic(IEsiHttpClient client, IEsiRequestFactory esiRequestFactory)
        {
            _client = client;
            _esiRequestFactory = esiRequestFactory;
        }

        public async Task<EsiResponse<List<Insurance>>> InsuranceLevels(CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateEmptyRequest();

            var response = await _client.Request(ESI.Endpoints.Insurence.InsuranceLevels, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<List<Insurance>>();
        }
    }
}
