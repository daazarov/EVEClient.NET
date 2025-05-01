using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    /// <summary>
    /// List of id/name associations for a set of names divided by category. Any name passed in that did not have a match will be ommitted
    /// </summary>
    public class IDsLookup
    {
        [JsonPropertyName("agents")]
        public List<LookupInfo>? Agents { get; init; }

        [JsonPropertyName("alliances")]
        public List<LookupInfo>? Alliances { get; init; }

        [JsonPropertyName("characters")]
        public List<LookupInfo>? Characters { get; init; }

        [JsonPropertyName("constellations")]
        public List<LookupInfo>? Constellations { get; init; }

        [JsonPropertyName("corporations")]
        public List<LookupInfo>? Corporations { get; init; }

        [JsonPropertyName("factions")]
        public List<LookupInfo>? Factions { get; init; }

        [JsonPropertyName("inventory_types")]
        public List<LookupInfo>? InventoryTypes { get; init; }

        [JsonPropertyName("regions")]
        public List<LookupInfo>? Regions { get; init; }

        [JsonPropertyName("stations")]
        public List<LookupInfo>? Stations { get; init; }

        [JsonPropertyName("systems")]
        public List<LookupInfo>? Systems { get; init; }

        public class LookupInfo
        {
            [JsonPropertyName("id")]
            public int? ID { get; init; }

            [JsonPropertyName("name")]
            public string? Name { get; init; }
        }
    }
}
