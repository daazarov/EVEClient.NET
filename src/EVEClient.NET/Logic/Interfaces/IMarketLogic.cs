using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

using EVEClient.NET.DataContract;

namespace EVEClient.NET
{
    public interface IMarketLogic
    {
        /// <summary>
        /// List open market orders placed by a character
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        Task<EsiResponse<List<OrderBase>>> CharacterOrders(int characterId, string? token = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// List cancelled and expired market orders placed by a character up to 90 days in the past.
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="page">Which page of results to return. Default value: 1</param>
        Task<EsiResponsePagination<List<OrderBase>>> CharacterOrdersHistory(int characterId, int page = 1, string? token = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// List open market orders placed on behalf of a corporation
        /// <para>Requires one of the following EVE corporation role(s): Accountant, Trader</para>
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="page">Which page of results to return. Default value: 1</param>
        Task<EsiResponsePagination<List<OrderBase>>> CorporationOrders(int corporationId, int page = 1, string? token = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// List cancelled and expired market orders placed on behalf of a corporation up to 90 days in the past.
        /// <para>Requires one of the following EVE corporation role(s): Accountant, Trader</para>
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="page">Which page of results to return. Default value: 1</param>
        Task<EsiResponsePagination<List<OrderBase>>> CorporationOrdersHistory(int corporationId, int page = 1, string? token = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Return a list of historical market statistics for the specified type in a region
        /// </summary>
        /// <param name="regionId">Return statistics in this region</param>
        /// <param name="typeId">Return statistics for this type</param>
        Task<EsiResponse<List<Statistic>>> RegionStatistics(int regionId, int typeId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Return a list of orders in a region
        /// </summary>
        /// <param name="regionId">Return orders in this region</param>
        /// <param name="orderType">Filter buy/sell orders, return all orders by default. If you query without type_id, we always return both buy and sell orders</param>
        /// <param name="typeId">Return orders only for this type</param>
        /// <param name="page">Which page of results to return. Default value: 1</param>
        Task<EsiResponsePagination<List<OrderBase>>> RegionOrders(int regionId, OrderType orderType = OrderType.All, int? typeId = null, int page = 1, CancellationToken cancellationToken = default);

        /// <summary>
        /// Return a list of type IDs that have active orders in the region, for efficient market indexing.
        /// </summary>
        /// <param name="regionId">Return statistics in this region</param>
        /// <param name="page">Which page of results to return. Default value: 1</param>
        Task<EsiResponsePagination<List<int>>> ActiveRegionOrderTypes(int regionId, int page = 1, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get a list of item groups
        /// </summary>
        Task<EsiResponse<List<int>>> MarketGroups(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get information on an item group
        /// </summary>
        /// <param name="marketGroupId">An Eve item group ID</param>
        Task<EsiResponse<MarketGroup>> MarketGroupInfo(int marketGroupId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Return a list of prices
        /// </summary>
        Task<EsiResponse<List<Price>>> TypePrices(CancellationToken cancellationToken = default);

        /// <summary>
        /// Return all orders in a structure
        /// </summary>
        /// <param name="structureId">Return orders in this structure</param>
        /// <param name="page">Which page of results to return. Default value: 1</param>
        Task<EsiResponsePagination<List<OrderBase>>> StructureOrders(long structureId, int page = 1, string? token = null, CancellationToken cancellationToken = default);
    }
}
