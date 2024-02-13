using Newtonsoft.Json;

namespace EVEOnline.ESI.Communication.DataContract
{
    public class Location
    {
        /// <summary>
        /// solar_system_id integer
        /// </summary>
        [JsonProperty("solar_system_id")]
        public int SolarSystemId { get; set; }

        /// <summary>
        /// station_id integer
        /// </summary>
        [JsonProperty("station_id")]
        public int? StationId { get; set; }

        /// <summary>
        /// structure_id integer
        /// </summary>
        [JsonProperty("structure_id")]
        public long? StructureId { get; set; }
    }
}
