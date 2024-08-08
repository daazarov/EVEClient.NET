using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class Moon
    {
        /// <summary>
        /// moon_id integer
        /// </summary>
        [JsonProperty("moon_id")]
        public int MoonId { get; init; }

        /// <summary>
        /// name string
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; init; }

        /// <summary>
        /// position object
        /// </summary>
        [JsonProperty("position")]
        public Position Position { get; init; }

        /// <summary>
        /// The solar system this moon is in
        /// </summary>
        [JsonProperty("system_id")]
        public int SystemId { get; init; }
    }
}
