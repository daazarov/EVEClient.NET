using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class Price
    {
        /// <summary>
        /// adjusted_price number
        /// </summary>
        [JsonPropertyName("adjusted_price")]
        public double? AdjustedPrice { get; init; }

        /// <summary>
        /// average_price number
        /// </summary>
        [JsonPropertyName("average_price")]
        public double? AveragePrice { get; init; }

        /// <summary>
        /// type_id integer
        /// </summary>
        [JsonPropertyName("type_id")]
        public required int TypeId { get; init; }
    }
}
