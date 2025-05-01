using System.Threading.Tasks;

namespace EVEClient.NET
{
    public class DefaultResponseReader : IResponseReader
    {
        public Task<EsiResponse> ReadResponse(EsiResponseContext context)
        {
            return Task.FromResult<EsiResponse>(new EsiResponseDefault(context.Response));
        }
    }
}
