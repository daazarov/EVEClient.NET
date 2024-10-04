using System.Threading.Tasks;

using Microsoft.Extensions.Options;

using EVEClient.NET.Configuration;
using EVEClient.NET.Pipline;

namespace EVEClient.NET.Handlers
{
    /// <summary>
    /// Make a request to ESI API.
    /// </summary>
    public class RequestHandler : IRequestSendingHandler
    {
        protected readonly EsiClientConfiguration Options;
        
        public RequestHandler(IOptions<EsiClientConfiguration> options)
        {
            Options = options.Value;
        }

        public async Task HandleAsync(EsiContext context, RequestDelegate next)
        {
            context.Request.Prepare();

            context.ResponseContext.Response = await Options.Backchannel.SendAsync(context.Request, context.CancellationToken);
            context.ResponseContext.Completed = true;

            await next.Invoke(context);
        }
    }
}
