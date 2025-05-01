using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

using EVEClient.NET.DataContract;
using EVEClient.NET.Extensions;
using EVEClient.NET.Requests;

namespace EVEClient.NET.Logic
{
    internal class PlanetaryInteractionLogic : IPlanetaryInteractionLogic
    {
        private readonly IEsiHttpClient _client;
        private readonly IEsiRequestFactory _esiRequestFactory;

        public PlanetaryInteractionLogic(IEsiHttpClient client, IEsiRequestFactory esiRequestFactory)
        {
            _client = client;
            _esiRequestFactory = esiRequestFactory;
        }

        public async Task<EsiResponse<List<Colony>>> Colonies(int characterId, string? token = null, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.CharacterId] = characterId.ToString();
                },
                token: token);

            var response = await _client.Request(ESI.Endpoints.PlanetaryInteraction.Colonies, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<List<Colony>>();
        }

        public async Task<EsiResponse<ColonyLayout>> ColonyInfo(int characterId, int planetId, string? token = null, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.CharacterId] = characterId.ToString();
                    parameters.Route[ESI.Parameters.Route.PlanetId] = planetId.ToString();
                },
                token: token);

            var response = await _client.Request(ESI.Endpoints.PlanetaryInteraction.ColonyInfo, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<ColonyLayout>();
        }

        public async Task<EsiResponsePagination<List<CustomOffice>>> CorporationCustomOffices(int corporationId, int page = 1, string? token = null, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.CorporationId] = corporationId.ToString();
                    parameters.Query[ESI.Parameters.Query.Page] = page.ToString();
                },
                token: token);

            var response = await _client.Request(ESI.Endpoints.PlanetaryInteraction.CustomOffices, request, cancellationToken: cancellationToken);

            return await response.ReadPaginatedEsiResponse<List<CustomOffice>>();
        }

        public async Task<EsiResponse<SchematicInfo>> SchematicInfo(int schematicId, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.SchematicId] = schematicId.ToString();
                });

            var response = await _client.Request(ESI.Endpoints.PlanetaryInteraction.SchematicInfo, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<SchematicInfo>();
        }
    }
}
