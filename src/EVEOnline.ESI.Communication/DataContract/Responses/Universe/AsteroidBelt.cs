using Newtonsoft.Json;

namespace EVEOnline.ESI.Communication.DataContract
{
    public class AsteroidBelt
    {
        /// <summary>
        /// name string
        /// </summary>
        [JsonProperty("name")]
        public string name {  get; set; }

        /// <summary>
        /// position coordinates
        /// </summary>
        [JsonProperty("position")]
        public Position Position { get; set; }

        /// <summary>
        /// The solar system this asteroid belt is in
        /// </summary>
        [JsonProperty("system_id")]
        public int system_id { get; set; }
    }
}
