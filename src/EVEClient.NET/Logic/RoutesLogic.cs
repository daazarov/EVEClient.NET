using System.Collections.Generic;
using System.Threading.Tasks;

using EVEClient.NET.DataContract;
using EVEClient.NET.Extensions;

using static EVEClient.NET.Models.RoutesRequests;

namespace EVEClient.NET.Logic
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
