using System.Collections.Generic;
using System.Threading.Tasks;

using EVEClient.NET.DataContract;

using static EVEClient.NET.Models.AssetsRequests;
using static EVEClient.NET.Models.CommonRequests;

namespace EVEClient.NET.Logic
{
    internal class AssetsLogic : IAssetsLogic
    {
        private readonly IEsiHttpClient<IAssetsLogic> _esiClient;

        public AssetsLogic(IEsiHttpClient<IAssetsLogic> esiClient)
        {
            _esiClient = esiClient;
        }

        public Task<EsiResponsePagination<List<AssetItem>>> CharacterAssetList(int characterId, int page = 1) =>
            _esiClient.GetPaginationRequestAsync<PageBasedCharacterIdRouteRequest, List<AssetItem>>(PageBasedCharacterIdRouteRequest.Create(characterId, page));

        public Task<EsiResponsePagination<List<AssetItem>>> CorporationAssetList(int corporationId, int page = 1) =>
            _esiClient.GetPaginationRequestAsync<PageBasedCorporationIdRouteRequest, List<AssetItem>>(PageBasedCorporationIdRouteRequest.Create(corporationId, page));

        public Task<EsiResponse<List<ItemLocation>>> LocationAssets(int characterId, long[] itemIds) =>
            _esiClient.PostRequestAsync<CharacterItemsPostRequest, List<ItemLocation>>(CharacterItemsPostRequest.Create(characterId, itemIds));

        public Task<EsiResponse<List<ItemName>>> AssetItemNames(int characterId, long[] itemIds) =>
            _esiClient.PostRequestAsync<CharacterItemsPostRequest, List<ItemName>>(CharacterItemsPostRequest.Create(characterId, itemIds));

        public Task<EsiResponse<List<ItemLocation>>> CorporationLocationAssets(int corporationId, long[] itemIds) =>
            _esiClient.PostRequestAsync<CorporationItemsPostRequest, List<ItemLocation>>(CorporationItemsPostRequest.Create(corporationId, itemIds));

        public Task<EsiResponse<List<ItemName>>> CorporationAssetItemNames(int corporationId, long[] itemIds) =>
            _esiClient.PostRequestAsync<CorporationItemsPostRequest, List<ItemName>>(CorporationItemsPostRequest.Create(corporationId, itemIds));
    }
}
