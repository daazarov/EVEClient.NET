using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

using EVEClient.NET.DataContract;
using EVEClient.NET.Extensions;
using EVEClient.NET.Requests;

namespace EVEClient.NET.Logic
{
    internal class DogmaLogic : IDogmaLogic
    {
        private readonly IEsiHttpClient _client;
        private readonly IEsiRequestFactory _esiRequestFactory;

        public DogmaLogic(IEsiHttpClient client, IEsiRequestFactory esiRequestFactory)
        {
            _client = client;
            _esiRequestFactory = esiRequestFactory;
        }

        public async Task<EsiResponse<AttributeInfo>> AttributeInfo(int attributeId, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.AttributeId] = attributeId.ToString();
                });

            var response = await _client.Request(ESI.Endpoints.Dogma.AttributeInfo, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<AttributeInfo>();
        }

        public async Task<EsiResponse<List<int>>> Attributes(CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateEmptyRequest();

            var response = await _client.Request(ESI.Endpoints.Dogma.Attributes, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<List<int>>();
        }

        public async Task<EsiResponse<EffectInfo>> EffectInfo(int effectId, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.EffectId] = effectId.ToString();
                });

            var response = await _client.Request(ESI.Endpoints.Dogma.EffectInfo, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<EffectInfo>();
        }

        public async Task<EsiResponse<List<int>>> Effects(CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateEmptyRequest();

            var response = await _client.Request(ESI.Endpoints.Dogma.Effects, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<List<int>>();
        }

        public async Task<EsiResponse<DynamicItemInfo>> DynamicItemInfo(long itemId, int typeId, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.TypeId] = typeId.ToString();
                    parameters.Route[ESI.Parameters.Route.ItemId] = itemId.ToString();
                });

            var response = await _client.Request(ESI.Endpoints.Dogma.DynamicItemInfo, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<DynamicItemInfo>();
        }
    }
}
