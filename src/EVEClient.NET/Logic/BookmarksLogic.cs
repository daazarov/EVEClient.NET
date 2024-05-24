using System.Collections.Generic;
using System.Threading.Tasks;

using EVEClient.NET.DataContract;

using static EVEClient.NET.Models.CommonRequests;

namespace EVEClient.NET.Logic
{
    internal class BookmarksLogic : IBookmarksLogic
    {
        private readonly IEsiHttpClient<IBookmarksLogic> _esiClient;

        public BookmarksLogic(IEsiHttpClient<IBookmarksLogic> esiClient)
        {
            _esiClient = esiClient;
        }

        public Task<EsiResponsePagination<List<Folder>>> CharacterBookmarkFolders(int characterId, int page = 1) =>
            _esiClient.GetPaginationRequestAsync<PageBasedCharacterIdRouteRequest, List<Folder>>(PageBasedCharacterIdRouteRequest.Create(characterId, page));

        public Task<EsiResponsePagination<List<Bookmark>>> CharacterBookmarks(int characterId, int page = 1) =>
            _esiClient.GetPaginationRequestAsync<PageBasedCharacterIdRouteRequest, List<Bookmark>>(PageBasedCharacterIdRouteRequest.Create(characterId, page));

        public Task<EsiResponsePagination<List<CorporationFolder>>> CorporationBookmarkFolders(int corporationId, int page = 1) =>
            _esiClient.GetPaginationRequestAsync<PageBasedCorporationIdRouteRequest, List<CorporationFolder>>(PageBasedCorporationIdRouteRequest.Create(corporationId, page));

        public Task<EsiResponsePagination<List<Bookmark>>> CorporationBookmarks(int corporationId, int page = 1) =>
            _esiClient.GetPaginationRequestAsync<PageBasedCorporationIdRouteRequest, List<Bookmark>>(PageBasedCorporationIdRouteRequest.Create(corporationId, page));
    }
}
