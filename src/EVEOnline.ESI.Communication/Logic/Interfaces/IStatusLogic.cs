using System.Threading.Tasks;

using EVEOnline.ESI.Communication.Attributes;
using EVEOnline.ESI.Communication.DataContract;

namespace EVEOnline.ESI.Communication
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
