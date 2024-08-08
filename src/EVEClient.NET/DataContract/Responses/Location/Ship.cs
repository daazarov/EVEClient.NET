using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class Ship
    {
        /// <summary>
        /// Item id’s are unique to a ship and persist until it is repackaged.
        /// This value can be used to track repeated uses of a ship, or detect when a pilot changes into a different instance of the same ship type.
        /// </summary>
        [JsonProperty("ship_item_id")]
        public required long ShipItemId { get; init; }

        /// <summary>
        /// ship_name string
        /// </summary>
        [JsonProperty("ship_name")]
        public required string ShipName { get; init; }

        /// <summary>
        /// ship_type_id integer
        /// </summary>
        [JsonProperty("ship_type_id")]
        public required int ShipTypeId { get; init; }
    }
}
