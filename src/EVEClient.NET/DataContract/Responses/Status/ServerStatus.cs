using System;
using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class ServerStatus
    {
        /// <summary>
        /// Current online player count
        /// </summary>
        [JsonProperty("players")]
        public int Players { get; init; }

        /// <summary>
        /// Running version as string
        /// </summary>
        [JsonProperty("server_version")]
        public string ServerVersion { get; init; }

        /// <summary>
        /// Server start timestamp
        /// </summary>
        [JsonProperty("start_time")]
        public DateTime StartTime { get; init; }

        /// <summary>
        /// If the server is in VIP mode
        /// </summary>
        [JsonProperty("vip")]
        public bool? Vip { get; init; }
    }
}
