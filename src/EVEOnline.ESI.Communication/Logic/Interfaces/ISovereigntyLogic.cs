using EVEOnline.ESI.Communication.Attributes;
using EVEOnline.ESI.Communication.DataContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVEOnline.ESI.Communication
{
    public interface ISovereigntyLogic
    {
        /// <summary>
        /// Shows sovereignty data for campaigns.
        /// </summary>
        [PublicEndpoint]
        [Route("/latest/sovereignty/campaigns/", Version = EndpointVersion.Latest)]
        [Route("/legacy/sovereignty/campaigns/", Version = EndpointVersion.Legacy)]
        [Route("/v1/sovereignty/campaigns/", Version = EndpointVersion.V1, Preferred = true)]
        [Route("/dev/sovereignty/campaigns/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<List<CampaignSovereignty>>> Campaigns();

        /// <summary>
        /// Shows sovereignty information for solar systems
        /// </summary>
        [PublicEndpoint]
        [Route("/latest/sovereignty/map/", Version = EndpointVersion.Latest)]
        [Route("/legacy/sovereignty/map/", Version = EndpointVersion.Legacy)]
        [Route("/v1/sovereignty/map/", Version = EndpointVersion.V1, Preferred = true)]
        [Route("/dev/sovereignty/map/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<List<SolarSystemSovereignty>>> SolarSystems();

        /// <summary>
        /// Shows sovereignty data for structures.
        /// </summary>
        [PublicEndpoint]
        [Route("/latest/sovereignty/structures/", Version = EndpointVersion.Latest)]
        [Route("/legacy/sovereignty/structures/", Version = EndpointVersion.Legacy)]
        [Route("/v1/sovereignty/structures/", Version = EndpointVersion.V1, Preferred = true)]
        [Route("/dev/sovereignty/structures/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<List<StructureSovereignty>>> Structures();
    }
}
