using System;
using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class Mining
    {
        /// <summary>
        /// date string
        /// </summary>
        [JsonProperty("date")]
        public DateTime Date { get; init; }

        /// <summary>
        /// quantity integer
        /// </summary>
        [JsonProperty("quantity")]
        public long Quantity { get; init; }

        /// <summary>
        /// solar_system_id integer
        /// </summary>
        [JsonProperty("solar_system_id")]
        public int SolarSystemId { get; init; }

        /// <summary>
        /// type_id integer
        /// </summary>
        [JsonProperty("type_id")]
        public int TypeId { get; init; }
    }
}
