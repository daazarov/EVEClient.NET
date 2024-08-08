using System.Collections.Generic;
using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class KillmailItem
    {
        /// <summary>
        /// Flag for the location of the item
        /// </summary>
        [JsonProperty("flag")]
        public required int Flag {  get; set; }

        /// <summary>
        /// item_type_id integer
        /// </summary>
        [JsonProperty("item_type_id")]
        public required int ItemTypeId { get; init; }

        /// <summary>
        /// items array
        /// </summary>
        [JsonProperty("items")]
        public List<KillmailItem>? Items { get; init; }

        /// <summary>
        /// How many of the item were destroyed if any
        /// </summary>
        [JsonProperty("quantity_destroyed")]
        public long? QuantityDestroyed { get; init; }

        /// <summary>
        /// How many of the item were dropped if any
        /// </summary>
        [JsonProperty("quantity_dropped")]
        public long? QuantityDropped { get; init; }

        /// <summary>
        /// singleton integer
        /// </summary>
        [JsonProperty("singleton")]
        public required int Singleton {  get; set; }
    }
}
