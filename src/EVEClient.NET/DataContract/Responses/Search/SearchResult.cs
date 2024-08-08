using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class SearchResult
    {
        /// <summary>
        /// agent array
        /// </summary>
        [JsonProperty("agent")]
        public int[]? Agents { get; init; }

        /// <summary>
        /// alliance array
        /// </summary>
        [JsonProperty("alliance")]
        public int[]? Alliances { get; init; }

        /// <summary>
        /// character array
        /// </summary>
        [JsonProperty("character")]
        public int[]? Characters { get; init; }

        /// <summary>
        /// constellation array
        /// </summary>
        [JsonProperty("constellation")]
        public int[]? Constellations { get; init; }

        /// <summary>
        /// corporation array
        /// </summary>
        [JsonProperty("corporation")]
        public int[]? Corporations { get; init; }

        /// <summary>
        /// faction array
        /// </summary>
        [JsonProperty("faction")]
        public int[]? Factions { get; init; }

        /// <summary>
        /// inventory_type array
        /// </summary>
        [JsonProperty("inventory_type")]
        public int[]? InventoryTypes { get; init; }

        /// <summary>
        /// region array
        /// </summary>
        [JsonProperty("region")]
        public int[]? Regions { get; init; }

        /// <summary>
        /// solar_system array
        /// </summary>
        [JsonProperty("solar_system")]
        public int[]? SolarSystems { get; init; }

        /// <summary>
        /// station array
        /// </summary>
        [JsonProperty("station")]
        public int[]? Stations { get; init; }

        /// <summary>
        /// structure array
        /// </summary>
        [JsonProperty("structure")]
        public long[]? Structures { get; init; }
    }
}
