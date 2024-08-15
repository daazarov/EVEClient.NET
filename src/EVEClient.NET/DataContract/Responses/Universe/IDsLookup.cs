using System.Collections.Generic;
using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    /// <summary>
    /// List of id/name associations for a set of names divided by category. Any name passed in that did not have a match will be ommitted
    /// </summary>
    public class IDsLookup
    {
        [JsonProperty("agents")]
        public List<LookupInfo>? Agents { get; init; }

        [JsonProperty("alliances")]
        public List<LookupInfo>? Alliances { get; init; }

        [JsonProperty("characters")]
        public List<LookupInfo>? Characters { get; init; }

        [JsonProperty("constellations")]
        public List<LookupInfo>? Constellations { get; init; }

        [JsonProperty("corporations")]
        public List<LookupInfo>? Corporations { get; init; }

        [JsonProperty("factions")]
        public List<LookupInfo>? Factions { get; init; }

        [JsonProperty("inventory_types")]
        public List<LookupInfo>? InventoryTypes { get; init; }

        [JsonProperty("regions")]
        public List<LookupInfo>? Regions { get; init; }

        [JsonProperty("stations")]
        public List<LookupInfo>? Stations { get; init; }

        [JsonProperty("systems")]
        public List<LookupInfo>? Systems { get; init; }

        public class LookupInfo
        {
            [JsonProperty("id")]
            public int? ID { get; init; }

            [JsonProperty("name")]
            public string? Name { get; init; }
        }
    }
}
