using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class AssetItem
    {
        /// <summary>
        /// is_blueprint_copy boolean
        /// </summary>
        [JsonProperty("is_blueprint_copy")]
        public bool? IsBlueprintCopy { get; init; }

        /// <summary>
        /// is_singleton boolean
        /// </summary>
        [JsonProperty("is_singleton")]
        public bool IsSingleton { get; init; }

        /// <summary>
        /// item_id integer
        /// </summary>
        [JsonProperty("item_id")]
        public long ItemId { get; init; }

        /// <summary>
        /// location_flag string
        /// </summary>
        [JsonProperty("location_flag")]
        public string LocationFlag { get; init; }

        /// <summary>
        /// location_id integer
        /// </summary>
        [JsonProperty("location_id")]
        public long LocationId { get; init; }

        /// <summary>
        /// location_type string
        /// </summary>
        [JsonProperty("location_type")]
        public LocationType LocationType { get; init; }

        /// <summary>
        /// quantity integer
        /// </summary>
        [JsonProperty("quantity")]
        public int Quantity { get; init; }

        /// <summary>
        /// type_id integer
        /// </summary>
        [JsonProperty("type_id")]
        public int TypeId { get; init; }
    }
}
