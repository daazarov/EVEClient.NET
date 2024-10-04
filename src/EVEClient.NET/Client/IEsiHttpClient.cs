using System.Threading;
using System.Threading.Tasks;

using EVEClient.NET.Models;

namespace EVEClient.NET
{
    public interface IEsiHttpClient
    {
        Task<EsiResponseContext> Request(string endpointId,
            EsiRequest request,
            ExecutionOptions options = ExecutionOptions.None,
            CancellationToken cancellationToken = default);
    }
}
