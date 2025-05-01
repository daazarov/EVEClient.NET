using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

using EVEClient.NET.DataContract;

namespace EVEClient.NET
{
    public interface ISovereigntyLogic
    {
        /// <summary>
        /// Shows sovereignty data for campaigns.
        /// </summary>
        Task<EsiResponse<List<CampaignSovereignty>>> Campaigns(CancellationToken cancellationToken = default);

        /// <summary>
        /// Shows sovereignty information for solar systems
        /// </summary>
        Task<EsiResponse<List<SolarSystemSovereignty>>> SolarSystems(CancellationToken cancellationToken = default);

        /// <summary>
        /// Shows sovereignty data for structures.
        /// </summary>
        Task<EsiResponse<List<StructureSovereignty>>> Structures(CancellationToken cancellationToken = default);
    }
}
