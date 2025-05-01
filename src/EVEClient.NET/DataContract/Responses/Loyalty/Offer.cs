using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class Offer
    {
        /// <summary>
        /// Analysis kredit cost
        /// </summary>
        [JsonPropertyName("ak_cost")]
        public int? AkCost { get; init; }

        /// <summary>
        /// isk_cost integer
        /// </summary>
        [JsonPropertyName("isk_cost")]
        public required long IskCost { get; init; }

        /// <summary>
        /// lp_cost integer
        /// </summary>
        [JsonPropertyName("lp_cost")]
        public required int LpCost { get; init; }

        /// <summary>
        /// offer_id integer
        /// </summary>
        [JsonPropertyName("offer_id")]
        public required int OfferId { get; init; }

        /// <summary>
        /// quantity integer
        /// </summary>
        [JsonPropertyName("quantity")]
        public required int Quantity { get; init; }

        /// <summary>
        /// required_items array
        /// </summary>
        [JsonPropertyName("required_items")]
        public required List<Item> RequiredItems { get; init; }

        /// <summary>
        /// type_id integer
        /// </summary>
        [JsonPropertyName("type_id")]
        public required int TypeId { get; init; }
    }

    public class Item
    {
        /// <summary>
        /// quantity integer
        /// </summary>
        [JsonPropertyName("quantity")]
        public required int Quantity { get; init; }

        /// <summary>
        /// type_id integer
        /// </summary>
        [JsonPropertyName("type_id")]
        public required int TypeId { get; init; }
    }
}
