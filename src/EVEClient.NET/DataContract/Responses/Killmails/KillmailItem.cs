using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class KillmailItem
    {
        /// <summary>
        /// Flag for the location of the item
        /// </summary>
        [JsonPropertyName("flag")]
        public required int Flag { get; init; }

        /// <summary>
        /// item_type_id integer
        /// </summary>
        [JsonPropertyName("item_type_id")]
        public required int ItemTypeId { get; init; }

        /// <summary>
        /// items array
        /// </summary>
        [JsonPropertyName("items")]
        public List<KillmailItem>? Items { get; init; }

        /// <summary>
        /// How many of the item were destroyed if any
        /// </summary>
        [JsonPropertyName("quantity_destroyed")]
        public long? QuantityDestroyed { get; init; }

        /// <summary>
        /// How many of the item were dropped if any
        /// </summary>
        [JsonPropertyName("quantity_dropped")]
        public long? QuantityDropped { get; init; }

        /// <summary>
        /// singleton integer
        /// </summary>
        [JsonPropertyName("singleton")]
        public required int Singleton { get; init; }
    }
}
