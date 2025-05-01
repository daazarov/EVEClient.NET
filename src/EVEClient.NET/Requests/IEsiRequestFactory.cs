using System;
using System.Threading.Tasks;

namespace EVEClient.NET.Requests
{
    public interface IEsiRequestFactory
    {
        Task<EsiRequest> CreateRequest(Action<Parameters> configure, string? token = null);
        Task<EsiRequest> CreateEmptyRequest(string? token = null);
    }
}
