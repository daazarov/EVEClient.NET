using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class Price
    {
        /// <summary>
        /// adjusted_price number
        /// </summary>
        [JsonProperty("adjusted_price")]
        public double? AdjustedPrice { get; init; }

        /// <summary>
        /// average_price number
        /// </summary>
        [JsonProperty("average_price")]
        public double? AveragePrice { get; init; }

        /// <summary>
        /// type_id integer
        /// </summary>
        [JsonProperty("type_id")]
        public required int TypeId { get; init; }
    }
}
