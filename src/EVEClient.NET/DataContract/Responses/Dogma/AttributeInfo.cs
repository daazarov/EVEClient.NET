using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class AttributeInfo
    {
        /// <summary>
        /// attribute_id integer
        /// </summary>
        [JsonPropertyName("attribute_id")]
        public required int AttributeId { get; init; }

        /// <summary>
        /// default_value number
        /// </summary>
        [JsonPropertyName("default_value")]
        public float? DefaultValue { get; init; }

        /// <summary>
        /// description string
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; init; }

        /// <summary>
        /// display_name string
        /// </summary>
        [JsonPropertyName("display_name")]
        public string? DisplayName { get; init; }

        /// <summary>
        /// high_is_good boolean
        /// </summary>
        [JsonPropertyName("high_is_good")]
        public bool? HighIsGood { get; init; }

        /// <summary>
        /// icon_id integer
        /// </summary>
        [JsonPropertyName("icon_id")]
        public int? IconId { get; init; }

        /// <summary>
        /// name string
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; init; }

        /// <summary>
        /// published boolean
        /// </summary>
        [JsonPropertyName("published")]
        public bool? Published { get; init; }

        /// <summary>
        /// stackable boolean
        /// </summary>
        [JsonPropertyName("stackable")]
        public bool? Stackable { get; init; }

        /// <summary>
        /// unit_id integer
        /// </summary>
        [JsonPropertyName("unit_id")]
        public int? UnitId { get; init; }
    }
}
