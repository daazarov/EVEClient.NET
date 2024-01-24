using System.Collections.Generic;
using System.Threading.Tasks;

using EVEOnline.Esi.Communication.DataContract;
using EVEOnline.Esi.Communication.Logic.Interfaces;

using static EVEOnline.Esi.Communication.DataContract.Requests.Internal.AllianceRequests;

namespace EVEOnline.Esi.Communication.Logic
{
    internal class AllianceLogic : IAllianceLogic
    {
        private readonly IEsiHttpClient<IAllianceLogic> _esiClient;

        public AllianceLogic(IEsiHttpClient<IAllianceLogic> esiClient)
        {
            _esiClient = esiClient;
        }

        public Task<EsiResponse<IEnumerable<int>>> GetAllianceCorporationsAsync(int allianceId) =>
            _esiClient.GetRequestAsync<AllianceIdRouteRequest, IEnumerable<int>>(AllianceIdRouteRequest.Create(allianceId));

        public Task<EsiResponse<AllianceIcon>> GetAllianceIconAsync(int allianceId) =>
            _esiClient.GetRequestAsync<AllianceIdRouteRequest, AllianceIcon>(AllianceIdRouteRequest.Create(allianceId));

        public Task<EsiResponse<Alliance>> GetAlliancePublicInformationAsync(int allianceId) =>
            _esiClient.GetRequestAsync<AllianceIdRouteRequest, Alliance>(AllianceIdRouteRequest.Create(allianceId));

        public Task<EsiResponse<IEnumerable<int>>> GetAlliancesAsync() =>
            _esiClient.GetRequestAsync<IEnumerable<int>>();
    }
}
