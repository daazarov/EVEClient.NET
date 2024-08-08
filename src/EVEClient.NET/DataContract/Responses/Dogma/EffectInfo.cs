using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class EffectInfo
    {
        /// <summary>
        /// IEnumerable<KeyValuePair<TKey, TValue>>
        /// </summary>
        [JsonProperty("description")]
        public string? Description {  get; set; }

        /// <summary>
        /// disallow_auto_repeat boolean
        /// </summary>
        [JsonProperty("disallow_auto_repeat")]
        public bool? DisallowAutoRepeat { get; init; }

        /// <summary>
        /// discharge_attribute_id integer
        /// </summary>
        [JsonProperty("discharge_attribute_id")]
        public int? DischargeAttributeId { get; init; }

        /// <summary>
        /// display_name string
        /// </summary>
        [JsonProperty("display_name")]
        public string? DisplayName { get; init; }

        /// <summary>
        /// duration_attribute_id integer
        /// </summary>
        [JsonProperty("duration_attribute_id")]
        public int? DurationAttributeId { get; init; }

        /// <summary>
        /// effect_category integer
        /// </summary>
        [JsonProperty("effect_category")]
        public int? EffectCategory {  get; set; }

        /// <summary>
        /// effect_id integer
        /// </summary>
        [JsonProperty("effect_id")]
        public required int EffectId { get; init; }

        /// <summary>
        /// electronic_chance boolean
        /// </summary>
        [JsonProperty("electronic_chance")]
        public bool? ElectronicChance { get; init; }

        /// <summary>
        /// falloff_attribute_id integer
        /// </summary>
        [JsonProperty("falloff_attribute_id")]
        public int? FalloffAttributeId { get; init; }

        /// <summary>
        /// icon_id integer
        /// </summary>
        [JsonProperty("icon_id")]
        public int? IconId { get; init; }

        /// <summary>
        /// is_assistance boolean
        /// </summary>
        [JsonProperty("is_assistance")]
        public bool? IsAssistance { get; init; }

        /// <summary>
        /// is_offensive boolean
        /// </summary>
        [JsonProperty("is_offensive")]
        public bool? IsOffensive { get; init; }

        /// <summary>
        /// is_warp_safe boolean
        /// </summary>
        [JsonProperty("is_warp_safe")]
        public bool? IsWarpSafe { get; init; }

        /// <summary>
        /// modifiers array
        /// </summary>
        [JsonProperty("modifiers")]
        public Modifier[]? Modifiers { get; init; }

        /// <summary>
        /// name string
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; init; }

        /// <summary>
        /// post_expression integer
        /// </summary>
        [JsonProperty("post_expression")]
        public int? PostExpression {  get; set; }

        /// <summary>
        /// pre_expression integer
        /// </summary>
        [JsonProperty("pre_expression")]
        public int? PreExpression { get; init; }

        /// <summary>
        /// published boolean
        /// </summary>
        [JsonProperty("published")]
        public bool? Published { get; init; }

        /// <summary>
        /// range_attribute_id integer
        /// </summary>
        [JsonProperty("range_attribute_id")]
        public int? RangeAttributeId { get; init; }

        /// <summary>
        /// range_chance boolean
        /// </summary>
        [JsonProperty("range_chance")]
        public bool? RangeChance { get; init; }

        /// <summary>
        /// tracking_speed_attribute_id integer
        /// </summary>
        [JsonProperty("tracking_speed_attribute_id")]
        public int? TrackingSpeedAttributeId { get; init; }
    }

    public class Modifier
    {
        /// <summary>
        /// domain string
        /// </summary>
        [JsonProperty("domain")]
        public string? Domain { get; init; }

        /// <summary>
        /// effect_id integer
        /// </summary>
        [JsonProperty("effect_id")]
        public int? EffectId { get; init; }

        /// <summary>
        /// func string
        /// </summary>
        [JsonProperty("func")]
        public required string Func { get; init; }

        /// <summary>
        /// modified_attribute_id integer
        /// </summary>
        [JsonProperty("modified_attribute_id")]
        public int? ModifiedAttributeId { get; init; }

        /// <summary>
        /// modifying_attribute_id integer
        /// </summary>
        [JsonProperty("modifying_attribute_id")]
        public int? ModifyingAttributeId { get; init; }

        /// <summary>
        /// operator integer
        /// </summary>
        [JsonProperty("operator")]
        public int? Operator { get; init; }
    }
}
