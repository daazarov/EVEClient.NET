using Newtonsoft.Json;

namespace EVEOnline.ESI.Communication.DataContract
{
    public class Faction
    {
        /// <summary>
        /// corporation_id integer
        /// </summary>
        [JsonProperty("corporation_id")]
        public int? CorporationId {  get; set; }

        /// <summary>
        /// description string
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// faction_id integer
        /// </summary>
        [JsonProperty("faction_id")]
        public int FactionId { get; set; }

        /// <summary>
        /// is_unique boolean
        /// </summary>
        [JsonProperty("is_unique")]
        public bool IsUnique { get; set; }

        /// <summary>
        /// militia_corporation_id integer
        /// </summary>
        [JsonProperty("militia_corporation_id")]
        public int? MilitiaCorporationId { get; set; }

        /// <summary>
        /// name string
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// size_factor number
        /// </summary>
        [JsonProperty("size_factor")]
        public float SizeFactor { get; set; }

        /// <summary>
        /// solar_system_id integer
        /// </summary>
        [JsonProperty("solar_system_id")]
        public int? SolarSystemId { get; set; }

        /// <summary>
        /// station_count integer
        /// </summary>
        [JsonProperty("station_count")]
        public int StationCount { get; set; }

        /// <summary>
        /// station_system_count integer
        /// </summary>
        [JsonProperty("station_system_count")]
        public int StationSystemCount { get; set; }
    }
}
