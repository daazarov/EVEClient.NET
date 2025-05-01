using System;
using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class Mining
    {
        /// <summary>
        /// date string
        /// </summary>
        [JsonPropertyName("date")]
        public required DateTime Date { get; init; }

        /// <summary>
        /// quantity integer
        /// </summary>
        [JsonPropertyName("quantity")]
        public required long Quantity { get; init; }

        /// <summary>
        /// solar_system_id integer
        /// </summary>
        [JsonPropertyName("solar_system_id")]
        public required int SolarSystemId { get; init; }

        /// <summary>
        /// type_id integer
        /// </summary>
        [JsonPropertyName("type_id")]
        public required int TypeId { get; init; }
    }
}
