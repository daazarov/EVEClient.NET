using Newtonsoft.Json;

namespace EVEOnline.Esi.Communication.DataContract
{
    public class EffectInfo
    {
        /// <summary>
        /// IEnumerable<KeyValuePair<TKey, TValue>>
        /// </summary>
        [JsonProperty("description")]
        public string Description {  get; set; }

        /// <summary>
        /// disallow_auto_repeat boolean
        /// </summary>
        [JsonProperty("disallow_auto_repeat")]
        public bool? DisallowAutoRepeat { get; set; }

        /// <summary>
        /// discharge_attribute_id integer
        /// </summary>
        [JsonProperty("discharge_attribute_id")]
        public int? DischargeAttributeId { get; set; }

        /// <summary>
        /// display_name string
        /// </summary>
        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        /// <summary>
        /// duration_attribute_id integer
        /// </summary>
        [JsonProperty("duration_attribute_id")]
        public int? DurationAttributeId { get; set; }

        /// <summary>
        /// effect_category integer
        /// </summary>
        [JsonProperty("effect_category")]
        public int? EffectCategory {  get; set; }

        /// <summary>
        /// effect_id integer
        /// </summary>
        [JsonProperty("effect_id")]
        public int EffectId { get; set; }

        /// <summary>
        /// electronic_chance boolean
        /// </summary>
        [JsonProperty("electronic_chance")]
        public bool? ElectronicChance { get; set; }

        /// <summary>
        /// falloff_attribute_id integer
        /// </summary>
        [JsonProperty("falloff_attribute_id")]
        public int? FalloffAttributeId { get; set; }

        /// <summary>
        /// icon_id integer
        /// </summary>
        [JsonProperty("icon_id")]
        public int? IconId { get; set; }

        /// <summary>
        /// is_assistance boolean
        /// </summary>
        [JsonProperty("is_assistance")]
        public bool? IsAssistance { get; set; }

        /// <summary>
        /// is_offensive boolean
        /// </summary>
        [JsonProperty("is_offensive")]
        public bool? IsOffensive { get; set; }

        /// <summary>
        /// is_warp_safe boolean
        /// </summary>
        [JsonProperty("is_warp_safe")]
        public bool? IsWarpSafe { get; set; }

        /// <summary>
        /// modifiers array
        /// </summary>
        [JsonProperty("modifiers")]
        public Modifier[] Modifiers { get; set; }

        /// <summary>
        /// name string
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// post_expression integer
        /// </summary>
        [JsonProperty("post_expression")]
        public int? PostExpression {  get; set; }

        /// <summary>
        /// pre_expression integer
        /// </summary>
        [JsonProperty("pre_expression")]
        public int? PreExpression { get; set; }

        /// <summary>
        /// published boolean
        /// </summary>
        [JsonProperty("published")]
        public bool? Published { get; set; }

        /// <summary>
        /// range_attribute_id integer
        /// </summary>
        [JsonProperty("range_attribute_id")]
        public int? RangeAttributeId { get; set; }

        /// <summary>
        /// range_chance boolean
        /// </summary>
        [JsonProperty("range_chance")]
        public bool? RangeChance { get; set; }

        /// <summary>
        /// tracking_speed_attribute_id integer
        /// </summary>
        [JsonProperty("tracking_speed_attribute_id")]
        public int? TrackingSpeedAttributeId { get; set; }
    }

    public class Modifier
    {
        /// <summary>
        /// domain string
        /// </summary>
        [JsonProperty("domain")]
        public string Domain { get; set; }

        /// <summary>
        /// effect_id integer
        /// </summary>
        [JsonProperty("effect_id")]
        public int? EffectId { get; set; }

        /// <summary>
        /// func string
        /// </summary>
        [JsonProperty("func")]
        public string Func { get; set; }

        /// <summary>
        /// modified_attribute_id integer
        /// </summary>
        [JsonProperty("modified_attribute_id")]
        public int? ModifiedAttributeId { get; set; }

        /// <summary>
        /// modifying_attribute_id integer
        /// </summary>
        [JsonProperty("modifying_attribute_id")]
        public int? ModifyingAttributeId { get; set; }

        /// <summary>
        /// operator integer
        /// </summary>
        [JsonProperty("operator")]
        public int? Operator { get; set; }
    }
}
