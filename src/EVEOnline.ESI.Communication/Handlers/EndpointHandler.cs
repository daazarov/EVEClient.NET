using System;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using EVEOnline.ESI.Communication.Attributes;
using EVEOnline.ESI.Communication.Utilities;

namespace EVEOnline.ESI.Communication.Handlers
{
    public class EndpointHandler : IHandler
    {
        private readonly ICustomEndpointRoutePriorityProvider _endpointRoutePriorityProvider;

        public EndpointHandler() : this(null)
        { }

        public EndpointHandler(ICustomEndpointRoutePriorityProvider endpointRoutePriorityProvider)
        {
            _endpointRoutePriorityProvider = endpointRoutePriorityProvider;
        }

        protected virtual bool CustomPriorityEnabled => _endpointRoutePriorityProvider != null;

        public async Task HandleAsync(EsiContext context, RequestDelegate next)
        {
            context.RequestContext.RouteQueue = CustomPriorityEnabled ? SetupCustomPriorityQueue(context) : SetupDefaultPriorityQueue(context);

            await next.Invoke(context);
        }

        protected virtual RouteQueue SetupDefaultPriorityQueue(EsiContext context)
        {
            var routeQueue = new RouteQueue();

            var availableRoutes = ReflectionCacheAttributeAccessor.Instance.GetAttributes<RouteAttribute>(context.CallingContext.MethodInfo);

            foreach (var attribute in availableRoutes.Where(x => x.Preferred))
            {
                routeQueue.AddRoute(BuildUrlQuery(context, attribute.Template), new RoutePriority { Version = attribute.Version });
            }

            return routeQueue;
        }

        protected virtual RouteQueue SetupCustomPriorityQueue(EsiContext context)
        {
            var endpointPrioritySetting = _endpointRoutePriorityProvider.GetRoutePrioritiesForEndpoint(context.EndpointId);

            if (endpointPrioritySetting == null || !endpointPrioritySetting.Any())
            {
                return SetupDefaultPriorityQueue(context);
            }

            var routeQueue = new RouteQueue();
            var availableRoutes = ReflectionCacheAttributeAccessor.Instance.GetAttributes<RouteAttribute>(context.CallingContext.MethodInfo);

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
            var path = string.Empty;
            var builder = new UriBuilder();
            var query = HttpUtility.ParseQueryString(string.Empty);

            foreach (var kvp in context.RequestContext.PathParametersMap)
            {
                path = template.Replace($"{{{kvp.Key}}}", kvp.Value);
            }

            foreach (var kvp in context.RequestContext.QueryParametersMap)
            {
                query[kvp.Key] = kvp.Value;
            }

            return string.Concat(path, "?", query.ToString());
        }
    }
}
