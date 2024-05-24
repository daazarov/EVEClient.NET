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
        public int CreatedBy {  get; set; }

        /// <summary>
        /// dogma_attributes array
        /// </summary>
        [JsonProperty("dogma_attributes")]
        public List<DogmaAttribute> DogmaAttributes { get; set; }

        /// <summary>
        /// dogma_effects array
        /// </summary>
        [JsonProperty("dogma_effects")]
        public List<DogmaEffect> DogmaEffects { get; set; }

        /// <summary>
        /// The type ID of the mutator used to generate the dynamic item.
        /// </summary>
        [JsonProperty("mutator_type_id")]
        public int MutatorTypeId { get; set; }

        /// <summary>
        /// The type ID of the source item the mutator was applied to create the dynamic item.
        /// </summary>
        [JsonProperty("source_type_id")]
        public int SourceTypeId { get; set; }
    }

    public class DogmaAttribute
    {
        /// <summary>
        /// attribute_id integer
        /// </summary>
        [JsonProperty("attribute_id")]
        public int AttributeId { get; set; }

        /// <summary>
        /// value number
        /// </summary>
        [JsonProperty("value")]
        public float Value { get; set; }
    }

    public class DogmaEffect
    {
        /// <summary>
        /// effect_id integer
        /// </summary>
        [JsonProperty("effect_id")]
        public int EffectId { get; set; }

        /// <summary>
        /// is_default boolean
        /// </summary>
        [JsonProperty("is_default")]
        public bool IsDefault { get; set; }
    }
}
