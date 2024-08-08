using System.Collections.Generic;
using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class DynamicItemInfo
    {
        /// <summary>
        /// The ID of the character who created the item
        /// </summary>
        [JsonProperty("created_by")]
        public int CreatedBy { get; init; }
         
        /// <summary>
        /// dogma_attributes array
        /// </summary>
        [JsonProperty("dogma_attributes")]
        public List<DogmaAttribute> DogmaAttributes { get; init; }

        /// <summary>
        /// dogma_effects array
        /// </summary>
        [JsonProperty("dogma_effects")]
        public List<DogmaEffect> DogmaEffects { get; init; }

        /// <summary>
        /// The type ID of the mutator used to generate the dynamic item.
        /// </summary>
        [JsonProperty("mutator_type_id")]
        public int MutatorTypeId { get; init; }

        /// <summary>
        /// The type ID of the source item the mutator was applied to create the dynamic item.
        /// </summary>
        [JsonProperty("source_type_id")]
        public int SourceTypeId { get; init; }
    }

    public class DogmaAttribute
    {
        /// <summary>
        /// attribute_id integer
        /// </summary>
        [JsonProperty("attribute_id")]
        public int AttributeId { get; init; }

        /// <summary>
        /// value number
        /// </summary>
        [JsonProperty("value")]
        public float Value { get; init; }
    }

    public class DogmaEffect
    {
        /// <summary>
        /// effect_id integer
        /// </summary>
        [JsonProperty("effect_id")]
        public int EffectId { get; init; }

        /// <summary>
        /// is_default boolean
        /// </summary>
        [JsonProperty("is_default")]
        public bool IsDefault { get; init; }
    }
}
