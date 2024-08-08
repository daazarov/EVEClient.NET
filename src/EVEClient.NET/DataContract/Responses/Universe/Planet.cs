using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class Planet
    {
        /// <summary>
        /// planet_id integer
        /// </summary>
        [JsonProperty("planet_id")]
        public int PlanetId { get; init; }

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
        /// The solar system this planet is in
        /// </summary>
        [JsonProperty("system_id")]
        public int SystemId { get; init; }

        /// <summary>
        /// type_id integer
        /// </summary>
        [JsonProperty("type_id")]
        public int TypeId { get; init; }
    }
}
