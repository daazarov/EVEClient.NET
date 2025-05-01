using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

using EVEClient.NET.DataContract;
using EVEClient.NET.Extensions;
using EVEClient.NET.Requests;

namespace EVEClient.NET.Logic
{
    internal class RoutesLogic : IRoutesLogic
    {
        private readonly IEsiHttpClient _client;
        private readonly IEsiRequestFactory _esiRequestFactory;

        public RoutesLogic(IEsiHttpClient client, IEsiRequestFactory esiRequestFactory)
        {
            _client = client;
            _esiRequestFactory = esiRequestFactory;
        }

        public async Task<EsiResponse<List<int>>> Route(int origin, int destination, RoutesFlag flag = RoutesFlag.Shortest, int[]? avoid = null, int[]? connections = null, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.RouteDestination] = destination.ToString();
                    parameters.Route[ESI.Parameters.Route.RouteOrigin] = origin.ToString();
                    parameters.Query[ESI.Parameters.Query.RouteFlag] = flag.ToEsiString();
                    parameters.Query[ESI.Parameters.Query.AvoidSolarSystems] = avoid.ToQueryArrayParameterValue();
                    parameters.Query[ESI.Parameters.Query.SolarSystemsConnections] = connections.ToQueryArrayParameterValue();
                });

            var response = await _client.Request(ESI.Endpoints.Routes.Route, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<List<int>>();
        }
    }
}
