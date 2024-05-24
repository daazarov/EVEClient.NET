using System.Collections.Generic;
using System.Threading.Tasks;

using EVEClient.NET.Attributes;
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
        [ProtectedEndpoint(RequiredScope = "esi-bookmarks.read_character_bookmarks.v1")]
        [Route("/latest/characters/{character_id}/bookmarks/", Version = EndpointVersion.Latest)]
        [Route("/v2/characters/{character_id}/bookmarks/", Version = EndpointVersion.V2, Preferred = true)]
        [Route("/dev/characters/{character_id}/bookmarks/", Version = EndpointVersion.Dev)]
        Task<EsiResponsePagination<List<Bookmark>>> CharacterBookmarks(int characterId, int page = 1);

        /// <summary>
        /// A list of your character’s personal bookmark folders
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="page">Which page of results to return. Default value: 1</param>
        [ProtectedEndpoint(RequiredScope = "esi-bookmarks.read_character_bookmarks.v1")]
        [Route("/latest/characters/{character_id}/bookmarks/folders/", Version = EndpointVersion.Latest)]
        [Route("/v2/characters/{character_id}/bookmarks/folders/", Version = EndpointVersion.V2, Preferred = true)]
        [Route("/dev/characters/{character_id}/bookmarks/folders/", Version = EndpointVersion.Dev)]
        Task<EsiResponsePagination<List<Folder>>> CharacterBookmarkFolders(int characterId, int page = 1);

        /// <summary>
        /// A list of your corporation’s bookmarks
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="page">Which page of results to return. Default value: 1</param>
        [ProtectedEndpoint(RequiredScope = "esi-bookmarks.read_corporation_bookmarks.v1")]
        [Route("/latest/corporations/{corporation_id}/bookmarks/", Version = EndpointVersion.Latest)]
        [Route("/legacy/corporations/{corporation_id}/bookmarks/", Version = EndpointVersion.Legacy)]
        [Route("/v1/corporations/{corporation_id}/bookmarks/", Version = EndpointVersion.V1, Preferred = true)]
        [Route("/dev/corporations/{corporation_id}/bookmarks/", Version = EndpointVersion.Dev)]
        Task<EsiResponsePagination<List<Bookmark>>> CorporationBookmarks(int corporationId, int page = 1);

        /// <summary>
        /// A list of your corporation’s bookmark folders
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="page">Which page of results to return. Default value: 1</param>
        [ProtectedEndpoint(RequiredScope = "esi-bookmarks.read_corporation_bookmarks.v1")]
        [Route("/latest/corporations/{corporation_id}/bookmarks/folders/", Version = EndpointVersion.Latest)]
        [Route("/legacy/corporations/{corporation_id}/bookmarks/folders/", Version = EndpointVersion.Legacy)]
        [Route("/v1/corporations/{corporation_id}/bookmarks/folders/", Version = EndpointVersion.V1, Preferred = true)]
        [Route("/dev/corporations/{corporation_id}/bookmarks/folders/", Version = EndpointVersion.Dev)]
        Task<EsiResponsePagination<List<CorporationFolder>>> CorporationBookmarkFolders(int corporationId, int page = 1);
    }
}
