using System;

namespace EVEClient.NET.Configuration
{
    public class EsiClientConfiguration
    {
        /// <summary>
        /// Get or set UserAgent header value which will be used when sending requests.
        /// </summary>
        /// <remarks>
        /// When making requests, it’s recommended you set a User-Agent header in your client which includes the source of the request and contact information. 
        /// This way, CCP can identify and help you with issues if you’re banned.
        /// </remarks>
        public string UserAgent { get; set; } = default!;

        /// <summary>
        /// Indicates whether the ETag header should be stored and used.
        /// See more: <see href="https://developers.eveonline.com/blog/article/esi-etag-best-practices"/>
        /// </summary>
        public bool EnableETag { get; set; }

        /// <summary>
        /// Get or set server you would like data from
        /// </summary>
        /// <remarks>The default value: <see cref="EVEOnlineServer.Tranquility"></see></remarks>
        public EVEOnlineServer Server { get; set; } = EVEOnlineServer.Tranquility;

        /// <summary>
        /// Get or set the EVE ESI base url.
        /// </summary>
        /// <remarks>The default value: https://esi.evetech.net</remarks>
        public string EsiBaseUrl { get; set; } = ESI.EsiBaseUrl;
    }

    public enum EVEOnlineServer
    {
        /// <summary>
        /// Live server.
        /// </summary>
        Tranquility = 0,

        /// <summary>
        /// Test server.
        /// </summary>
        Singularity = 1
    }
}
