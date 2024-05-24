using System.Collections.Generic;
using System.Threading.Tasks;

using EVEClient.NET.DataContract;

using static EVEClient.NET.Models.DogmaRequests;

namespace EVEClient.NET.Logic
{
    internal class DogmaLogic : IDogmaLogic
    {
        private readonly IEsiHttpClient<IDogmaLogic> _esiClient;

        public DogmaLogic(IEsiHttpClient<IDogmaLogic> esiClient)
        {
            _esiClient = esiClient;
        }

        public Task<EsiResponse<AttributeInfo>> AttributeInfo(int attributeId) =>
            _esiClient.GetRequestAsync<AttributeIdRouteRequest, AttributeInfo>(AttributeIdRouteRequest.Create(attributeId));

        public Task<EsiResponse<List<int>>> Attributes() =>
            _esiClient.GetRequestAsync<List<int>>();

        public Task<EsiResponse<EffectInfo>> EffectInfo(int effectId) =>
            _esiClient.GetRequestAsync<EffectIdRouteRequest, EffectInfo>(EffectIdRouteRequest.Create(effectId));

        public Task<EsiResponse<List<int>>> Effects() =>
            _esiClient.GetRequestAsync<List<int>>();

        public Task<EsiResponse<DynamicItemInfo>> DynamicItemInfo(long itemId, int typeId) =>
            _esiClient.GetRequestAsync<DynamicItemInfoRequest, DynamicItemInfo>(DynamicItemInfoRequest.Create(itemId, typeId));
    }
}
