using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.Extensions.Options;

namespace EVEClient.NET.Configuration
{
    internal class EnshureBackchannelPostConfigure : IPostConfigureOptions<EsiClientConfiguration>
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public EnshureBackchannelPostConfigure(IHttpClientFactory httpClientFactory)
        { 
            _httpClientFactory = httpClientFactory;
        }

        public void PostConfigure(string? name, EsiClientConfiguration options)
        {
            if (options.Backchannel is null)
            {
                var client = _httpClientFactory.CreateClient(ESI.HttpClientName);

                client.DefaultRequestHeaders.Add("X-User-Agent", options.UserAgent);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.AcceptEncoding.Add(new StringWithQualityHeaderValue("gzip"));
                client.DefaultRequestHeaders.AcceptEncoding.Add(new StringWithQualityHeaderValue("deflate"));

                options.Backchannel = client;
            }
        }
    }
}
