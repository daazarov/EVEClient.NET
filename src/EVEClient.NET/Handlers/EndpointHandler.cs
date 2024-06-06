using System.Linq;
using System.Threading.Tasks;
using System.Web;

using EVEClient.NET.Attributes;
using EVEClient.NET.Pipline;
using EVEClient.NET.Utilities;

namespace EVEClient.NET.Handlers
{
    public class EndpointHandler : IHandler
    {
        public async Task HandleAsync(EsiContext context, RequestDelegate next)
        {
            context.RequestContext.RequestUrl = SetupDefaultPriorityQueue(context);

            await next.Invoke(context);
        }

        protected virtual string SetupDefaultPriorityQueue(EsiContext context)
        {
            var availableRoutes = ReflectionCacheAttributeAccessor.Instance.GetAttributes<RouteAttribute>(context.EndpointMarker.AsMethodInfo());

            foreach (var item in availableRoutes)
            {
                context.RequestContext.EndpointUrls.Add(item.Version, BuildUrlQuery(context, item.Template));
            }

            return BuildUrlQuery(context, availableRoutes.Where(x => x.Preferred).First().Template);
        }

        private string BuildUrlQuery(EsiContext context, string template)
        {
            var path = string.Empty;
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
