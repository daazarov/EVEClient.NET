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
        public double Average { get; init; }

        /// <summary>
        /// The date of this historical statistic entry
        /// </summary>
        [JsonProperty("date")]
        public DateTime Date { get; init; }

        /// <summary>
        /// highest number
        /// </summary>
        [JsonProperty("highest")]
        public double Highest { get; init; }

        /// <summary>
        /// lowest number
        /// </summary>
        [JsonProperty("lowest")]
        public double Lowest { get; init; }

        /// <summary>
        /// Total number of orders happened that day
        /// </summary>
        [JsonProperty("order_count")]
        public long OrderCount { get; init; }

        /// <summary>
        /// Total
        /// </summary>
        [JsonProperty("volume")]
        public long Volume { get; init; }
    }
}
