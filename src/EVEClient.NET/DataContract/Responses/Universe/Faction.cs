using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class Faction
    {
        /// <summary>
        /// corporation_id integer
        /// </summary>
        [JsonProperty("corporation_id")]
        public int? CorporationId { get; init; }

        /// <summary>
        /// description string
        /// </summary>
        [JsonProperty("description")]
        public required string Description { get; init; }

        /// <summary>
        /// faction_id integer
        /// </summary>
        [JsonProperty("faction_id")]
        public required int FactionId { get; init; }

        /// <summary>
        /// is_unique boolean
        /// </summary>
        [JsonProperty("is_unique")]
        public required bool IsUnique { get; init; }

        /// <summary>
        /// militia_corporation_id integer
        /// </summary>
        [JsonProperty("militia_corporation_id")]
        public int? MilitiaCorporationId { get; init; }

        /// <summary>
        /// name string
        /// </summary>
        [JsonProperty("name")]
        public required string Name { get; init; }

        /// <summary>
        /// size_factor number
        /// </summary>
        [JsonProperty("size_factor")]
        public required float SizeFactor { get; init; }

        /// <summary>
        /// solar_system_id integer
        /// </summary>
        [JsonProperty("solar_system_id")]
        public int? SolarSystemId { get; init; }

        /// <summary>
        /// station_count integer
        /// </summary>
        [JsonProperty("station_count")]
        public required int StationCount { get; init; }

        /// <summary>
        /// station_system_count integer
        /// </summary>
        [JsonProperty("station_system_count")]
        public required int StationSystemCount { get; init; }
    }
}
