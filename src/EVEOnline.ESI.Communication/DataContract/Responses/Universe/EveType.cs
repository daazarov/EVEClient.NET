using System.Collections.Generic;
using Newtonsoft.Json;

namespace EVEOnline.ESI.Communication.DataContract
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
        public string Description { get; set; }

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
        /// graphic_id integer
        /// </summary>
        [JsonProperty("graphic_id")]
        public int? GraphicId { get; set; }

        /// <summary>
        /// group_id integer
        /// </summary>
        [JsonProperty("group_id")]
        public int GroupId { get; set; }

        /// <summary>
        /// icon_id integer
        /// </summary>
        [JsonProperty("icon_id")]
        public int? IconId { get; set; }

        /// <summary>
        /// This only exists for types that can be put on the market
        /// </summary>
        [JsonProperty("market_group_id")]
        public int? MarketGroupId { get; set; }

        /// <summary>
        /// mass number
        /// </summary>
        [JsonProperty("mass")]
        public float? Mass { get; set; }

        /// <summary>
        /// name string
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// packaged_volume number
        /// </summary>
        [JsonProperty("packaged_volume")]
        public float? PackagedVolume { get; set; }

        /// <summary>
        /// portion_size integer
        /// </summary>
        [JsonProperty("portion_size")]
        public int? PortionSize { get; set; }

        /// <summary>
        /// published boolean
        /// </summary>
        [JsonProperty("published")]
        public bool Published { get; set; }

        /// <summary>
        /// radius number
        /// </summary>
        [JsonProperty("radius")]
        public float? Radius { get; set; }

        /// <summary>
        /// type_id integer
        /// </summary>
        [JsonProperty("type_id")]
        public int TypeId { get; set; }

        /// <summary>
        /// volume number
        /// </summary>
        [JsonProperty("volume")]
        public float? Volume { get; set; }
    }
}
