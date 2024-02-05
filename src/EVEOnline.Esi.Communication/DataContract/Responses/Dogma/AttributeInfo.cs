using Newtonsoft.Json;

namespace EVEOnline.Esi.Communication.DataContract
{
    public class AttributeInfo
    {
        /// <summary>
        /// attribute_id integer
        /// </summary>
        [JsonProperty("attribute_id")]
        public int AttributeId {  get; set; }

        /// <summary>
        /// default_value number
        /// </summary>
        [JsonProperty("default_value")]
        public float? DefaultValue { get; set; }

        /// <summary>
        /// description string
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// display_name string
        /// </summary>
        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        /// <summary>
        /// high_is_good boolean
        /// </summary>
        [JsonProperty("high_is_good")]
        public bool? HighIsGood { get; set; }

        /// <summary>
        /// icon_id integer
        /// </summary>
        [JsonProperty("icon_id")]
        public int? IconId { get; set; }

        /// <summary>
        /// name string
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// published boolean
        /// </summary>
        [JsonProperty("published")]
        public bool? Published { get; set; }

        /// <summary>
        /// stackable boolean
        /// </summary>
        [JsonProperty("stackable")]
        public bool? Stackable { get; set; }

        /// <summary>
        /// unit_id integer
        /// </summary>
        [JsonProperty("unit_id")]
        public int? UnitId { get; set; }
    }
}
