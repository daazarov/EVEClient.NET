using System;
using System.Collections.Generic;
using System.Net.Http;

namespace EVEClient.NET.Configuration
{
    public class EsiClientConfiguration
    {
        private readonly List<EndpointConfigurationBuilder> _endpointConfigurations = new();
        private readonly Dictionary<string, EndpointConfigurationBuilder> _configurationMap = new(StringComparer.Ordinal);

        /// <summary>
        /// Returns the esi endpoint configuration builders.
        /// </summary>
        public IEnumerable<EndpointConfigurationBuilder> EndpointConfigurations => _endpointConfigurations;

        /// <summary>
        /// Adds an <see cref="EndpointConfiguration"/>.
        /// </summary>
        /// <param name="endpointId">The esi endpoint identifier from <see cref="ESI.Endpoints"/>.</param>
        /// <param name="configureBuilder">Configures the endpoint.</param>
        public void AddEndpointConfiguration(string endpointId, Action<EndpointConfigurationBuilder> configureBuilder)
        {
            ArgumentException.ThrowIfNullOrEmpty(endpointId);
            ArgumentNullException.ThrowIfNull(configureBuilder);

            if (_configurationMap.ContainsKey(endpointId))
            {
                throw new InvalidOperationException("Endpoint configuration already exists: " + endpointId);
            }

            var builder = new EndpointConfigurationBuilder(endpointId);
            configureBuilder(builder);
            _endpointConfigurations.Add(builder);
            _configurationMap[endpointId] = builder;
        }

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

        /// <summary>
        /// Used to communicate with the remote ESI API.
        /// </summary>
        public HttpClient Backchannel { get; set; } = default!;
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
