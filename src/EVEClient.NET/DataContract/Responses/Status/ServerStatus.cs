using System;
using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class ServerStatus
    {
        /// <summary>
        /// Current online player count
        /// </summary>
        [JsonPropertyName("players")]
        public required int Players { get; init; }

        /// <summary>
        /// Running version as string
        /// </summary>
        [JsonPropertyName("server_version")]
        public required string ServerVersion { get; init; }

        /// <summary>
        /// Server start timestamp
        /// </summary>
        [JsonPropertyName("start_time")]
        public required DateTime StartTime { get; init; }

        /// <summary>
        /// If the server is in VIP mode
        /// </summary>
        [JsonPropertyName("vip")]
        public bool? Vip { get; init; }
    }
}
