using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class StructureInfo
    {
        /// <summary>
        /// The full name of the structure
        /// </summary>
        [JsonPropertyName("name")]
        public required string Name { get; init; }

        /// <summary>
        /// The ID of the corporation who owns this particular structure
        /// </summary>
        [JsonPropertyName("owner_id")]
        public required int OwnerId { get; init; }

        /// <summary>
        /// position object
        /// </summary>
        [JsonPropertyName("position")]
        public Position? Position { get; init; }

        /// <summary>
        /// solar_system_id integer
        /// </summary>
        [JsonPropertyName("solar_system_id")]
        public required int SolarSystemId { get; init; }

        /// <summary>
        /// type_id integer
        /// </summary>
        [JsonPropertyName("type_id")]
        public int? TypeId { get; init; }
    }
}
