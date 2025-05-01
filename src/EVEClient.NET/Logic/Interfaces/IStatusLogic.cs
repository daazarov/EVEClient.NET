using System.Threading;
using System.Threading.Tasks;

using EVEClient.NET.DataContract;

namespace EVEClient.NET
{
    public interface IStatusLogic
    {
        /// <summary>
        /// EVE Server status
        /// </summary>
        Task<EsiResponse<ServerStatus>> ServerStatus(CancellationToken cancellationToken = default);
    }
}
