using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class Location
    {
        /// <summary>
        /// solar_system_id integer
        /// </summary>
        [JsonProperty("solar_system_id")]
        public required int SolarSystemId { get; init; }

        /// <summary>
        /// station_id integer
        /// </summary>
        [JsonProperty("station_id")]
        public int? StationId { get; init; }

        /// <summary>
        /// structure_id integer
        /// </summary>
        [JsonProperty("structure_id")]
        public long? StructureId { get; init; }
    }
}
