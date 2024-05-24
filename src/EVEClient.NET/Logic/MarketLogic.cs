using System.Collections.Generic;
using System.Threading.Tasks;

using EVEClient.NET.DataContract;
using EVEClient.NET.Extensions;

using static EVEClient.NET.Models.CommonRequests;
using static EVEClient.NET.Models.MarketRequests;

namespace EVEClient.NET.Logic
{
    internal class MarketLogic : IMarketLogic
    {
        private readonly IEsiHttpClient<IMarketLogic> _esiClient;

        public MarketLogic(IEsiHttpClient<IMarketLogic> esiClient)
        {
            _esiClient = esiClient;
        }

        public Task<EsiResponse<List<OrderBase>>> CharacterOrders(int characterId) =>
            _esiClient.GetRequestAsync<CharacterIdRouteRequest, List<OrderBase>>(CharacterIdRouteRequest.Create(characterId));

        public Task<EsiResponsePagination<List<OrderBase>>> CharacterOrdersHistory(int characterId, int page = 1) =>
            _esiClient.GetPaginationRequestAsync<PageBasedCharacterIdRouteRequest, List<OrderBase>>(PageBasedCharacterIdRouteRequest.Create(characterId, page));

        public Task<EsiResponsePagination<List<OrderBase>>> CorporationOrders(int corporationId, int page = 1) =>
            _esiClient.GetPaginationRequestAsync<PageBasedCorporationIdRouteRequest, List<OrderBase>>(PageBasedCorporationIdRouteRequest.Create(corporationId, page));

        public Task<EsiResponsePagination<List<OrderBase>>> CorporationOrdersHistory(int corporationId, int page = 1) =>
            _esiClient.GetPaginationRequestAsync<PageBasedCorporationIdRouteRequest, List<OrderBase>>(PageBasedCorporationIdRouteRequest.Create(corporationId, page));

        public Task<EsiResponse<List<Statistic>>> RegionStatistics(int regionId, int typeId) =>
            _esiClient.GetRequestAsync<RegionStatisticsRouteRequest, List<Statistic>>(RegionStatisticsRouteRequest.Create(regionId, typeId));

        public Task<EsiResponsePagination<List<OrderBase>>> RegionOrders(int regionId, OrderType orderType = OrderType.All, int? typeId = null, int page = 1) =>
            _esiClient.GetPaginationRequestAsync<RegionOrdersRequest, List<OrderBase>>(RegionOrdersRequest.Create(regionId, orderType.ToEsiString(), typeId, page));

        public Task<EsiResponsePagination<List<int>>> ActiveRegionOrderTypes(int regionId, int page = 1) =>
            _esiClient.GetPaginationRequestAsync<PageBasedRegionIdRouteRequest, List<int>>(PageBasedRegionIdRouteRequest.Create(regionId, page));

        public Task<EsiResponse<List<int>>> MarketGroups() =>
            _esiClient.GetRequestAsync<List<int>>();

        public Task<EsiResponse<MarketGroup>> MarketGroupInfo(int marketGroupId) =>
            _esiClient.GetRequestAsync<MarketGroupInfoRequest, MarketGroup>(MarketGroupInfoRequest.Create(marketGroupId));

        public Task<EsiResponse<List<Price>>> TypePrices() =>
            _esiClient.GetRequestAsync<List<Price>>();

        public Task<EsiResponsePagination<List<OrderBase>>> StructureOrders(long structureId, int page = 1) =>
            _esiClient.GetPaginationRequestAsync<PageBasedStructureIdRouteRequest, List<OrderBase>>(PageBasedStructureIdRouteRequest.Create(structureId, page));
    }
}
