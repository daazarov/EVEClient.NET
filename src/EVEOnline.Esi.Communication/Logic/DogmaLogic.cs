using System.Collections.Generic;
using System.Threading.Tasks;

using EVEOnline.Esi.Communication.DataContract;

using static EVEOnline.Esi.Communication.DataContract.Requests.Internal.DogmaRequests;

namespace EVEOnline.Esi.Communication.Logic
{
    internal class DogmaLogic : IDogmaLogic
    {
        private readonly IEsiHttpClient<IDogmaLogic> _esiClient;

        public DogmaLogic(IEsiHttpClient<IDogmaLogic> esiClient)
        {
            _esiClient = esiClient;
        }

        public Task<EsiResponse<AttributeInfo>> GetAttributeInfoAsync(int attributeId) =>
            _esiClient.GetRequestAsync<AttributeIdRouteRequest, AttributeInfo>(AttributeIdRouteRequest.Create(attributeId));

        public Task<EsiResponse<List<int>>> GetAttributesAsync() =>
            _esiClient.GetRequestAsync<List<int>>();

        public Task<EsiResponse<EffectInfo>> GetDogmaEffectInfoAsync(int effectId) =>
            _esiClient.GetRequestAsync<EffectIdRouteRequest, EffectInfo>(EffectIdRouteRequest.Create(effectId));

        public Task<EsiResponse<List<int>>> GetDogmaEffectsAsync() =>
            _esiClient.GetRequestAsync<List<int>>();

        public Task<EsiResponse<DynamicItemInfo>> GetDynamicItemInfoAsync(long itemId, int typeId) =>
            _esiClient.GetRequestAsync<DynamicItemInfoRequest, DynamicItemInfo>(DynamicItemInfoRequest.Create(itemId, typeId));
    }
}
