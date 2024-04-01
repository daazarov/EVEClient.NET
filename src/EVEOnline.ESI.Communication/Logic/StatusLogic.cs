using System.Threading.Tasks;

using EVEOnline.ESI.Communication.DataContract;

namespace EVEOnline.ESI.Communication.Logic
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
