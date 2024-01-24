using System.Linq;
using System.Threading.Tasks;

using EVEOnline.Esi.Communication.Attributes;
using EVEOnline.Esi.Communication.Extensions;
using EVEOnline.Esi.Communication.Utilities;

namespace EVEOnline.Esi.Communication.Handlers
{
    internal class EndpointHandler : IHandler
    {
        private readonly IEndpointPriorityProvider _priorityProvider;

        public EndpointHandler(IEndpointPriorityProvider priorityProvider)
        { 
            _priorityProvider = priorityProvider;
        }

        public async Task HandleAsync(EsiContext context, RequestDelegate next)
        {
            var routeAttributes = ReflectionCacheAttributeAccessor.Instance.GetAttributes<RouteAttribute>(context.CallingContext.MethodInfo);
            var priorities = _priorityProvider.GetPriorities(context.EndpointId);
            var routeQueue = new RouteQueue();

            foreach (var priority in priorities)
            {
                // There is no need to check the route availability, as it is checked when registering the service
                var route = routeAttributes.Where(x => x.Type == priority.Version).First();

                routeQueue.AddRoute(BuildUrlQuery(context, route.Template), priority);
            }

            context.RequestContext.RouteQueue = routeQueue;

            await next.Invoke(context);
        }

        private string BuildUrlQuery(EsiContext context, string template)
        {
            var url = UrlQueryBuilder.BuildRouteString(template, context.RequestContext.RouteParametersMap.ToNameValueCollection());

            return UrlQueryBuilder.BuildQueryString(url, context.RequestContext.QueryParametersMap.ToNameValueCollection());
        }
    }
}
