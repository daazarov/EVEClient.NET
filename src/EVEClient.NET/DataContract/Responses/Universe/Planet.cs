using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class Planet
    {
        /// <summary>
        /// planet_id integer
        /// </summary>
        [JsonPropertyName("planet_id")]
        public required int PlanetId { get; init; }

        /// <summary>
        /// name string
        /// </summary>
        [JsonPropertyName("name")]
        public required string Name { get; init; }

        /// <summary>
        /// position object
        /// </summary>
        [JsonPropertyName("position")]
        public required Position Position { get; init; }

        /// <summary>
        /// The solar system this planet is in
        /// </summary>
        [JsonPropertyName("system_id")]
        public required int SystemId { get; init; }

        /// <summary>
        /// type_id integer
        /// </summary>
        [JsonPropertyName("type_id")]
        public required int TypeId { get; init; }
    }
}
