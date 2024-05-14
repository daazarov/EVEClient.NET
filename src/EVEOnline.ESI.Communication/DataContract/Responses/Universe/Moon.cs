using Newtonsoft.Json;

namespace EVEOnline.ESI.Communication.DataContract
{
    public class Moon
    {
        /// <summary>
        /// moon_id integer
        /// </summary>
        [JsonProperty("moon_id")]
        public int MoonId {  get; set; }

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
        /// The solar system this moon is in
        /// </summary>
        [JsonProperty("system_id")]
        public int SystemId { get; set; }
    }
}
