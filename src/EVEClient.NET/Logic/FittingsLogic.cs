using System.Collections.Generic;
using System.Threading.Tasks;

using EVEClient.NET.DataContract;
using EVEClient.NET.Models;

using static EVEClient.NET.Models.CommonRequests;
using static EVEClient.NET.Models.FittingsRequests;

namespace EVEClient.NET.Logic
{
    internal class FittingsLogic : IFittingsLogic
    {
        private readonly IEsiHttpClient<IFittingsLogic> _esiClient;

        public FittingsLogic(IEsiHttpClient<IFittingsLogic> esiClient)
        {
            _esiClient = esiClient;
        }

        public Task<EsiResponse> DeleteFitting(int characterId, int fittingId, string? token = null) =>
            _esiClient.DeleteRequestAsync<DeleteFittingRequest>(DeleteFittingRequest.Create(characterId, fittingId), token);

        public Task<EsiResponse<List<Fitting>>> GetFittings(int characterId, string? token = null) =>
            _esiClient.GetRequestAsync<CharacterIdRouteRequest, List<Fitting>>(CharacterIdRouteRequest.Create(characterId), token);

        public Task<EsiResponse<NewFittingResponse>> NewFitting(int characterId, NewFitting fitting, string? token = null) =>
            _esiClient.PostRequestAsync<NewFittingRequest, NewFittingResponse>(NewFittingRequest.Create(characterId, NewFittingBodyModel.FromDataContractModel(fitting)), token);
    }
}
