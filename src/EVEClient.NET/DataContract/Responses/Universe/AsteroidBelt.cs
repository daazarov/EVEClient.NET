using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class AsteroidBelt
    {
        /// <summary>
        /// name string
        /// </summary>
        [JsonProperty("name")]
        public required string Name { get; init; }

        /// <summary>
        /// position coordinates
        /// </summary>
        [JsonProperty("position")]
        public required Position Position { get; init; }

        /// <summary>
        /// The solar system this asteroid belt is in
        /// </summary>
        [JsonProperty("system_id")]
        public required int SystemId { get; init; }
    }
}
