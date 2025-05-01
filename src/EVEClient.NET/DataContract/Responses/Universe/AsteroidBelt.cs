using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class AsteroidBelt
    {
        /// <summary>
        /// name string
        /// </summary>
        [JsonPropertyName("name")]
        public required string Name { get; init; }

        /// <summary>
        /// position coordinates
        /// </summary>
        [JsonPropertyName("position")]
        public required Position Position { get; init; }

        /// <summary>
        /// The solar system this asteroid belt is in
        /// </summary>
        [JsonPropertyName("system_id")]
        public required int SystemId { get; init; }
    }
}
