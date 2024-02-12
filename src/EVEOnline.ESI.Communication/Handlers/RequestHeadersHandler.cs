using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;

using EVEOnline.ESI.Communication.Configuration;
using EVEOnline.ESI.Communication.Extensions;

namespace EVEOnline.ESI.Communication.Handlers
{
    public class RequestHeadersHandler : IHandler
    {
        private readonly EsiClientConfiguration _configuration;

        public RequestHeadersHandler(IOptions<EsiClientConfiguration> configuration)
        {
            _configuration = configuration.Value;
        }

        public async Task HandleAsync(EsiContext context, RequestDelegate next)
        {
            ConfigureDefaultHttpClientHeaders(context.HttpClient.DefaultRequestHeaders);

            await next.Invoke(context);
        }

        protected virtual void ConfigureDefaultHttpClientHeaders(HttpRequestHeaders headers)
        {
            headers.Add("X-User-Agent", _configuration.UserAgent.ArgumentStringNotNullOrEmpty(nameof(_configuration.UserAgent)));
            headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            headers.AcceptEncoding.Add(new StringWithQualityHeaderValue("gzip"));
            headers.AcceptEncoding.Add(new StringWithQualityHeaderValue("deflate"));
        }
    }
}
