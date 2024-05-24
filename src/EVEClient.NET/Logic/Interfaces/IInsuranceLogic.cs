using System.Collections.Generic;
using System.Threading.Tasks;

using EVEClient.NET.Attributes;
using EVEClient.NET.DataContract;

namespace EVEClient.NET
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
        Task<EsiResponse<List<Insurance>>> InsuranceLevels();
    }
}
