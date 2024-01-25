using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace EVEOnline.Esi.Communication.DataContract
{
    public class Item
    {
        /// <summary>
        /// is_blueprint_copy boolean
        /// </summary>
        [JsonProperty("is_blueprint_copy")]
        public bool? IsBlueprintCopy { get; set; }

        /// <summary>
        /// is_singleton boolean
        /// </summary>
        [JsonProperty("is_singleton")]
        public bool IsSingleton { get; set; }

        /// <summary>
        /// item_id integer
        /// </summary>
        [JsonProperty("item_id")]
        public long ItemId { get; set; }

        /// <summary>
        /// location_flag string
        /// </summary>
        [JsonProperty("location_flag")]
        public string LocationFlag { get; set; }

        /// <summary>
        /// location_id integer
        /// </summary>
        [JsonProperty("location_id")]
        public long LocationId { get; set; }

        /// <summary>
        /// location_type string
        /// </summary>
        [JsonProperty("location_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public LocationType LocationType { get; set; }

        /// <summary>
        /// quantity integer
        /// </summary>
        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        /// <summary>
        /// type_id integer
        /// </summary>
        [JsonProperty("type_id")]
        public int TypeId { get; set; }
    }
}
