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
        public bool IsIncluded {  get; set; }

        /// <summary>
        /// is_singleton boolean
        /// </summary>
        [JsonProperty("is_singleton")]
        public bool IsSingleton { get; set; }

        /// <summary>
        /// Number of items in the stack
        /// </summary>
        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        /// <summary>
        /// -1 indicates that the item is a singleton (non-stackable).
        /// If the item happens to be a Blueprint, -1 is an Original and -2 is a Blueprint Copy
        /// </summary>
        [JsonProperty("raw_quantity")]
        public int? RawQuantity { get; set; }

        /// <summary>
        /// Unique ID for the item
        /// </summary>
        [JsonProperty("record_id")]
        public long RecordId { get; set; }

        /// <summary>
        /// Type ID for item
        /// </summary>
        [JsonProperty("type_id")]
        public int TypeId { get; set; }
    }
}
