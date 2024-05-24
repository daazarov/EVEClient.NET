using System.Threading.Tasks;

using EVEClient.NET.Attributes;
using EVEClient.NET.DataContract;

namespace EVEClient.NET
{
    public interface IStatusLogic
    {
        /// <summary>
        /// EVE Server status
        /// </summary>
        [PublicEndpoint]
        [Route("/latest/status/", Version = EndpointVersion.Latest)]
        [Route("/legacy/status/", Version = EndpointVersion.Legacy)]
        [Route("/v1/status/", Version = EndpointVersion.V1, Preferred = true)]
        [Route("/v2/status/", Version = EndpointVersion.V2, Preferred = true)]
        [Route("/dev/status/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<ServerStatus>> ServerStatus();
    }
}
