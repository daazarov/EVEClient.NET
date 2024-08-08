using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class Planet
    {
        /// <summary>
        /// planet_id integer
        /// </summary>
        [JsonProperty("planet_id")]
        public required int PlanetId {  get; set; }

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
        /// The solar system this planet is in
        /// </summary>
        [JsonProperty("system_id")]
        public required int SystemId { get; init; }

        /// <summary>
        /// type_id integer
        /// </summary>
        [JsonProperty("type_id")]
        public required int TypeId { get; init; }
    }
}
