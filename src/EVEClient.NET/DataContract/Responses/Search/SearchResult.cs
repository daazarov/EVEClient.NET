using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class SearchResult
    {
        /// <summary>
        /// agent array
        /// </summary>
        [JsonPropertyName("agent")]
        public int[]? Agents { get; init; }

        /// <summary>
        /// alliance array
        /// </summary>
        [JsonPropertyName("alliance")]
        public int[]? Alliances { get; init; }

        /// <summary>
        /// character array
        /// </summary>
        [JsonPropertyName("character")]
        public int[]? Characters { get; init; }

        /// <summary>
        /// constellation array
        /// </summary>
        [JsonPropertyName("constellation")]
        public int[]? Constellations { get; init; }

        /// <summary>
        /// corporation array
        /// </summary>
        [JsonPropertyName("corporation")]
        public int[]? Corporations { get; init; }

        /// <summary>
        /// faction array
        /// </summary>
        [JsonPropertyName("faction")]
        public int[]? Factions { get; init; }

        /// <summary>
        /// inventory_type array
        /// </summary>
        [JsonPropertyName("inventory_type")]
        public int[]? InventoryTypes { get; init; }

        /// <summary>
        /// region array
        /// </summary>
        [JsonPropertyName("region")]
        public int[]? Regions { get; init; }

        /// <summary>
        /// solar_system array
        /// </summary>
        [JsonPropertyName("solar_system")]
        public int[]? SolarSystems { get; init; }

        /// <summary>
        /// station array
        /// </summary>
        [JsonPropertyName("station")]
        public int[]? Stations { get; init; }

        /// <summary>
        /// structure array
        /// </summary>
        [JsonPropertyName("structure")]
        public long[]? Structures { get; init; }
    }
}
