using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class MarketGroup
    {
        /// <summary>
        /// description string
        /// </summary>
        [JsonPropertyName("description")]
        public required string Description { get; init; }

        /// <summary>
        /// market_group_id integer
        /// </summary>
        [JsonPropertyName("market_group_id")]
        public required int MarketGroupId { get; init; }

        /// <summary>
        /// name string
        /// </summary>
        [JsonPropertyName("name")]
        public required string Name { get; init; }

        /// <summary>
        /// parent_group_id integer
        /// </summary>
        [JsonPropertyName("parent_group_id")]
        public int? ParentGroupId { get; init; }

        /// <summary>
        /// types array
        /// </summary>
        [JsonPropertyName("types")]
        public required int[] Types { get; init; }
    }
}
