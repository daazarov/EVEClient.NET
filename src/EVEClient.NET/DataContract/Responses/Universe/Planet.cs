using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class Planet
    {
        /// <summary>
        /// planet_id integer
        /// </summary>
        [JsonProperty("planet_id")]
        public int PlanetId {  get; set; }

        /// <summary>
        /// name string
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// position object
        /// </summary>
        [JsonProperty("position")]
        public Position Position { get; set; }

        /// <summary>
        /// The solar system this planet is in
        /// </summary>
        [JsonProperty("system_id")]
        public int SystemId { get; set; }

        /// <summary>
        /// type_id integer
        /// </summary>
        [JsonProperty("type_id")]
        public int TypeId { get; set; }
    }
}
