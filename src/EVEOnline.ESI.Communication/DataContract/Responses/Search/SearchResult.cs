using Newtonsoft.Json;

namespace EVEOnline.ESI.Communication.DataContract
{
    public class SearchResult
    {
        /// <summary>
        /// agent array
        /// </summary>
        [JsonProperty("agent")]
        public int[] Agents { get; set; }

        /// <summary>
        /// alliance array
        /// </summary>
        [JsonProperty("alliance")]
        public int[] Alliances { get; set; }

        /// <summary>
        /// character array
        /// </summary>
        [JsonProperty("character")]
        public int[] Characters { get; set; }

        /// <summary>
        /// constellation array
        /// </summary>
        [JsonProperty("constellation")]
        public int[] Constellations { get; set; }

        /// <summary>
        /// corporation array
        /// </summary>
        [JsonProperty("corporation")]
        public int[] Corporations { get; set; }

        /// <summary>
        /// faction array
        /// </summary>
        [JsonProperty("faction")]
        public int[] Factions { get; set; }

        /// <summary>
        /// inventory_type array
        /// </summary>
        [JsonProperty("inventory_type")]
        public int[] InventoryTypes { get; set; }

        /// <summary>
        /// region array
        /// </summary>
        [JsonProperty("region")]
        public int[] Regions { get; set; }

        /// <summary>
        /// solar_system array
        /// </summary>
        [JsonProperty("solar_system")]
        public int[] SolarSystems { get; set; }

        /// <summary>
        /// station array
        /// </summary>
        [JsonProperty("station")]
        public int[] Stations { get; set; }

        /// <summary>
        /// structure array
        /// </summary>
        [JsonProperty("structure")]
        public long[] Structures { get; set; }
    }
}
