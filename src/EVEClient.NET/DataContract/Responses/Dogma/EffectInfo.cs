using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class EffectInfo
    {
        /// <summary>
        /// IEnumerable<KeyValuePair<TKey, TValue>>
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; init; }

        /// <summary>
        /// disallow_auto_repeat boolean
        /// </summary>
        [JsonPropertyName("disallow_auto_repeat")]
        public bool? DisallowAutoRepeat { get; init; }

        /// <summary>
        /// discharge_attribute_id integer
        /// </summary>
        [JsonPropertyName("discharge_attribute_id")]
        public int? DischargeAttributeId { get; init; }

        /// <summary>
        /// display_name string
        /// </summary>
        [JsonPropertyName("display_name")]
        public string? DisplayName { get; init; }

        /// <summary>
        /// duration_attribute_id integer
        /// </summary>
        [JsonPropertyName("duration_attribute_id")]
        public int? DurationAttributeId { get; init; }

        /// <summary>
        /// effect_category integer
        /// </summary>
        [JsonPropertyName("effect_category")]
        public int? EffectCategory { get; init; }

        /// <summary>
        /// effect_id integer
        /// </summary>
        [JsonPropertyName("effect_id")]
        public required int EffectId { get; init; }

        /// <summary>
        /// electronic_chance boolean
        /// </summary>
        [JsonPropertyName("electronic_chance")]
        public bool? ElectronicChance { get; init; }

        /// <summary>
        /// falloff_attribute_id integer
        /// </summary>
        [JsonPropertyName("falloff_attribute_id")]
        public int? FalloffAttributeId { get; init; }

        /// <summary>
        /// icon_id integer
        /// </summary>
        [JsonPropertyName("icon_id")]
        public int? IconId { get; init; }

        /// <summary>
        /// is_assistance boolean
        /// </summary>
        [JsonPropertyName("is_assistance")]
        public bool? IsAssistance { get; init; }

        /// <summary>
        /// is_offensive boolean
        /// </summary>
        [JsonPropertyName("is_offensive")]
        public bool? IsOffensive { get; init; }

        /// <summary>
        /// is_warp_safe boolean
        /// </summary>
        [JsonPropertyName("is_warp_safe")]
        public bool? IsWarpSafe { get; init; }

        /// <summary>
        /// modifiers array
        /// </summary>
        [JsonPropertyName("modifiers")]
        public Modifier[]? Modifiers { get; init; }

        /// <summary>
        /// name string
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; init; }

        /// <summary>
        /// post_expression integer
        /// </summary>
        [JsonPropertyName("post_expression")]
        public int? PostExpression { get; init; }

        /// <summary>
        /// pre_expression integer
        /// </summary>
        [JsonPropertyName("pre_expression")]
        public int? PreExpression { get; init; }

        /// <summary>
        /// published boolean
        /// </summary>
        [JsonPropertyName("published")]
        public bool? Published { get; init; }

        /// <summary>
        /// range_attribute_id integer
        /// </summary>
        [JsonPropertyName("range_attribute_id")]
        public int? RangeAttributeId { get; init; }

        /// <summary>
        /// range_chance boolean
        /// </summary>
        [JsonPropertyName("range_chance")]
        public bool? RangeChance { get; init; }

        /// <summary>
        /// tracking_speed_attribute_id integer
        /// </summary>
        [JsonPropertyName("tracking_speed_attribute_id")]
        public int? TrackingSpeedAttributeId { get; init; }
    }

    public class Modifier
    {
        /// <summary>
        /// domain string
        /// </summary>
        [JsonPropertyName("domain")]
        public string? Domain { get; init; }

        /// <summary>
        /// effect_id integer
        /// </summary>
        [JsonPropertyName("effect_id")]
        public int? EffectId { get; init; }

        /// <summary>
        /// func string
        /// </summary>
        [JsonPropertyName("func")]
        public required string Func { get; init; }

        /// <summary>
        /// modified_attribute_id integer
        /// </summary>
        [JsonPropertyName("modified_attribute_id")]
        public int? ModifiedAttributeId { get; init; }

        /// <summary>
        /// modifying_attribute_id integer
        /// </summary>
        [JsonPropertyName("modifying_attribute_id")]
        public int? ModifyingAttributeId { get; init; }

        /// <summary>
        /// operator integer
        /// </summary>
        [JsonPropertyName("operator")]
        public int? Operator { get; init; }
    }
}
