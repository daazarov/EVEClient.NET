using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

using EVEClient.NET.DataContract;

namespace EVEClient.NET
{
    public interface IWarsLogic
    {
        /// <summary>
        /// Return a list of wars
        /// </summary>
        /// <param name="maxWarId">Only return wars with ID smaller than this</param>
        Task<EsiResponse<List<int>>> Wars(int? maxWarId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Return details about a war
        /// </summary>
        /// <param name="warId">ID for a war</param>
        Task<EsiResponse<War>> WarDetails(int warId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Return a list of kills related to a war
        /// </summary>
        /// <param name="warId">A valid war ID</param>
        /// <param name="page">Which page of results to return. Default value: 1</param>
        Task<EsiResponsePagination<List<Kill>>> Kills(int warId, int page = 1, CancellationToken cancellationToken = default);
    }
}
