using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class MarketGroup
    {
        /// <summary>
        /// description string
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; init; }

        /// <summary>
        /// market_group_id integer
        /// </summary>
        [JsonProperty("market_group_id")]
        public int MarketGroupId { get; init; }

        /// <summary>
        /// name string
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; init; }

        /// <summary>
        /// parent_group_id integer
        /// </summary>
        [JsonProperty("parent_group_id")]
        public int? ParentGroupId { get; init; }

        /// <summary>
        /// types array
        /// </summary>
        [JsonProperty("types")]
        public int[] Types { get; init; }
    }
}
