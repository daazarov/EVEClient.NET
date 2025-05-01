using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

using EVEClient.NET.DataContract;
using EVEClient.NET.Extensions;
using EVEClient.NET.Requests;

namespace EVEClient.NET.Logic
{
    internal class MarketLogic : IMarketLogic
    {
        private readonly IEsiHttpClient _client;
        private readonly IEsiRequestFactory _esiRequestFactory;

        public MarketLogic(IEsiHttpClient client, IEsiRequestFactory esiRequestFactory)
        {
            _client = client;
            _esiRequestFactory = esiRequestFactory;
        }

        public async Task<EsiResponse<List<OrderBase>>> CharacterOrders(int characterId, string? token = null, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.CharacterId] = characterId.ToString();
                },
                token: token);

            var response = await _client.Request(ESI.Endpoints.Market.CharacterOrders, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<List<OrderBase>>();
        }

        public async Task<EsiResponsePagination<List<OrderBase>>> CharacterOrdersHistory(int characterId, int page = 1, string? token = null, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.CharacterId] = characterId.ToString();
                    parameters.Query[ESI.Parameters.Query.Page] = page.ToString();
                },
                token: token);

            var response = await _client.Request(ESI.Endpoints.Market.CharacterOrdersHistory, request, cancellationToken: cancellationToken);

            return await response.ReadPaginatedEsiResponse<List<OrderBase>>();
        }

        public async Task<EsiResponsePagination<List<OrderBase>>> CorporationOrders(int corporationId, int page = 1, string? token = null, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.CorporationId] = corporationId.ToString();
                    parameters.Query[ESI.Parameters.Query.Page] = page.ToString();
                },
                token: token);

            var response = await _client.Request(ESI.Endpoints.Market.CorporationOrders, request, cancellationToken: cancellationToken);

            return await response.ReadPaginatedEsiResponse<List<OrderBase>>();
        }

        public async Task<EsiResponsePagination<List<OrderBase>>> CorporationOrdersHistory(int corporationId, int page = 1, string? token = null, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.CorporationId] = corporationId.ToString();
                    parameters.Query[ESI.Parameters.Query.Page] = page.ToString();
                },
                token: token);

            var response = await _client.Request(ESI.Endpoints.Market.CorporationOrdersHistory, request, cancellationToken: cancellationToken);

            return await response.ReadPaginatedEsiResponse<List<OrderBase>>();
        }

        public async Task<EsiResponse<List<Statistic>>> RegionStatistics(int regionId, int typeId, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.RegionId] = regionId.ToString();
                    parameters.Query[ESI.Parameters.Query.RegionTypeId] = typeId.ToString();
                });

            var response = await _client.Request(ESI.Endpoints.Market.RegionStatistics, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<List<Statistic>>();
        }

        public async Task<EsiResponsePagination<List<OrderBase>>> RegionOrders(int regionId, OrderType orderType = OrderType.All, int? typeId = null, int page = 1, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.RegionId] = regionId.ToString();
                    parameters.Query[ESI.Parameters.Query.Page] = page.ToString();
                    parameters.Query[ESI.Parameters.Query.RegionOrderType] = orderType.ToEsiString();
                });

            var response = await _client.Request(ESI.Endpoints.Market.RegionOrders, request, cancellationToken: cancellationToken);

            return await response.ReadPaginatedEsiResponse<List<OrderBase>>();
        }

        public async Task<EsiResponsePagination<List<int>>> ActiveRegionOrderTypes(int regionId, int page = 1, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.RegionId] = regionId.ToString();
                    parameters.Query[ESI.Parameters.Query.Page] = page.ToString();
                });

            var response = await _client.Request(ESI.Endpoints.Market.ActiveRegionOrderTypes, request, cancellationToken: cancellationToken);

            return await response.ReadPaginatedEsiResponse<List<int>>();
        }

        public async Task<EsiResponse<List<int>>> MarketGroups(CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateEmptyRequest();

            var response = await _client.Request(ESI.Endpoints.Market.MarketGroups, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<List<int>>();
        }

        public async Task<EsiResponse<MarketGroup>> MarketGroupInfo(int marketGroupId, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.MarketGroupId] = marketGroupId.ToString();
                });

            var response = await _client.Request(ESI.Endpoints.Market.MarketGroupInfo, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<MarketGroup>();
        }

        public async Task<EsiResponse<List<Price>>> TypePrices(CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateEmptyRequest();

            var response = await _client.Request(ESI.Endpoints.Market.TypePrices, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<List<Price>>();
        }

        public async Task<EsiResponsePagination<List<OrderBase>>> StructureOrders(long structureId, int page = 1, string? token = null, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.StructureId] = structureId.ToString();
                    parameters.Query[ESI.Parameters.Query.Page] = page.ToString();
                },
                token: token);

            var response = await _client.Request(ESI.Endpoints.Market.StructureOrders, request, cancellationToken: cancellationToken);

            return await response.ReadPaginatedEsiResponse<List<OrderBase>>();
        }
    }
}
