using System.Collections.Generic;
using System.Threading.Tasks;

using EVEOnline.ESI.Communication.DataContract;
using EVEOnline.ESI.Communication.Extensions;

using static EVEOnline.ESI.Communication.Models.RoutesRequests;

namespace EVEOnline.ESI.Communication.Logic
{
    internal class RoutesLogic : IRoutesLogic
    {
        private readonly IEsiHttpClient<IRoutesLogic> _esiClient;

        public RoutesLogic(IEsiHttpClient<IRoutesLogic> esiClient)
        {
            _esiClient = esiClient;
        }

        public Task<EsiResponse<List<int>>> Route(int origin, int destination, RoutesFlag flag = RoutesFlag.Shortest, int[] avoid = null, int[] connections = null) =>
            _esiClient.GetRequestAsync<RouteRequest, List<int>>(RouteRequest.Create(origin, destination, flag.ToEsiString(), avoid, connections));
    }
}
