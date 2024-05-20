using System.Collections.Generic;
using System.Threading.Tasks;

using EVEOnline.ESI.Communication.Attributes;
using EVEOnline.ESI.Communication.DataContract;

namespace EVEOnline.ESI.Communication
{
    public interface IWarsLogic
    {
        /// <summary>
        /// Return a list of wars
        /// </summary>
        /// <param name="maxWarId">Only return wars with ID smaller than this</param>
        [PublicEndpoint]
        [Route("/latest/wars/", Version = EndpointVersion.Latest)]
        [Route("/legacy/wars/", Version = EndpointVersion.Legacy)]
        [Route("/v1/wars/", Version = EndpointVersion.V1, Preferred = true)]
        [Route("/dev/wars/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<List<int>>> Wars(int? maxWarId);

        /// <summary>
        /// Return details about a war
        /// </summary>
        /// <param name="warId">ID for a war</param>
        [PublicEndpoint]
        [Route("/latest/wars/{war_id}/", Version = EndpointVersion.Latest)]
        [Route("/legacy/wars/{war_id}/", Version = EndpointVersion.Legacy)]
        [Route("/v1/wars/{war_id}/", Version = EndpointVersion.V1, Preferred = true)]
        [Route("/dev/wars/{war_id}/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<War>> WarDetails(int warId);

        /// <summary>
        /// Return a list of kills related to a war
        /// </summary>
        /// <param name="warId">A valid war ID</param>
        /// <param name="page">Which page of results to return. Default value: 1</param>
        [PublicEndpoint]
        [Route("/latest/wars/{war_id}/killmails/", Version = EndpointVersion.Latest)]
        [Route("/legacy/wars/{war_id}/killmails/", Version = EndpointVersion.Legacy)]
        [Route("/v1/wars/{war_id}/killmails/", Version = EndpointVersion.V1, Preferred = true)]
        [Route("/dev/wars/{war_id}/killmails/", Version = EndpointVersion.Dev)]
        Task<EsiResponsePagination<List<Kill>>> Kills(int warId, int page = 1);
    }
}
