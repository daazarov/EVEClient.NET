using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

using EVEClient.NET.DataContract;

namespace EVEClient.NET
{
    public interface IIncursionsLogic
    {
        /// <summary>
        /// Return a list of current incursions
        /// </summary>
        Task<EsiResponse<List<Incursion>>> IncursionList(CancellationToken cancellationToken = default);
    }
}
