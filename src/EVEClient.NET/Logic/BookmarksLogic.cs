using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

using EVEClient.NET.DataContract;
using EVEClient.NET.Extensions;
using EVEClient.NET.Requests;

namespace EVEClient.NET.Logic
{
    internal class BookmarksLogic : IBookmarksLogic
    {
        private readonly IEsiHttpClient _client;
        private readonly IEsiRequestFactory _esiRequestFactory;

        public BookmarksLogic(IEsiHttpClient client, IEsiRequestFactory esiRequestFactory)
        {
            _client = client;
            _esiRequestFactory = esiRequestFactory;
        }

        public async Task<EsiResponsePagination<List<Folder>>> CharacterBookmarkFolders(int characterId, int page = 1, string? token = null, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.CharacterId] = characterId.ToString();
                    parameters.Query[ESI.Parameters.Query.Page] = page.ToString();
                },
                token: token);

            var response = await _client.Request(ESI.Endpoints.Bookmarks.CharacterBookmarkFolders, request, cancellationToken: cancellationToken);

            return await response.ReadPaginatedEsiResponse<List<Folder>>();
        }

        public async Task<EsiResponsePagination<List<Bookmark>>> CharacterBookmarks(int characterId, int page = 1, string? token = null, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.CharacterId] = characterId.ToString();
                    parameters.Query[ESI.Parameters.Query.Page] = page.ToString();
                },
                token: token);

            var response = await _client.Request(ESI.Endpoints.Bookmarks.CharacterBookmarks, request, cancellationToken: cancellationToken);

            return await response.ReadPaginatedEsiResponse<List<Bookmark>>();
        }

        public async Task<EsiResponsePagination<List<CorporationFolder>>> CorporationBookmarkFolders(int corporationId, int page = 1, string? token = null, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.CorporationId] = corporationId.ToString();
                    parameters.Query[ESI.Parameters.Query.Page] = page.ToString();
                },
                token: token);

            var response = await _client.Request(ESI.Endpoints.Bookmarks.CorporationBookmarkFolders, request, cancellationToken: cancellationToken);

            return await response.ReadPaginatedEsiResponse<List<CorporationFolder>>();
        }

        public async Task<EsiResponsePagination<List<Bookmark>>> CorporationBookmarks(int corporationId, int page = 1, string? token = null, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.CorporationId] = corporationId.ToString();
                    parameters.Query[ESI.Parameters.Query.Page] = page.ToString();
                },
                token: token);

            var response = await _client.Request(ESI.Endpoints.Bookmarks.CorporationBookmarks, request, cancellationToken: cancellationToken);

            return await response.ReadPaginatedEsiResponse<List<Bookmark>>();
        }
    }
}
