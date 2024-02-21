using Newtonsoft.Json;

namespace EVEOnline.ESI.Communication.DataContract
{
    public class MarketGroup
    {
        /// <summary>
        /// description string
        /// </summary>
        [JsonProperty("description")]
        public string Description {  get; set; }

        /// <summary>
        /// market_group_id integer
        /// </summary>
        [JsonProperty("market_group_id")]
        public int MarketGroupId { get; set; }

        /// <summary>
        /// name string
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// parent_group_id integer
        /// </summary>
        [JsonProperty("parent_group_id")]
        public int? ParentGroupId { get; set; }

        /// <summary>
        /// types array
        /// </summary>
        [JsonProperty("types")]
        public int[] Types { get; set; }
    }
}
