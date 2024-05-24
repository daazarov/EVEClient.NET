using System.Collections.Generic;
using System.Threading.Tasks;

using EVEClient.NET.Attributes;
using EVEClient.NET.DataContract;

namespace EVEClient.NET
{
    public interface IAllianceLogic
    {
        /// <summary>
        /// List all active player alliances
        /// </summary>
        [PublicEndpoint]
        [Route("/latest/alliances/", Version = EndpointVersion.Latest)]
        [Route("/v1/alliances/", Version = EndpointVersion.V1, Preferred = true)]
        [Route("/v2/alliances/", Version = EndpointVersion.V2, Preferred = true)]
        [Route("/legacy/alliances/", Version = EndpointVersion.Legacy)]
        [Route("/dev/alliances/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<List<int>>> ActiveAlliances();

        /// <summary>
        /// Public information about an alliance
        /// </summary>
        /// <param name="allianceId">An EVE alliance ID</param>
        [PublicEndpoint]
        [Route("/latest/alliances/{alliance_id}/", Version = EndpointVersion.Latest)]
        [Route("/v3/alliances/{alliance_id}/", Version = EndpointVersion.V3, Preferred = true)]
        [Route("/v4/alliances/{alliance_id}/", Version = EndpointVersion.V4, Preferred = true)]
        [Route("/legacy/alliances/{alliance_id}/", Version = EndpointVersion.Legacy)]
        [Route("/dev/alliances/{alliance_id}/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<Alliance>> PublicInformation(int allianceId);

        /// <summary>
        /// List all current member corporations of an alliance
        /// </summary>
        /// <param name="allianceId">An EVE alliance ID</param>
        [PublicEndpoint]
        [Route("/latest/alliances/{alliance_id}/corporations/", Version = EndpointVersion.Latest)]
        [Route("/v1/alliances/{alliance_id}/corporations/", Version = EndpointVersion.V1, Preferred = true)]
        [Route("/v2/alliances/{alliance_id}/corporations/", Version = EndpointVersion.V2, Preferred = true)]
        [Route("/legacy/alliances/{alliance_id}/corporations/", Version = EndpointVersion.Legacy)]
        [Route("/dev/alliances/{alliance_id}/corporations/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<List<int>>> CorporationsInAlliance(int allianceId);

        /// <summary>
        /// Get the icon urls for a alliance
        /// </summary>
        /// <param name="allianceId">An EVE alliance ID</param>
        /// <returns></returns>
        [PublicEndpoint]
        [Route("/latest/alliances/{alliance_id}/icons/", Version = EndpointVersion.Latest)]
        [Route("/v1/alliances/{alliance_id}/icons/", Version = EndpointVersion.V1, Preferred = true)]
        [Route("/legacy/alliances/{alliance_id}/icons/", Version = EndpointVersion.Legacy)]
        [Route("/dev/alliances/{alliance_id}/icons/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<AllianceIcon>> AllianceIcon(int allianceId);
    }
}
