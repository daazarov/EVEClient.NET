using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class AssetItem
    {
        /// <summary>
        /// is_blueprint_copy boolean
        /// </summary>
        [JsonPropertyName("is_blueprint_copy")]
        public bool? IsBlueprintCopy { get; init; }

        /// <summary>
        /// is_singleton boolean
        /// </summary>
        [JsonPropertyName("is_singleton")]
        public required bool IsSingleton { get; init; }

        /// <summary>
        /// item_id integer
        /// </summary>
        [JsonPropertyName("item_id")]
        public required long ItemId { get; init; }

        /// <summary>
        /// location_flag string
        /// </summary>
        [JsonPropertyName("location_flag")]
        public required string LocationFlag { get; init; }

        /// <summary>
        /// location_id integer
        /// </summary>
        [JsonPropertyName("location_id")]
        public required long LocationId { get; init; }

        /// <summary>
        /// location_type string
        /// </summary>
        [JsonPropertyName("location_type")]
        public required LocationType LocationType { get; init; }

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
