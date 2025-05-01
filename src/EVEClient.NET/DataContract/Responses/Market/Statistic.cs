using System;
using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class Statistic
    {
        /// <summary>
        /// average number
        /// </summary>
        [JsonPropertyName("average")]
        public required double Average { get; init; }

        /// <summary>
        /// The date of this historical statistic entry
        /// </summary>
        [JsonPropertyName("date")]
        public required DateTime Date { get; init; }

        /// <summary>
        /// highest number
        /// </summary>
        [JsonPropertyName("highest")]
        public required double Highest { get; init; }

        /// <summary>
        /// lowest number
        /// </summary>
        [JsonPropertyName("lowest")]
        public required double Lowest { get; init; }

        /// <summary>
        /// Total number of orders happened that day
        /// </summary>
        [JsonPropertyName("order_count")]
        public long OrderCount { get; init; }

        /// <summary>
        /// Total
        /// </summary>
        [JsonPropertyName("volume")]
        public required long Volume { get; init; }
    }
}
