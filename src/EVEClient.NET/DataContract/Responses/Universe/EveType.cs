using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class EveType
    {
        /// <summary>
        /// capacity number
        /// </summary>
        [JsonPropertyName("capacity")]
        public float? Capacity { get; init; }

        /// <summary>
        /// description string
        /// </summary>
        [JsonPropertyName("description")]
        public required string Description { get; init; }

        /// <summary>
        /// dogma_attributes array
        /// </summary>
        [JsonPropertyName("dogma_attributes")]
        public List<DogmaAttribute>? DogmaAttributes { get; init; }

        /// <summary>
        /// dogma_effects array
        /// </summary>
        [JsonPropertyName("dogma_effects")]
        public List<DogmaEffect>? DogmaEffects { get; init; }

        /// <summary>
        /// graphic_id integer
        /// </summary>
        [JsonPropertyName("graphic_id")]
        public int? GraphicId { get; init; }

        /// <summary>
        /// group_id integer
        /// </summary>
        [JsonPropertyName("group_id")]
        public required int GroupId { get; init; }

        /// <summary>
        /// icon_id integer
        /// </summary>
        [JsonPropertyName("icon_id")]
        public int? IconId { get; init; }

        /// <summary>
        /// This only exists for types that can be put on the market
        /// </summary>
        [JsonPropertyName("market_group_id")]
        public int? MarketGroupId { get; init; }

        /// <summary>
        /// mass number
        /// </summary>
        [JsonPropertyName("mass")]
        public float? Mass { get; init; }

        /// <summary>
        /// name string
        /// </summary>
        [JsonPropertyName("name")]
        public required string Name { get; init; }

        /// <summary>
        /// packaged_volume number
        /// </summary>
        [JsonPropertyName("packaged_volume")]
        public float? PackagedVolume { get; init; }

        /// <summary>
        /// portion_size integer
        /// </summary>
        [JsonPropertyName("portion_size")]
        public int? PortionSize { get; init; }

        /// <summary>
        /// published boolean
        /// </summary>
        [JsonPropertyName("published")]
        public required bool Published { get; init; }

        /// <summary>
        /// radius number
        /// </summary>
        [JsonPropertyName("radius")]
        public float? Radius { get; init; }

        /// <summary>
        /// type_id integer
        /// </summary>
        [JsonPropertyName("type_id")]
        public required int TypeId { get; init; }

        /// <summary>
        /// volume number
        /// </summary>
        [JsonPropertyName("volume")]
        public float? Volume { get; init; }
    }
}
