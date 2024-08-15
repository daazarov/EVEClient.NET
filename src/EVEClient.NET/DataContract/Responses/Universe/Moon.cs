using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class Moon
    {
        /// <summary>
        /// moon_id integer
        /// </summary>
        [JsonProperty("moon_id")]
        public required int MoonId { get; init; }

        /// <summary>
        /// name string
        /// </summary>
        [JsonProperty("name")]
        public required string Name { get; init; }

        /// <summary>
        /// position object
        /// </summary>
        [JsonProperty("position")]
        public required Position Position { get; init; }

        /// <summary>
        /// The solar system this moon is in
        /// </summary>
        [JsonProperty("system_id")]
        public required int SystemId { get; init; }
    }
}
