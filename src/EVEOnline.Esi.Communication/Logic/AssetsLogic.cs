using System.Collections.Generic;
using System.Threading.Tasks;

using EVEOnline.Esi.Communication.DataContract;
using EVEOnline.Esi.Communication.Logic.Interfaces;

using static EVEOnline.Esi.Communication.DataContract.Requests.Internal.AssetsRequests;

namespace EVEOnline.Esi.Communication.Logic
{
    internal class AssetsLogic : IAssetsLogic
    {
        private readonly IEsiHttpClient<IAssetsLogic> _esiClient;

        public AssetsLogic(IEsiHttpClient<IAssetsLogic> esiClient)
        {
            _esiClient = esiClient;
        }

        public Task<EsiResponsePagination<List<Item>>> GetCharacterAssets(int characterId, int page = 1) =>
            _esiClient.GetPaginationRequestAsync<PageBasedCharacterIdRouteRequest, List<Item>>(PageBasedCharacterIdRouteRequest.Create(characterId, page));

        public Task<EsiResponsePagination<List<Item>>> GetCorporationAssets(int corporationId, int page = 1) =>
            _esiClient.GetPaginationRequestAsync<PageBasedCorporationIdRouteRequest, List<Item>>(PageBasedCorporationIdRouteRequest.Create(corporationId, page));

        public Task<EsiResponse<List<ItemLocation>>> PostCharacterLocationAssets(int characterId, long[] itemIds) =>
            _esiClient.PostRequestAsync<CharacterItemsPostRequest, List<ItemLocation>>(CharacterItemsPostRequest.Create(characterId, itemIds));

        public Task<EsiResponse<List<ItemName>>> PostCharacterNameAssets(int characterId, long[] itemIds) =>
            _esiClient.PostRequestAsync<CharacterItemsPostRequest, List<ItemName>>(CharacterItemsPostRequest.Create(characterId, itemIds));

        public Task<EsiResponse<List<ItemLocation>>> PostCorporationLocationAssets(int corporationId, long[] itemIds) =>
            _esiClient.PostRequestAsync<CorporationItemsPostRequest, List<ItemLocation>>(CorporationItemsPostRequest.Create(corporationId, itemIds));

        public Task<EsiResponse<List<ItemName>>> PostCorporationNameAssets(int corporationId, long[] itemIds) =>
            _esiClient.PostRequestAsync<CorporationItemsPostRequest, List<ItemName>>(CorporationItemsPostRequest.Create(corporationId, itemIds));
    }
}
