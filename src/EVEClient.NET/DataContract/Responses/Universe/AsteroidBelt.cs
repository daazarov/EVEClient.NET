using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class AsteroidBelt
    {
        /// <summary>
        /// name string
        /// </summary>
        [JsonProperty("name")]
        public string Name {  get; set; }

        /// <summary>
        /// position coordinates
        /// </summary>
        [JsonProperty("position")]
        public Position Position { get; set; }

        /// <summary>
        /// The solar system this asteroid belt is in
        /// </summary>
        [JsonProperty("system_id")]
        public int SystemId { get; set; }
    }
}
