using System.Collections.Generic;
using System.Threading.Tasks;

using EVEOnline.Esi.Communication.DataContract;

using static EVEOnline.Esi.Communication.DataContract.Requests.Internal.CloneLogic;

namespace EVEOnline.Esi.Communication.Logic
{
    internal class ClonesLogic : IClonesLogic
    {
        private readonly IEsiHttpClient<IClonesLogic> _esiClient;

        public ClonesLogic(IEsiHttpClient<IClonesLogic> esiClient)
        {
            _esiClient = esiClient;
        }
        public Task<EsiResponse<List<int>>> GetCharacterCloneImplantsAsync(int characterId) =>
            _esiClient.GetRequestAsync<CharacterIdRouteRequest, List<int>>(CharacterIdRouteRequest.Create(characterId));

        public Task<EsiResponse<Clones>> GetCharacterClonesAsync(int characterId) =>
            _esiClient.GetRequestAsync<CharacterIdRouteRequest, Clones>(CharacterIdRouteRequest.Create(characterId));
    }
}
