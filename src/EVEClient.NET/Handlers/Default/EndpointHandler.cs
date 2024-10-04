using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Web;

using EVEClient.NET.Extensions;
using EVEClient.NET.Pipline;

namespace EVEClient.NET.Handlers
{
    /// <summary>
    /// Prepares a ready URL for sending the request.
    /// </summary>
    public class EndpointHandler : IHandler
    {
        public async Task HandleAsync(EsiContext context, RequestDelegate next)
        {
            var urls = new List<string>();

            context.GetEndpointRoutes().ForEach(route =>
            {
                var url = BuildUrl(route.Value, context.Request.Parameters.Route, context.Request.Parameters.Query);
                urls.Add(url);
                if (route.Preferred)
                    context.Request.RequestUrl = url;
            });

            context.Request.AvailableEndpointUrls = urls;

            await next.Invoke(context);
        }

        private string BuildUrl(string template, IEnumerable<KeyValuePair<string, string>> routeParameters, IEnumerable<KeyValuePair<string, string>> queryParameters)
        {
            var query = HttpUtility.ParseQueryString(string.Empty);
            var path = new StringBuilder(template);

            foreach (var kvp in routeParameters)
            {
                path = path.Replace($"{{{kvp.Key}}}", kvp.Value);
            }

            foreach (var kvp in queryParameters)
            {
                query[kvp.Key] = kvp.Value;
            }

            return string.Concat(path.ToString(), "?", query.ToString());
        }
    }
}
