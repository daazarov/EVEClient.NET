using System.Collections.Generic;
using System.Threading.Tasks;

using EVEClient.NET.DataContract;

using static EVEClient.NET.Models.CommonRequests;

namespace EVEClient.NET.Logic
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
