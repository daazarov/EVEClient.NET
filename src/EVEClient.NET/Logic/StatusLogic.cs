using System.Threading.Tasks;

using EVEClient.NET.DataContract;

namespace EVEClient.NET.Logic
{
    internal class StatusLogic : IStatusLogic
    {
        private readonly IEsiHttpClient<IStatusLogic> _esiClient;

        public StatusLogic(IEsiHttpClient<IStatusLogic> esiClient)
        {
            _esiClient = esiClient;
        }

        public Task<EsiResponse<ServerStatus>> ServerStatus() => _esiClient.GetRequestAsync<ServerStatus>();
    }
}
