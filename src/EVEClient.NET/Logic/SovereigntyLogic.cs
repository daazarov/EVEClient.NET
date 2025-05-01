using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

using EVEClient.NET.DataContract;
using EVEClient.NET.Extensions;
using EVEClient.NET.Requests;

namespace EVEClient.NET.Logic
{
    internal class SovereigntyLogic : ISovereigntyLogic
    {
        private readonly IEsiHttpClient _client;
        private readonly IEsiRequestFactory _esiRequestFactory;

        public SovereigntyLogic(IEsiHttpClient client, IEsiRequestFactory esiRequestFactory)
        {
            _client = client;
            _esiRequestFactory = esiRequestFactory;
        }

        public async Task<EsiResponse<List<CampaignSovereignty>>> Campaigns(CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateEmptyRequest();

            var response = await _client.Request(ESI.Endpoints.Sovereignty.Campaigns, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<List<CampaignSovereignty>>();
        }

        public async Task<EsiResponse<List<SolarSystemSovereignty>>> SolarSystems(CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateEmptyRequest();

            var response = await _client.Request(ESI.Endpoints.Sovereignty.SolarSystems, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<List<SolarSystemSovereignty>>();
        }

        public async Task<EsiResponse<List<StructureSovereignty>>> Structures(CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateEmptyRequest();

            var response = await _client.Request(ESI.Endpoints.Sovereignty.Structures, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<List<StructureSovereignty>>();
        }
    }
}
