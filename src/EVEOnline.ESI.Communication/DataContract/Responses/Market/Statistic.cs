using System;
using Newtonsoft.Json;

namespace EVEOnline.ESI.Communication.DataContract
{
    public class Statistic
    {
        /// <summary>
        /// average number
        /// </summary>
        [JsonProperty("average")]
        public double Average {  get; set; }

        /// <summary>
        /// The date of this historical statistic entry
        /// </summary>
        [JsonProperty("date")]
        public DateTime Date { get; set; }

        /// <summary>
        /// highest number
        /// </summary>
        [JsonProperty("highest")]
        public double Highest { get; set; }

        /// <summary>
        /// lowest number
        /// </summary>
        [JsonProperty("lowest")]
        public double Lowest { get; set; }

        /// <summary>
        /// Total number of orders happened that day
        /// </summary>
        [JsonProperty("order_count")]
        public long OrderCount { get; set; }

        /// <summary>
        /// Total
        /// </summary>
        [JsonProperty("volume")]
        public long Volume {  get; set; }
    }
}
