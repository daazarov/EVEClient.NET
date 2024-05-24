using System.Collections.Generic;
using System.Threading.Tasks;

using EVEClient.NET.Attributes;
using EVEClient.NET.DataContract;

namespace EVEClient.NET
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
