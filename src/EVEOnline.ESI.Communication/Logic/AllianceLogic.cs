using System.Collections.Generic;
using System.Threading.Tasks;

using EVEOnline.ESI.Communication.DataContract;

using static EVEOnline.ESI.Communication.Models.CommonRequests;

namespace EVEOnline.ESI.Communication.Logic
{
    internal class AllianceLogic : IAllianceLogic
    {
        private readonly IEsiHttpClient<IAllianceLogic> _esiClient;

        public AllianceLogic(IEsiHttpClient<IAllianceLogic> esiClient)
        {
            _esiClient = esiClient;
        }

        public Task<EsiResponse<List<int>>> CorporationsInAlliance(int allianceId) =>
            _esiClient.GetRequestAsync<AllianceIdRouteRequest, List<int>>(AllianceIdRouteRequest.Create(allianceId));

        public Task<EsiResponse<AllianceIcon>> AllianceIcon(int allianceId) =>
            _esiClient.GetRequestAsync<AllianceIdRouteRequest, AllianceIcon>(AllianceIdRouteRequest.Create(allianceId));

        public Task<EsiResponse<Alliance>> PublicInformation(int allianceId) =>
            _esiClient.GetRequestAsync<AllianceIdRouteRequest, Alliance>(AllianceIdRouteRequest.Create(allianceId));

        public Task<EsiResponse<List<int>>> ActiveAlliances() =>
            _esiClient.GetRequestAsync<List<int>>();
    }
}
