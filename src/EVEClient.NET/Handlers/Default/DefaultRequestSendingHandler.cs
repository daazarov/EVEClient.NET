using System.Threading.Tasks;

using Microsoft.Extensions.Options;

using EVEClient.NET.Configuration;
using EVEClient.NET.Pipline;
using EVEClient.NET.Extensions;

namespace EVEClient.NET.Handlers
{
    /// <summary>
    /// Make a request to ESI API.
    /// </summary>
    public class DefaultRequestSendingHandler : IRequestSendingHandler
    {
        protected readonly EsiClientConfiguration Options;
        protected readonly IEndpointConfigurationProvider EndpointConfigurations;

        public DefaultRequestSendingHandler(IOptions<EsiClientConfiguration> options, IEndpointConfigurationProvider endpointConfigurations)
        {
            Options = options.Value;
            EndpointConfigurations = endpointConfigurations;
        }

        public async Task HandleAsync(EsiContext context, RequestDelegate next)
        {
            var config = EndpointConfigurations.GetConfiguration(context.EndpointId);

            context.Request.Parameters.EnshureDatabaseSource(Options.Server.ToString().ToLower());
            context.Request.Prepare(config);

            context.ResponseContext.Response = await Options.Backchannel.SendAsync(context.Request, context.CancellationToken);

            await next.Invoke(context);
        }
    }
}
