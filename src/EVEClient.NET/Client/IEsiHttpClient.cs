using System.Runtime.CompilerServices;
using System.Threading.Tasks;

using EVEClient.NET.Models;

namespace EVEClient.NET
{
    internal interface IEsiHttpClient<T>
    {
        Task<EsiResponse<TResponse>> GetRequestAsync<TRequest, TResponse>(TRequest requestModel, string? token = null, [CallerMemberName] string memberName = "")
            where TRequest : IRequestModel;
        Task<EsiResponse<TResponse>> GetRequestAsync<TResponse>(string? token = null, [CallerMemberName] string memberName = "");
        Task<EsiResponsePagination<TResponse>> GetPaginationRequestAsync<TRequest, TResponse>(TRequest requestModel, string? token = null, [CallerMemberName] string memberName = "")
            where TRequest : IRequestModel;
        Task<EsiResponse<TResponse>> PostRequestAsync<TRequest, TResponse>(TRequest requestModel, string? token = null, [CallerMemberName] string memberName = "")
            where TRequest : IRequestModel;
        Task<EsiResponse> PostNoContentRequestAsync<TRequest>(TRequest requestModel, string? token = null, [CallerMemberName] string memberName = "")
            where TRequest : IRequestModel;
        Task<EsiResponse> PutRequestAsync<TRequest>(TRequest requestModel, string? token = null, [CallerMemberName] string memberName = "")
            where TRequest : IRequestModel;
        Task<EsiResponse> DeleteRequestAsync<TRequest>(TRequest requestModel, string? token = null, [CallerMemberName] string memberName = "")
            where TRequest : IRequestModel;
    }
}
