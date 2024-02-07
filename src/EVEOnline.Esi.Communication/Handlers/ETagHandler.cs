using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;

using EVEOnline.Esi.Communication.Configuration;
using EVEOnline.Esi.Communication.Extensions;
using EVEOnline.Esi.Communication.Utilities;

namespace EVEOnline.Esi.Communication.Handlers
{
    internal class ETagHandler : IHandler
    {
        private readonly IOptionsMonitor<EsiClientConfiguration> _options;
        private readonly IETagStorage _storage;

        public ETagHandler(IOptionsMonitor<EsiClientConfiguration> options, IETagStorage storage)
        { 
            _options = options;
            _storage = storage;
        }

        public async Task HandleAsync(EsiContext context, RequestDelegate next)
        {
            if (!_options.CurrentValue.EnableETag)
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

        private async Task SetupETagToHttpClient(EsiContext context)
        {
            if (await _storage.TryGetETagAsync(GetKey(context), out var eTag))
            {
                context.HttpClient.DefaultRequestHeaders.Add("If-None-Match", eTag);
            }
        }

        private async Task StoreETagFromResponse(EsiContext context)
        {
            if (!context.Response.Headers.Contains("ETag"))
            {
                return;
            }

            var eTag = context.Response.Headers.GetValues("ETag").First().Replace("\"", string.Empty);

            await _storage.StoreETagAsync(GetKey(context), eTag);
        }

        private string GetKey(EsiContext context) =>
            ETagStoreKeyGenerator.GetKey(context.EndpointId, context.RequestContext.RouteParametersMap.AsNameValueCollection(), context.RequestContext.QueryParametersMap.AsNameValueCollection());
    }
}
