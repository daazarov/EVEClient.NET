using System.Collections.Generic;
using System.Threading.Tasks;

using EVEOnline.ESI.Communication.Attributes;
using EVEOnline.ESI.Communication.DataContract;

namespace EVEOnline.ESI.Communication
{
    public interface IInsuranceLogic
    {
        /// <summary>
        /// Return available insurance levels for all ship types
        /// </summary>
        [PublicEndpoint]
        [Route("/latest/insurance/prices/", Version = EndpointVersion.Latest)]
        [Route("/legacy/insurance/prices/", Version = EndpointVersion.Legacy)]
        [Route("/v1/insurance/prices/", Version = EndpointVersion.V1, Preferred = true)]
        [Route("/dev/insurance/prices/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<List<Insurance>>> GetInsuranceLevelsAsync();
    }
}
