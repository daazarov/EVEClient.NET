using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

using EVEClient.NET.DataContract;
using EVEClient.NET.Extensions;
using EVEClient.NET.Requests;

namespace EVEClient.NET.Logic
{
    internal class AssetsLogic : IAssetsLogic
    {
        private readonly IEsiHttpClient _client;
        private readonly IEsiRequestFactory _esiRequestFactory;

        public AssetsLogic(IEsiHttpClient client, IEsiRequestFactory esiRequestFactory)
        {
            _client = client;
            _esiRequestFactory = esiRequestFactory;
        }

        public async Task<EsiResponsePagination<List<AssetItem>>> CharacterAssetList(int characterId, int page = 1, string? token = null, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.CharacterId] = characterId.ToString();
                    parameters.Query[ESI.Parameters.Query.Page] = page.ToString();
                },
                token: token);

            var response = await _client.Request(ESI.Endpoints.Assets.CharacterAssetList, request, cancellationToken: cancellationToken);

            return await response.ReadPaginatedEsiResponse<List<AssetItem>>();
        }

        public async Task<EsiResponsePagination<List<AssetItem>>> CorporationAssetList(int corporationId, int page = 1, string? token = null, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.CorporationId] = corporationId.ToString();
                    parameters.Query[ESI.Parameters.Query.Page] = page.ToString();
                },
                token: token);

            var response = await _client.Request(ESI.Endpoints.Assets.CorporationAssetList, request, cancellationToken: cancellationToken);

            return await response.ReadPaginatedEsiResponse<List<AssetItem>>();
        }

        public async Task<EsiResponse<List<ItemLocation>>> LocationAssets(int characterId, long[] itemIds, string? token = null, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.CharacterId] = characterId.ToString();
                    parameters.Body = itemIds;
                },
                token: token);

            var response = await _client.Request(ESI.Endpoints.Assets.LocationAssets, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<List<ItemLocation>>();
        }

        public async Task<EsiResponse<List<ItemName>>> AssetItemNames(int characterId, long[] itemIds, string? token = null, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.CharacterId] = characterId.ToString();
                    parameters.Body = itemIds;
                },
                token: token);

            var response = await _client.Request(ESI.Endpoints.Assets.AssetItemNames, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<List<ItemName>>();
        }

        public async Task<EsiResponse<List<ItemLocation>>> CorporationLocationAssets(int corporationId, long[] itemIds, string? token = null, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.CorporationId] = corporationId.ToString();
                    parameters.Body = itemIds;
                },
                token: token);

            var response = await _client.Request(ESI.Endpoints.Assets.CorporationLocationAssets, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<List<ItemLocation>>();
        }

        public async Task<EsiResponse<List<ItemName>>> CorporationAssetItemNames(int corporationId, long[] itemIds, string? token = null, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.CorporationId] = corporationId.ToString();
                    parameters.Body = itemIds;
                },
                token: token);

            var response = await _client.Request(ESI.Endpoints.Assets.CorporationAssetItemNames, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<List<ItemName>>();
        }
    }
}
