using System.Collections.Generic;
using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class EveType
    {
        /// <summary>
        /// capacity number
        /// </summary>
        [JsonProperty("capacity")]
        public float? Capacity {  get; set; }

        /// <summary>
        /// description string
        /// </summary>
        [JsonProperty("description")]
        public required string Description { get; init; }

        /// <summary>
        /// dogma_attributes array
        /// </summary>
        [JsonProperty("dogma_attributes")]
        public List<DogmaAttribute>? DogmaAttributes { get; init; }

        /// <summary>
        /// dogma_effects array
        /// </summary>
        [JsonProperty("dogma_effects")]
        public List<DogmaEffect>? DogmaEffects { get; init; }

        /// <summary>
        /// graphic_id integer
        /// </summary>
        [JsonProperty("graphic_id")]
        public int? GraphicId { get; init; }

        /// <summary>
        /// group_id integer
        /// </summary>
        [JsonProperty("group_id")]
        public required int GroupId { get; init; }

        /// <summary>
        /// icon_id integer
        /// </summary>
        [JsonProperty("icon_id")]
        public int? IconId { get; init; }

        /// <summary>
        /// This only exists for types that can be put on the market
        /// </summary>
        [JsonProperty("market_group_id")]
        public int? MarketGroupId { get; init; }

        /// <summary>
        /// mass number
        /// </summary>
        [JsonProperty("mass")]
        public float? Mass { get; init; }

        /// <summary>
        /// name string
        /// </summary>
        [JsonProperty("name")]
        public required string Name { get; init; }

        /// <summary>
        /// packaged_volume number
        /// </summary>
        [JsonProperty("packaged_volume")]
        public float? PackagedVolume { get; init; }

        /// <summary>
        /// portion_size integer
        /// </summary>
        [JsonProperty("portion_size")]
        public int? PortionSize { get; init; }

        /// <summary>
        /// published boolean
        /// </summary>
        [JsonProperty("published")]
        public required bool Published { get; init; }

        /// <summary>
        /// radius number
        /// </summary>
        [JsonProperty("radius")]
        public float? Radius { get; init; }

        /// <summary>
        /// type_id integer
        /// </summary>
        [JsonProperty("type_id")]
        public required int TypeId { get; init; }

        /// <summary>
        /// volume number
        /// </summary>
        [JsonProperty("volume")]
        public float? Volume { get; init; }
    }
}
