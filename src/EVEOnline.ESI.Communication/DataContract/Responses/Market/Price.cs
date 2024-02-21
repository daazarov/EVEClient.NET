using Newtonsoft.Json;

namespace EVEOnline.ESI.Communication.DataContract
{
    public class Price
    {
        /// <summary>
        /// adjusted_price number
        /// </summary>
        [JsonProperty("adjusted_price")]
        public double? AdjustedPrice {  get; set; }

        /// <summary>
        /// average_price number
        /// </summary>
        [JsonProperty("average_price")]
        public double? AveragePrice { get; set; }

        /// <summary>
        /// type_id integer
        /// </summary>
        [JsonProperty("type_id")]
        public int TypeId { get; set; }
    }
}
