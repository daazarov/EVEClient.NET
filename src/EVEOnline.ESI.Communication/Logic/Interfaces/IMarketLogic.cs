using System.Collections.Generic;
using System.Threading.Tasks;

using EVEOnline.ESI.Communication.Attributes;
using EVEOnline.ESI.Communication.DataContract;

namespace EVEOnline.ESI.Communication
{
    public interface IMarketLogic
    {
        /// <summary>
        /// List open market orders placed by a character
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        [ProtectedEndpoint(RequiredScope = "esi-markets.read_character_orders.v1")]
        [Route("/latest/characters/{character_id}/orders/", Version = EndpointVersion.Latest)]
        [Route("/v2/characters/{character_id}/orders/", Version = EndpointVersion.V2, Preferred = true)]
        [Route("/dev/characters/{character_id}/orders/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<List<OrderBase>>> CharacterOrders(int characterId);

        /// <summary>
        /// List cancelled and expired market orders placed by a character up to 90 days in the past.
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="page">Which page of results to return. Default value: 1</param>
        [ProtectedEndpoint(RequiredScope = "esi-markets.read_character_orders.v1")]
        [Route("/latest/characters/{character_id}/orders/history/", Version = EndpointVersion.Latest)]
        [Route("/legacy/characters/{character_id}/orders/history/", Version = EndpointVersion.Legacy)]
        [Route("/v1/characters/{character_id}/orders/history/", Version = EndpointVersion.V1, Preferred = true)]
        [Route("/dev/characters/{character_id}/orders/history/", Version = EndpointVersion.Dev)]
        Task<EsiResponsePagination<List<OrderBase>>> CharacterOrdersHistory(int characterId, int page = 1);

        /// <summary>
        /// List open market orders placed on behalf of a corporation
        /// <para>Requires one of the following EVE corporation role(s): Accountant, Trader</para>
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="page">Which page of results to return. Default value: 1</param>
        [ProtectedEndpoint(RequiredScope = "esi-markets.read_corporation_orders.v1")]
        [Route("/latest/corporations/{corporation_id}/orders/", Version = EndpointVersion.Latest)]
        [Route("/v3/corporations/{corporation_id}/orders/", Version = EndpointVersion.V3, Preferred = true)]
        [Route("/dev/corporations/{corporation_id}/orders/", Version = EndpointVersion.Dev)]
        Task<EsiResponsePagination<List<OrderBase>>> CorporationOrders(int corporationId, int page = 1);

        /// <summary>
        /// List cancelled and expired market orders placed on behalf of a corporation up to 90 days in the past.
        /// <para>Requires one of the following EVE corporation role(s): Accountant, Trader</para>
        /// </summary>
        /// <param name="corporationId">An EVE corporation ID</param>
        /// <param name="page">Which page of results to return. Default value: 1</param>
        [ProtectedEndpoint(RequiredScope = "esi-markets.read_corporation_orders.v1")]
        [Route("/latest/corporations/{corporation_id}/orders/history/", Version = EndpointVersion.Latest)]
        [Route("/v2/corporations/{corporation_id}/orders/history/", Version = EndpointVersion.V2, Preferred = true)]
        [Route("/dev/corporations/{corporation_id}/orders/history/", Version = EndpointVersion.Dev)]
        Task<EsiResponsePagination<List<OrderBase>>> CorporationOrdersHistory(int corporationId, int page = 1);

        /// <summary>
        /// Return a list of historical market statistics for the specified type in a region
        /// </summary>
        /// <param name="regionId">Return statistics in this region</param>
        /// <param name="typeId">Return statistics for this type</param>
        [PublicEndpoint]
        [Route("/latest/markets/{region_id}/history/", Version = EndpointVersion.Latest)]
        [Route("/legacy/markets/{region_id}/history/", Version = EndpointVersion.Legacy)]
        [Route("/v1/markets/{region_id}/history/", Version = EndpointVersion.V1, Preferred = true)]
        [Route("/dev/markets/{region_id}/history/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<List<Statistic>>> RegionStatistics(int regionId, int typeId);

        /// <summary>
        /// Return a list of orders in a region
        /// </summary>
        /// <param name="regionId">Return orders in this region</param>
        /// <param name="orderType">Filter buy/sell orders, return all orders by default. If you query without type_id, we always return both buy and sell orders</param>
        /// <param name="typeId">Return orders only for this type</param>
        /// <param name="page">Which page of results to return. Default value: 1</param>
        [PublicEndpoint]
        [Route("/latest/markets/{region_id}/orders/", Version = EndpointVersion.Latest)]
        [Route("/legacy/markets/{region_id}/orders/", Version = EndpointVersion.Legacy)]
        [Route("/v1/markets/{region_id}/orders/", Version = EndpointVersion.V1, Preferred = true)]
        [Route("/dev/markets/{region_id}/orders/", Version = EndpointVersion.Dev)]
        Task<EsiResponsePagination<List<OrderBase>>> RegionOrders(int regionId, OrderType orderType = OrderType.All, int? typeId = null, int page = 1);

        /// <summary>
        /// Return a list of type IDs that have active orders in the region, for efficient market indexing.
        /// </summary>
        /// <param name="regionId">Return statistics in this region</param>
        /// <param name="page">Which page of results to return. Default value: 1</param>
        [PublicEndpoint]
        [Route("/latest/markets/{region_id}/types/", Version = EndpointVersion.Latest)]
        [Route("/legacy/markets/{region_id}/types/", Version = EndpointVersion.Legacy)]
        [Route("/v1/markets/{region_id}/types/", Version = EndpointVersion.V1, Preferred = true)]
        [Route("/dev/markets/{region_id}/types/", Version = EndpointVersion.Dev)]
        Task<EsiResponsePagination<List<int>>> ActiveRegionOrderTypes(int regionId, int page = 1);

        /// <summary>
        /// Get a list of item groups
        /// </summary>
        [PublicEndpoint]
        [Route("/latest/markets/groups/", Version = EndpointVersion.Latest)]
        [Route("/legacy/markets/groups/", Version = EndpointVersion.Legacy)]
        [Route("/v1/markets/groups/", Version = EndpointVersion.V1, Preferred = true)]
        [Route("/dev/markets/groups/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<List<int>>> MarketGroups();

        /// <summary>
        /// Get information on an item group
        /// </summary>
        /// <param name="marketGroupId">An Eve item group ID</param>
        [PublicEndpoint]
        [Route("/latest/markets/groups/{market_group_id}/", Version = EndpointVersion.Latest)]
        [Route("/legacy/markets/groups/{market_group_id}/", Version = EndpointVersion.Legacy)]
        [Route("/v1/markets/groups/{market_group_id}/", Version = EndpointVersion.V1, Preferred = true)]
        [Route("/dev/markets/groups/{market_group_id}/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<MarketGroup>> MarketGroupInfo(int marketGroupId);

        /// <summary>
        /// Return a list of prices
        /// </summary>
        [PublicEndpoint]
        [Route("/latest/markets/prices/", Version = EndpointVersion.Latest)]
        [Route("/legacy/markets/prices/", Version = EndpointVersion.Legacy)]
        [Route("/v1/markets/prices/", Version = EndpointVersion.V1, Preferred = true)]
        [Route("/dev/markets/prices/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<List<Price>>> TypePrices();

        /// <summary>
        /// Return all orders in a structure
        /// </summary>
        /// <param name="structureId">Return orders in this structure</param>
        /// <param name="page">Which page of results to return. Default value: 1</param>
        [ProtectedEndpoint(RequiredScope = "esi-markets.structure_markets.v1")]
        [Route("/latest/markets/structures/{structure_id}/", Version = EndpointVersion.Latest)]
        [Route("/legacy/markets/structures/{structure_id}/", Version = EndpointVersion.Legacy)]
        [Route("/v1markets/structures/{structure_id}/", Version = EndpointVersion.V1, Preferred = true)]
        [Route("/dev/markets/structures/{structure_id}/", Version = EndpointVersion.Dev)]
        Task<EsiResponsePagination<List<OrderBase>>> StructureOrders(long structureId, int page = 1);
    }
}
