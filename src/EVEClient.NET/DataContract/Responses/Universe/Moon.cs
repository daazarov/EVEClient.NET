using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class Moon
    {
        /// <summary>
        /// moon_id integer
        /// </summary>
        [JsonPropertyName("moon_id")]
        public required int MoonId { get; init; }

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
        /// The solar system this moon is in
        /// </summary>
        [JsonPropertyName("system_id")]
        public required int SystemId { get; init; }
    }
}
