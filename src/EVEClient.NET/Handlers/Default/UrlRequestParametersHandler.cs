using System.Threading.Tasks;
using Microsoft.Extensions.Options;

using EVEClient.NET.Configuration;
using EVEClient.NET.Pipline;

namespace EVEClient.NET.Handlers
{
    /// <summary>
    /// Prepares a list of parameters to be passed and replaced in the ESI endpoint route template.
    /// </summary>
    public class UrlRequestParametersHandler : IHandler
    {
        private readonly EsiClientConfiguration _options;

        public UrlRequestParametersHandler(IOptions<EsiClientConfiguration> options) 
        {
            _options = options.Value;
        }

        public async Task HandleAsync(EsiContext context, RequestDelegate next)
        {
            context.Request.Parameters.Query["datasource"] = _options.Server.ToString().ToLower();

            await next.Invoke(context);
        }
    }
}
