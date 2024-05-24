using System.Collections.Generic;
using System.Threading.Tasks;

using EVEClient.NET.DataContract;

namespace EVEClient.NET.Logic
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
