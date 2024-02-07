using EVEOnline.ESI.Communication.Models;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace EVEOnline.ESI.Communication
{
    internal interface IEsiHttpClient<T>
    {
        Task<EsiResponse<TResponse>> GetRequestAsync<TRequest, TResponse>(TRequest requestModel, [CallerMemberName] string memberName = "")
            where TRequest : IRequestModel;
        Task<EsiResponse<TResponse>> GetRequestAsync<TResponse>([CallerMemberName] string memberName = "");
        Task<EsiResponsePagination<TResponse>> GetPaginationRequestAsync<TResponse>([CallerMemberName] string memberName = "");
        Task<EsiResponsePagination<TResponse>> GetPaginationRequestAsync<TRequest, TResponse>(TRequest requestModel, [CallerMemberName] string memberName = "")
            where TRequest : IRequestModel;
        Task<EsiResponse<TResponse>> PostRequestAsync<TRequest, TResponse>(TRequest requestModel, [CallerMemberName] string memberName = "")
            where TRequest : IRequestModel;
        Task<EsiResponse> PostNoContentRequestAsync<TRequest>(TRequest requestModel, [CallerMemberName] string memberName = "")
            where TRequest : IRequestModel;
        Task<EsiResponse> PutNoContentRequestAsync<TRequest>(TRequest requestModel, [CallerMemberName] string memberName = "")
            where TRequest : IRequestModel;
        Task<EsiResponse> DeleteRequestAsync<TRequest>(TRequest requestModel, [CallerMemberName] string memberName = "")
            where TRequest : IRequestModel;
    }
}
