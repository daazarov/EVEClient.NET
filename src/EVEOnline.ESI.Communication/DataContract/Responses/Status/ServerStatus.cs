using System;
using Newtonsoft.Json;

namespace EVEOnline.ESI.Communication.DataContract
{
    public class ServerStatus
    {
        /// <summary>
        /// Current online player count
        /// </summary>
        [JsonProperty("players")]
        public int Players { get; set; }

        /// <summary>
        /// Running version as string
        /// </summary>
        [JsonProperty("server_version")]
        public string ServerVersion { get; set; }

        /// <summary>
        /// Server start timestamp
        /// </summary>
        [JsonProperty("start_time")]
        public DateTime StartTime { get; set; }

        /// <summary>
        /// If the server is in VIP mode
        /// </summary>
        [JsonProperty("vip")]
        public bool? Vip { get; set; }
    }
}
