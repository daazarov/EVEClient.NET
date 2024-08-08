using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class StructureInfo
    {
        /// <summary>
        /// The full name of the structure
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; init; }

        /// <summary>
        /// The ID of the corporation who owns this particular structure
        /// </summary>
        [JsonProperty("owner_id")]
        public int OwnerId { get; init; }

        /// <summary>
        /// position object
        /// </summary>
        [JsonProperty("position")]
        public Position? Position { get; init; }

        /// <summary>
        /// solar_system_id integer
        /// </summary>
        [JsonProperty("solar_system_id")]
        public int SolarSystemId { get; init; }

        /// <summary>
        /// type_id integer
        /// </summary>
        [JsonProperty("type_id")]
        public int? TypeId { get; init; }
    }
}
