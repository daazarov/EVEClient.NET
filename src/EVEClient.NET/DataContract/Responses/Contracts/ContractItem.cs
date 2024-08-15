using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class ContractItem
    {
        /// <summary>
        /// true if the contract issuer has submitted this item with the contract,
        /// false if the isser is asking for this item in the contract
        /// </summary>
        [JsonProperty("is_included")]
        public required bool IsIncluded { get; init; }

        /// <summary>
        /// is_singleton boolean
        /// </summary>
        [JsonProperty("is_singleton")]
        public required bool IsSingleton { get; init; }

        /// <summary>
        /// Number of items in the stack
        /// </summary>
        [JsonProperty("quantity")]
        public required int Quantity { get; init; }

        /// <summary>
        /// -1 indicates that the item is a singleton (non-stackable).
        /// If the item happens to be a Blueprint, -1 is an Original and -2 is a Blueprint Copy
        /// </summary>
        [JsonProperty("raw_quantity")]
        public int? RawQuantity { get; init; }

        /// <summary>
        /// Unique ID for the item
        /// </summary>
        [JsonProperty("record_id")]
        public required long RecordId { get; init; }

        /// <summary>
        /// Type ID for item
        /// </summary>
        [JsonProperty("type_id")]
        public required int TypeId { get; init; }
    }
}
