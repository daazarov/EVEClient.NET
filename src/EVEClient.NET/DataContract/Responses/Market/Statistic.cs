using System;
using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class Statistic
    {
        /// <summary>
        /// average number
        /// </summary>
        [JsonProperty("average")]
        public required double Average {  get; set; }

        /// <summary>
        /// The date of this historical statistic entry
        /// </summary>
        [JsonProperty("date")]
        public required DateTime Date { get; init; }

        /// <summary>
        /// highest number
        /// </summary>
        [JsonProperty("highest")]
        public required double Highest { get; init; }

        /// <summary>
        /// lowest number
        /// </summary>
        [JsonProperty("lowest")]
        public required double Lowest { get; init; }

        /// <summary>
        /// Total number of orders happened that day
        /// </summary>
        [JsonProperty("order_count")]
        public long OrderCount { get; init; }

        /// <summary>
        /// Total
        /// </summary>
        [JsonProperty("volume")]
        public required long Volume {  get; set; }
    }
}
