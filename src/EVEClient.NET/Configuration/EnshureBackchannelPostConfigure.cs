using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.Extensions.Options;

namespace EVEClient.NET.Configuration
{
    internal class EnshureBackchannelPostConfigure : IPostConfigureOptions<EsiClientConfiguration>
    {
        public void PostConfigure(string? name, EsiClientConfiguration options)
        {
            if (options.Backchannel is null)
            {
                options.Backchannel = new HttpClient(new HttpClientHandler
                {
                    AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate
                });

                options.Backchannel.BaseAddress = new Uri(options.EsiBaseUrl);
                options.Backchannel.DefaultRequestHeaders.Add("X-User-Agent", options.UserAgent);
                options.Backchannel.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                options.Backchannel.DefaultRequestHeaders.AcceptEncoding.Add(new StringWithQualityHeaderValue("gzip"));
                options.Backchannel.DefaultRequestHeaders.AcceptEncoding.Add(new StringWithQualityHeaderValue("deflate"));
            }
        }
    }
}
