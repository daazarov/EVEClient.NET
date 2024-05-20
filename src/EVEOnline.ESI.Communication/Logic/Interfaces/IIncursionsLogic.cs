using System.Collections.Generic;
using System.Threading.Tasks;

using EVEOnline.ESI.Communication.Attributes;
using EVEOnline.ESI.Communication.DataContract;

namespace EVEOnline.ESI.Communication
{
    public interface IIncursionsLogic
    {
        /// <summary>
        /// Return a list of current incursions
        /// </summary>
        [PublicEndpoint]
        [Route("/latest/incursions/", Version = EndpointVersion.Latest)]
        [Route("/legacy/incursions/", Version = EndpointVersion.Legacy)]
        [Route("/v1/incursions/", Version = EndpointVersion.V1, Preferred = true)]
        [Route("/dev/incursions/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<List<Incursion>>> IncursionList();
    }
}
