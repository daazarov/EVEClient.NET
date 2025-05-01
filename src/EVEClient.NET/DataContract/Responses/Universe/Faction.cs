using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class Faction
    {
        /// <summary>
        /// corporation_id integer
        /// </summary>
        [JsonPropertyName("corporation_id")]
        public int? CorporationId { get; init; }

        /// <summary>
        /// description string
        /// </summary>
        [JsonPropertyName("description")]
        public required string Description { get; init; }

        /// <summary>
        /// faction_id integer
        /// </summary>
        [JsonPropertyName("faction_id")]
        public required int FactionId { get; init; }

        /// <summary>
        /// is_unique boolean
        /// </summary>
        [JsonPropertyName("is_unique")]
        public required bool IsUnique { get; init; }

        /// <summary>
        /// militia_corporation_id integer
        /// </summary>
        [JsonPropertyName("militia_corporation_id")]
        public int? MilitiaCorporationId { get; init; }

        /// <summary>
        /// name string
        /// </summary>
        [JsonPropertyName("name")]
        public required string Name { get; init; }

        /// <summary>
        /// size_factor number
        /// </summary>
        [JsonPropertyName("size_factor")]
        public required float SizeFactor { get; init; }

        /// <summary>
        /// solar_system_id integer
        /// </summary>
        [JsonPropertyName("solar_system_id")]
        public int? SolarSystemId { get; init; }

        /// <summary>
        /// station_count integer
        /// </summary>
        [JsonPropertyName("station_count")]
        public required int StationCount { get; init; }

        /// <summary>
        /// station_system_count integer
        /// </summary>
        [JsonPropertyName("station_system_count")]
        public required int StationSystemCount { get; init; }
    }
}
