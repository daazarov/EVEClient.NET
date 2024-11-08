using System.Threading.Tasks;

namespace EVEClient.NET
{
    public class DefaultGenericResponseReader<TResponse> : IResponseReader<TResponse>
    {
        public Task<EsiResponse<TResponse>> ReadResponse(EsiResponseContext context)
        {
            return Task.FromResult<EsiResponse<TResponse>>(new EsiResponseDefaultGeneric<TResponse>(context.Response));
        }
    }
}
