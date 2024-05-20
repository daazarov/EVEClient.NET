using System.Collections.Generic;
using System.Threading.Tasks;

using EVEOnline.ESI.Communication.DataContract;

using static EVEOnline.ESI.Communication.Models.CommonRequests;

namespace EVEOnline.ESI.Communication.Logic
{
    internal class ClonesLogic : IClonesLogic
    {
        private readonly IEsiHttpClient<IClonesLogic> _esiClient;

        public ClonesLogic(IEsiHttpClient<IClonesLogic> esiClient)
        {
            _esiClient = esiClient;
        }
        public Task<EsiResponse<List<int>>> CloneImplants(int characterId) =>
            _esiClient.GetRequestAsync<CharacterIdRouteRequest, List<int>>(CharacterIdRouteRequest.Create(characterId));

        public Task<EsiResponse<Clones>> CloneList(int characterId) =>
            _esiClient.GetRequestAsync<CharacterIdRouteRequest, Clones>(CharacterIdRouteRequest.Create(characterId));
    }
}
