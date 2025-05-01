using System.Threading.Tasks;

namespace EVEClient.NET
{
    public interface IResponseReader
    {
        Task<EsiResponse> ReadResponse(EsiResponseContext context);
    }

    public interface IResponseReader<TResponse>
    {
        Task<EsiResponse<TResponse>> ReadResponse(EsiResponseContext context);
    }
}
