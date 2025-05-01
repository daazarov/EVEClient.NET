using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class DynamicItemInfo
    {
        /// <summary>
        /// The ID of the character who created the item
        /// </summary>
        [JsonPropertyName("created_by")]
        public required int CreatedBy { get; init; }
         
        /// <summary>
        /// dogma_attributes array
        /// </summary>
        [JsonPropertyName("dogma_attributes")]
        public required List<DogmaAttribute> DogmaAttributes { get; init; }

        /// <summary>
        /// dogma_effects array
        /// </summary>
        [JsonPropertyName("dogma_effects")]
        public required List<DogmaEffect> DogmaEffects { get; init; }

        /// <summary>
        /// The type ID of the mutator used to generate the dynamic item.
        /// </summary>
        [JsonPropertyName("mutator_type_id")]
        public required int MutatorTypeId { get; init; }

        /// <summary>
        /// The type ID of the source item the mutator was applied to create the dynamic item.
        /// </summary>
        [JsonPropertyName("source_type_id")]
        public required int SourceTypeId { get; init; }
    }

    public class DogmaAttribute
    {
        /// <summary>
        /// attribute_id integer
        /// </summary>
        [JsonPropertyName("attribute_id")]
        public required int AttributeId { get; init; }

        /// <summary>
        /// value number
        /// </summary>
        [JsonPropertyName("value")]
        public required float Value { get; init; }
    }

    public class DogmaEffect
    {
        /// <summary>
        /// effect_id integer
        /// </summary>
        [JsonPropertyName("effect_id")]
        public required int EffectId { get; init; }

        /// <summary>
        /// is_default boolean
        /// </summary>
        [JsonPropertyName("is_default")]
        public required bool IsDefault { get; init; }
    }
}
