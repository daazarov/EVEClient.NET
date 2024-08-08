using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class AsteroidBelt
    {
        /// <summary>
        /// name string
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; init; }

        /// <summary>
        /// position coordinates
        /// </summary>
        [JsonProperty("position")]
        public Position Position { get; init; }

        /// <summary>
        /// The solar system this asteroid belt is in
        /// </summary>
        [JsonProperty("system_id")]
        public int SystemId { get; init; }
    }
}
