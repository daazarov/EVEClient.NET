using System.Collections.Generic;
using System.Threading.Tasks;

using EVEOnline.ESI.Communication.Attributes;
using EVEOnline.ESI.Communication.DataContract;

namespace EVEOnline.ESI.Communication
{
    public interface ISearchLogic
    {
        /// <summary>
        /// Search for entities that match a given sub-string.
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="search">The string to search on</param>
        /// <param name="categories">Type of entities to search for.
        /// <para>Use the bit flag to enumerate categories if needed. For example: <code>SearchCategory.Agent | SearchCategory.Alliance</code></para></param>
        /// <param name="strict">Whether the search should be a strict match. Default: false</param>

        [ProtectedEndpoint(RequiredScope = "esi-search.search_structures.v1")]
        [Route("/latest/characters/{character_id}/search/", Version = EndpointVersion.Latest)]
        [Route("/legacy/characters/{character_id}/search/", Version = EndpointVersion.Legacy)]
        [Route("/v3/characters/{character_id}/search/", Version = EndpointVersion.V3, Preferred = true)]
        [Route("/dev/characters/{character_id}/search/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<SearchResult>> Query(int characterId, string search, SearchCategory categories, bool strict = false);
    }
}
