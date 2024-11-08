using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

using EVEClient.NET.DataContract;

namespace EVEClient.NET
{
    public interface IBookmarksLogic
    {
        /// <summary>
        /// A list of your character’s personal bookmarks
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="page">Which page of results to return. Default value: 1</param>
        Task<EsiResponsePagination<List<Bookmark>>> CharacterBookmarks(int characterId, int page = 1, string? token = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// A list of your character’s personal bookmark folders
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="page">Which page of results to return. Default value: 1</param>
        Task<EsiResponsePagination<List<Folder>>> CharacterBookmarkFolders(int characterId, int page = 1, string? token = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// A list of your corporation’s bookmarks
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="page">Which page of results to return. Default value: 1</param>
        Task<EsiResponsePagination<List<Bookmark>>> CorporationBookmarks(int corporationId, int page = 1, string? token = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// A list of your corporation’s bookmark folders
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="page">Which page of results to return. Default value: 1</param>
        Task<EsiResponsePagination<List<CorporationFolder>>> CorporationBookmarkFolders(int corporationId, int page = 1, string? token = null, CancellationToken cancellationToken = default);
    }
}
