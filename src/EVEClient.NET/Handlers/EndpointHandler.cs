using System;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

using EVEClient.NET.Attributes;
using EVEClient.NET.Pipline;
using EVEClient.NET.Utilities;

namespace EVEClient.NET.Handlers
{
    /// <summary>
    /// Prepares a ready URL for sending the request.
    /// </summary>
    public class EndpointHandler : IHandler
    {
        public async Task HandleAsync(EsiContext context, RequestDelegate next)
        {
            var routes = GetAvailableEndpointRoutes(context);

            if (routes == null || !routes.Any())
            {
                throw new InvalidOperationException($"Can not find available routes for endpoint id: {context.RequestContext.EndpointId}");
            }

            context.RequestContext.RequestUrl = SetupPreferedEndpointUrl(routes, context);

            foreach (var item in routes)
            {
                context.RequestContext.EndpointUrls.Add(item.Version, BuildUrlQuery(context, item.Template));
            }

            await next.Invoke(context);
        }

        private string SetupPreferedEndpointUrl(RouteAttribute[] routes, EsiContext context)
        {
            return BuildUrlQuery(context, routes.Where(x => x.Preferred).First().Template);
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

        private RouteAttribute[]? GetAvailableEndpointRoutes(EsiContext context)
        {
            return ReflectionCacheAttributeAccessor.Instance.GetAttributes<RouteAttribute>(context.EndpointMarker.AsMethodInfo());
        }
    }
}
