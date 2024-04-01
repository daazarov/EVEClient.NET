using System.Collections.Generic;
using System.Threading.Tasks;

using EVEOnline.ESI.Communication.DataContract;

namespace EVEOnline.ESI.Communication.Logic
{
    internal class SovereigntyLogic : ISovereigntyLogic
    {
        private readonly IEsiHttpClient<ISovereigntyLogic> _esiClient;

        public SovereigntyLogic(IEsiHttpClient<ISovereigntyLogic> esiClient)
        {
            _esiClient = esiClient;
        }

        public Task<EsiResponse<List<CampaignSovereignty>>> Campaigns() => _esiClient.GetRequestAsync<List<CampaignSovereignty>>();

        public Task<EsiResponse<List<SolarSystemSovereignty>>> SolarSystems() => _esiClient.GetRequestAsync<List<SolarSystemSovereignty>>();

        public Task<EsiResponse<List<StructureSovereignty>>> Structures() => _esiClient.GetRequestAsync<List<StructureSovereignty>>();
    }
}
