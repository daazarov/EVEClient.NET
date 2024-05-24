using System.Collections.Generic;
using System.Threading.Tasks;

using EVEClient.NET.DataContract;

namespace EVEClient.NET.Logic
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
