using System.Threading;
using System.Threading.Tasks;

using EVEClient.NET.DataContract;

namespace EVEClient.NET
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
        Task<EsiResponse<SearchResult>> Query(int characterId, string search, SearchCategory categories, bool strict = false, string? token = null, CancellationToken cancellationToken = default);
    }
}
