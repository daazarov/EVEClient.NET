using System;

namespace EVEOnline.ESI.Communication.Configuration
{
    public class EsiClientConfiguration
    {
        internal const string DefaultEsiConfigurationSectionName = "EsiClientConfiguration";

        private EVEOnlineServer _server;

        public EsiClientConfiguration()
        {
            Server = EVEOnlineServer.Tranquility;
        }

        public string UserAgent { get; set; }
        public bool EnableETag { get; set; }

        public EVEOnlineServer Server
        {
            get { return _server; }
            set
            {
                _server = value;
                switch (value)
                {
                    case EVEOnlineServer.Tranquility:
                        AuthorizationUrl = ESI.SSO.Tranquility.AuthorizationSsoBaseUrl;
                        EsiUrl = ESI.SSO.Tranquility.EsiBaseUrl;
                        break;

                    case EVEOnlineServer.Singularity:
                        AuthorizationUrl = ESI.SSO.Singularity.AuthorizationSsoBaseUrl;
                        EsiUrl = ESI.SSO.Singularity.EsiBaseUrl;
                        break;

                    default:
                        throw new ArgumentException($"Server '{value}' is unsupported.", nameof(value));
                }
            }
        }

        internal string EsiUrl { get; set; }
        internal string AuthorizationUrl { get; set; }
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
