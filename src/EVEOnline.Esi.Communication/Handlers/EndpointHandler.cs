using System.Linq;
using System.Threading.Tasks;

using EVEOnline.ESI.Communication.Attributes;
using EVEOnline.ESI.Communication.Extensions;
using EVEOnline.ESI.Communication.Utilities;

namespace EVEOnline.ESI.Communication.Handlers
{
    internal class EndpointHandler : IHandler
    {
        private readonly ICustomEndpointRoutePriorityProvider _endpointRoutePriorityProvider;

        public EndpointHandler(ICustomEndpointRoutePriorityProvider endpointRoutePriorityProvider)
        {
            _endpointRoutePriorityProvider = endpointRoutePriorityProvider;
        }

        public async Task HandleAsync(EsiContext context, RequestDelegate next)
        {
            context.RequestContext.RouteQueue = (_endpointRoutePriorityProvider == null) ? SetupDefaultPriorityQueue(context) : SetupCustomPriorityQueue(context);

            await next.Invoke(context);
        }

        private RouteQueue SetupDefaultPriorityQueue(EsiContext context)
        {
            var routeQueue = new RouteQueue();

            var availableRoutes = ReflectionCacheAttributeAccessor.Instance.GetAttributes<RouteAttribute>(context.CallingContext.MethodInfo);

            foreach (var attribute in availableRoutes.Where(x => x.Preferred))
            {
                routeQueue.AddRoute(BuildUrlQuery(context, attribute.Template), new RoutePriority { Version = attribute.Version });
            }

            return routeQueue;
        }

        // todo
        private RouteQueue SetupCustomPriorityQueue(EsiContext context)
        {
            var routeQueue = new RouteQueue();
            var availableRoutes = ReflectionCacheAttributeAccessor.Instance.GetAttributes<RouteAttribute>(context.CallingContext.MethodInfo);
            var endpointPrioritySetting = _endpointRoutePriorityProvider.GetRoutePrioritiesForEndpoint(context.EndpointId);

            foreach (var setting in endpointPrioritySetting)
            {
                var route = availableRoutes.Where(x => x.Version == setting.Version).FirstOrDefault();

                if (route != null)
                {
                    routeQueue.AddRoute(BuildUrlQuery(context, route.Template), new RoutePriority { Version = route.Version, Order = setting.Order });
                }
            }

            return routeQueue;
        }

        private string BuildUrlQuery(EsiContext context, string template)
        {
            var url = UrlQueryBuilder.BuildRouteString(template, context.RequestContext.RouteParametersMap.AsNameValueCollection());

            return UrlQueryBuilder.BuildQueryString(url, context.RequestContext.QueryParametersMap.AsNameValueCollection());
        }
    }
}
