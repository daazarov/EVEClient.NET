using System.Collections.Generic;
using System.Threading.Tasks;

using EVEOnline.Esi.Communication.DataContract;

using static EVEOnline.Esi.Communication.DataContract.Requests.Internal.FittingsRequests;

namespace EVEOnline.Esi.Communication.Logic
{
    internal class FittingsLogic : IFittingsLogic
    {
        private readonly IEsiHttpClient<IFittingsLogic> _esiClient;

        public FittingsLogic(IEsiHttpClient<IFittingsLogic> esiClient)
        {
            _esiClient = esiClient;
        }

        public Task<EsiResponse> DeleteCharacterFittingAsync(int characterId, int fittingId) =>
            _esiClient.DeleteRequestAsync<DeleteFittingRequest>(DeleteFittingRequest.Create(characterId, fittingId));

        public Task<EsiResponse<List<Fitting>>> GetCharacterFittingsAsync(int characterId) =>
            _esiClient.GetRequestAsync<CharacterIdRouteRequest, List<Fitting>>(CharacterIdRouteRequest.Create(characterId));

        public Task<EsiResponse<NewFittingResponse>> NewCharacterFittingAsync(int characterId, NewFitting fitting) =>
            _esiClient.PostRequestAsync<NewFittingRequest, NewFittingResponse>(NewFittingRequest.Create(characterId, fitting));
    }
}
