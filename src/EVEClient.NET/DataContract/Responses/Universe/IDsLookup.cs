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
        public List<LookupInfo> Agents {  get; set; }

        [JsonProperty("alliances")]
        public List<LookupInfo> Alliances { get; set; }

        [JsonProperty("characters")]
        public List<LookupInfo> Characters { get; set; }

        [JsonProperty("constellations")]
        public List<LookupInfo> Constellations { get; set; }

        [JsonProperty("corporations")]
        public List<LookupInfo> Corporations { get; set; }

        [JsonProperty("factions")]
        public List<LookupInfo> Factions { get; set; }

        [JsonProperty("inventory_types")]
        public List<LookupInfo> InventoryTypes { get; set; }

        [JsonProperty("regions")]
        public List<LookupInfo> Regions { get; set; }

        [JsonProperty("stations")]
        public List<LookupInfo> Stations { get; set; }

        [JsonProperty("systems")]
        public List<LookupInfo> Systems { get; set; }

        public class LookupInfo
        {
            [JsonProperty("id")]
            public int ID {  get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }
        }
    }
}
