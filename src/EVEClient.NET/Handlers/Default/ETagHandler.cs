using System.Linq;
using System.Threading.Tasks;

using Microsoft.Extensions.Options;

using EVEClient.NET.Configuration;
using EVEClient.NET.Extensions;
using EVEClient.NET.Utilities;
using EVEClient.NET.Pipline;

namespace EVEClient.NET.Handlers
{
    /// <summary>
    /// Used when the setting "UseETag" setting is enabled.
    /// Stores the eTag value for a particular request in internal storage and applies it to the next request.
    /// </summary>
    public class ETagHandler : IRequestETagHandler
    {
        private readonly EsiClientConfiguration _options;
        private readonly IETagStorage _storage;

        public ETagHandler(IOptions<EsiClientConfiguration> options, IETagStorage storage)
        { 
            _options = options.Value;
            _storage = storage;
        }

        public async Task HandleAsync(EsiContext context, RequestDelegate next)
        {
            if (!_options.EnableETag || context.ExecutionOptions.HasFlag(ExecutionOptions.WithoutETag))
            {
                await next.Invoke(context);
            }
            else
            {
                await SetupETagToHttpRequest(context);
                
                await next.Invoke(context);

                await StoreETagFromResponse(context);
            }
        }

        protected virtual async Task SetupETagToHttpRequest(EsiContext context)
        {
            if (await _storage.TryGetETagAsync(GetKey(context), out var eTag))
            {
                context.Request.Headers.TryAddWithoutValidation("If-None-Match", eTag);
            }
        }

        protected virtual async Task StoreETagFromResponse(EsiContext context)
        {
            if (!context.ResponseContext.Response.Headers.Contains("ETag"))
            {
                return;
            }

            var eTag = context.ResponseContext.Response.Headers.GetValues("ETag").First().Replace("\"", string.Empty);

            await _storage.StoreETagAsync(GetKey(context), eTag);
        }

        protected virtual string GetKey(EsiContext context)
        { 
            return ETagStoreKeyGenerator.GetKey(context.EndpointId, context.Request.Parameters.Route.AsNameValueCollection(), context.Request.Parameters.Query.AsNameValueCollection());
        }
    }
}
