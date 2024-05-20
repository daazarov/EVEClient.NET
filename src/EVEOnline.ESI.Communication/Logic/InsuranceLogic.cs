using System.Collections.Generic;
using System.Threading.Tasks;

using EVEOnline.ESI.Communication.DataContract;

namespace EVEOnline.ESI.Communication.Logic
{
    internal class InsuranceLogic : IInsuranceLogic
    {
        private readonly IEsiHttpClient<IInsuranceLogic> _esiClient;

        public InsuranceLogic(IEsiHttpClient<IInsuranceLogic> esiClient)
        {
            _esiClient = esiClient;
        }

        public Task<EsiResponse<List<Insurance>>> InsuranceLevels() =>
            _esiClient.GetRequestAsync<List<Insurance>>();
    }
}
