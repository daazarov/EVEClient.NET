using System.Collections.Generic;
using System.Threading.Tasks;

using EVEOnline.Esi.Communication.DataContract;
using EVEOnline.Esi.Communication.Logic.Interfaces;

using static EVEOnline.Esi.Communication.DataContract.Requests.Internal.BookmarkRequests;

namespace EVEOnline.Esi.Communication.Logic
{
    internal class BookmarksLogic : IBookmarksLogic
    {
        private readonly IEsiHttpClient<IBookmarksLogic> _esiClient;

        public BookmarksLogic(IEsiHttpClient<IBookmarksLogic> esiClient)
        {
            _esiClient = esiClient;
        }

        public Task<EsiResponsePagination<List<Folder>>> GetCharacterBookmarkFoldersAsync(int characterId, int page = 1) =>
            _esiClient.GetPaginationRequestAsync<PageBasedCharacterIdRouteRequest, List<Folder>>(PageBasedCharacterIdRouteRequest.Create(characterId, page));

        public Task<EsiResponsePagination<List<Bookmark>>> GetCharacterBookmarksAsync(int characterId, int page = 1) =>
            _esiClient.GetPaginationRequestAsync<PageBasedCharacterIdRouteRequest, List<Bookmark>>(PageBasedCharacterIdRouteRequest.Create(characterId, page));

        public Task<EsiResponsePagination<List<CorporationFolder>>> GetCorporationBookmarkFoldersAsync(int corporationId, int page = 1) =>
            _esiClient.GetPaginationRequestAsync<PageBasedCorporationIdRouteRequest, List<CorporationFolder>>(PageBasedCorporationIdRouteRequest.Create(corporationId, page));

        public Task<EsiResponsePagination<List<Bookmark>>> GetCorporationBookmarksAsync(int corporationId, int page = 1) =>
            _esiClient.GetPaginationRequestAsync<PageBasedCorporationIdRouteRequest, List<Bookmark>>(PageBasedCorporationIdRouteRequest.Create(corporationId, page));
    }
}
