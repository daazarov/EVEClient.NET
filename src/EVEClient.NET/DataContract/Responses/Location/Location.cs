using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class Location
    {
        /// <summary>
        /// solar_system_id integer
        /// </summary>
        [JsonPropertyName("solar_system_id")]
        public required int SolarSystemId { get; init; }

        /// <summary>
        /// station_id integer
        /// </summary>
        [JsonPropertyName("station_id")]
        public int? StationId { get; init; }

        /// <summary>
        /// structure_id integer
        /// </summary>
        [JsonPropertyName("structure_id")]
        public long? StructureId { get; init; }
    }
}
