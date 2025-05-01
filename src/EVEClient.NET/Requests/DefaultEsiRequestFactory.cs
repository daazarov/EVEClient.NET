using System;
using System.Threading.Tasks;

namespace EVEClient.NET.Requests
{
    public class DefaultEsiRequestFactory : IEsiRequestFactory
    {
        public Task<EsiRequest> CreateEmptyRequest(string? token = null)
        {
            return Task.FromResult<EsiRequest>(new EsiRequestEmpty() { Token = token });
        }

        public Task<EsiRequest> CreateRequest(Action<Parameters> configure, string? token = null)
        {
            ArgumentNullException.ThrowIfNull(configure);

            return Task.FromResult<EsiRequest>(new EsiRequestDefault(configure) { Token = token });
        }
    }
}
