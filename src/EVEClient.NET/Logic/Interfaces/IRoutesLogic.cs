using System.Collections.Generic;
using System.Threading.Tasks;

using EVEClient.NET.Attributes;
using EVEClient.NET.DataContract;

namespace EVEClient.NET
{
    public interface IRoutesLogic
    {
        /// <summary>
        /// Get the systems between origin and destination
        /// </summary>
        /// <param name="origin">Origin solar system ID</param>
        /// <param name="destination">Destination solar system ID</param>
        /// <param name="flag">Route security preference. Default value : shortest</param>
        /// <param name="avoid">Avoid solar system ID(s)</param>
        /// <param name="connections">Connected solar system pairs</param>
        /// <returns>Solar systems in route</returns>
        [PublicEndpoint]
        [Route("/latest/route/{origin}/{destination}/", Version = EndpointVersion.Latest)]
        [Route("/legacy/route/{origin}/{destination}/", Version = EndpointVersion.Legacy)]
        [Route("/v1/route/{origin}/{destination}/", Version = EndpointVersion.V1, Preferred = true)]
        [Route("/dev/route/{origin}/{destination}/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<List<int>>> Route(int origin, int destination, RoutesFlag flag = RoutesFlag.Shortest, int[] avoid = null, int[] connections = null);
    }
}
