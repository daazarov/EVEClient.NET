using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;

using EVEClient.NET.Configuration;
using EVEClient.NET.Extensions;
using EVEClient.NET.Utilities;
using EVEClient.NET.Pipline;

namespace EVEClient.NET.Handlers
{
    public class ETagHandler : IHandler
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
            if (!_options.EnableETag)
            {
                await next.Invoke(context);
            }
            else
            {
                await SetupETagToHttpClient(context);
                
                await next.Invoke(context);

                await StoreETagFromResponse(context);
            }
        }

        protected virtual async Task SetupETagToHttpClient(EsiContext context)
        {
            if (await _storage.TryGetETagAsync(GetKey(context), out var eTag))
            {
                context.HttpClient.DefaultRequestHeaders.TryAddWithoutValidation("If-None-Match", eTag);
            }
        }

        protected virtual async Task StoreETagFromResponse(EsiContext context)
        {
            if (!context.Response.Headers.Contains("ETag"))
            {
                return;
            }

            var eTag = context.Response.Headers.GetValues("ETag").First().Replace("\"", string.Empty);

            await _storage.StoreETagAsync(GetKey(context), eTag);
        }

        protected virtual string GetKey(EsiContext context) =>
            ETagStoreKeyGenerator.GetKey(context.RequestContext.EndpointId, context.RequestContext.PathParametersMap.AsNameValueCollection(), context.RequestContext.QueryParametersMap.AsNameValueCollection());
    }
}
