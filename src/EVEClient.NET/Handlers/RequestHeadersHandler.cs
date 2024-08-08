using System;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;

using EVEClient.NET.Configuration;
using EVEClient.NET.Pipline;

namespace EVEClient.NET.Handlers
{
    /// <summary>
    /// Configures the default headers for the HttpClient.
    /// </summary>
    public class RequestHeadersHandler : IHandler
    {
        private readonly EsiClientConfiguration _configuration;

        public RequestHeadersHandler(IOptions<EsiClientConfiguration> configuration)
        {
            _configuration = configuration.Value;
        }

        public async Task HandleAsync(EsiContext context, RequestDelegate next)
        {
            ConfigureHttpClientHeaders(context.HttpClient.DefaultRequestHeaders);

            await next.Invoke(context);
        }

        protected virtual void ConfigureHttpClientHeaders(HttpRequestHeaders headers)
        {
            headers.Add("X-User-Agent", _configuration.UserAgent);
            headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            headers.AcceptEncoding.Add(new StringWithQualityHeaderValue("gzip"));
            headers.AcceptEncoding.Add(new StringWithQualityHeaderValue("deflate"));
        }
    }
}
