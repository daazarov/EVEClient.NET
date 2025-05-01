using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

using EVEClient.NET.DataContract;

namespace EVEClient.NET
{
    public interface IAssetsLogic
    {
        /// <summary>
        /// Return a list of the characters assets
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="page">Which page of results to return. Default value: 1</param>
        Task<EsiResponsePagination<List<AssetItem>>> CharacterAssetList(int characterId, int page = 1, string? token = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Return locations for a set of item ids, which you can get from character assets endpoint.
        /// Coordinates for items in hangars or stations are set to (0,0,0)
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="itemIds">A list of item ids</param>
        Task<EsiResponse<List<ItemLocation>>> LocationAssets(int characterId, long[] itemIds, string? token = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Return names for a set of item ids, which you can get from character assets endpoint.
        /// Typically used for items that can customize names, like containers or ships.
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="itemIds">A list of item ids</param>
        Task<EsiResponse<List<ItemName>>> AssetItemNames(int characterId, long[] itemIds, string? token = null, CancellationToken cancellationToken = default);


        /// <summary>
        /// Return a list of the corporation assets
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="page">Which page of results to return. Default value: 1</param>
        /// <returns></returns>
        Task<EsiResponsePagination<List<AssetItem>>> CorporationAssetList(int corporationId, int page = 1, string? token = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Return locations for a set of item ids, which you can get from corporation assets endpoint.
        /// Coordinates for items in hangars or stations are set to (0,0,0)
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="itemIds">A list of item ids</param>
        Task<EsiResponse<List<ItemLocation>>> CorporationLocationAssets(int corporationId, long[] itemIds, string? token = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Return names for a set of item ids, which you can get from corporation assets endpoint.
        /// Only valid for items that can customize names, like containers or ships
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="itemIds">A list of item ids</param>
        Task<EsiResponse<List<ItemName>>> CorporationAssetItemNames(int corporationId, long[] itemIds, string? token = null, CancellationToken cancellationToken = default);
    }
}
