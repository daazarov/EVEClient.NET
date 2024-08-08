using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class AttributeInfo
    {
        /// <summary>
        /// attribute_id integer
        /// </summary>
        [JsonProperty("attribute_id")]
        public required int AttributeId {  get; set; }

        /// <summary>
        /// default_value number
        /// </summary>
        [JsonProperty("default_value")]
        public float? DefaultValue { get; init; }

        /// <summary>
        /// description string
        /// </summary>
        [JsonProperty("description")]
        public string? Description { get; init; }

        /// <summary>
        /// display_name string
        /// </summary>
        [JsonProperty("display_name")]
        public string? DisplayName { get; init; }

        /// <summary>
        /// high_is_good boolean
        /// </summary>
        [JsonProperty("high_is_good")]
        public bool? HighIsGood { get; init; }

        /// <summary>
        /// icon_id integer
        /// </summary>
        [JsonProperty("icon_id")]
        public int? IconId { get; init; }

        /// <summary>
        /// name string
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; init; }

        /// <summary>
        /// published boolean
        /// </summary>
        [JsonProperty("published")]
        public bool? Published { get; init; }

        /// <summary>
        /// stackable boolean
        /// </summary>
        [JsonProperty("stackable")]
        public bool? Stackable { get; init; }

        /// <summary>
        /// unit_id integer
        /// </summary>
        [JsonProperty("unit_id")]
        public int? UnitId { get; init; }
    }
}
