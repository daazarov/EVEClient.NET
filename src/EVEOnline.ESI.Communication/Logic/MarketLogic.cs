using System.Collections.Generic;
using System.Threading.Tasks;

using EVEOnline.ESI.Communication.DataContract;
using EVEOnline.ESI.Communication.Extensions;

using static EVEOnline.ESI.Communication.Models.CommonRequests;
using static EVEOnline.ESI.Communication.Models.MarketRequests;

namespace EVEOnline.ESI.Communication.Logic
{
    internal class MarketLogic : IMarketLogic
    {
        private readonly IEsiHttpClient<IMarketLogic> _esiClient;

        public MarketLogic(IEsiHttpClient<IMarketLogic> esiClient)
        {
            _esiClient = esiClient;
        }

        public Task<EsiResponse<List<OrderBase>>> GetCharacterOrders(int characterId) =>
            _esiClient.GetRequestAsync<CharacterIdRouteRequest, List<OrderBase>>(CharacterIdRouteRequest.Create(characterId));

        public Task<EsiResponsePagination<List<OrderBase>>> GetCharacterOrdersHistory(int characterId, int page = 1) =>
            _esiClient.GetPaginationRequestAsync<PageBasedCharacterIdRouteRequest, List<OrderBase>>(PageBasedCharacterIdRouteRequest.Create(characterId, page));

        public Task<EsiResponsePagination<List<OrderBase>>> GetCorporationOrders(int corporationId, int page = 1) =>
            _esiClient.GetPaginationRequestAsync<PageBasedCorporationIdRouteRequest, List<OrderBase>>(PageBasedCorporationIdRouteRequest.Create(corporationId, page));

        public Task<EsiResponsePagination<List<OrderBase>>> GetCorporationOrdersHistory(int corporationId, int page = 1) =>
            _esiClient.GetPaginationRequestAsync<PageBasedCorporationIdRouteRequest, List<OrderBase>>(PageBasedCorporationIdRouteRequest.Create(corporationId, page));

        public Task<EsiResponse<List<Statistic>>> GetRegionStatistics(int regionId, int typeId) =>
            _esiClient.GetRequestAsync<RegionStatisticsRouteRequest, List<Statistic>>(RegionStatisticsRouteRequest.Create(regionId, typeId));

        public Task<EsiResponsePagination<List<OrderBase>>> GetRegionOrders(int regionId, OrderType orderType = OrderType.All, int? typeId = null, int page = 1) =>
            _esiClient.GetPaginationRequestAsync<RegionOrdersRequest, List<OrderBase>>(RegionOrdersRequest.Create(regionId, orderType.ToEsiString(), typeId, page));

        public Task<EsiResponsePagination<List<int>>> GetActiveOrderTypes(int regionId, int page = 1) =>
            _esiClient.GetPaginationRequestAsync<PageBasedRegionIdRouteRequest, List<int>>(PageBasedRegionIdRouteRequest.Create(regionId, page));

        public Task<EsiResponse<List<int>>> GetItemGroups() =>
            _esiClient.GetRequestAsync<List<int>>();

        public Task<EsiResponse<MarketGroup>> GetItemGroupInfo(int marketGroupId) =>
            _esiClient.GetRequestAsync<MarketGroupInfoRequest, MarketGroup>(MarketGroupInfoRequest.Create(marketGroupId));

        public Task<EsiResponse<List<Price>>> GetPrices() =>
            _esiClient.GetRequestAsync<List<Price>>();

        public Task<EsiResponsePagination<List<OrderBase>>> GetStructureOrders(long structureId, int page = 1) =>
            _esiClient.GetPaginationRequestAsync<PageBasedStructureIdRouteRequest, List<OrderBase>>(PageBasedStructureIdRouteRequest.Create(structureId, page));
    }
}
