using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class Constellation
    {
        /// <summary>
        /// constellation_id integer
        /// </summary>
        [JsonProperty("constellation_id")]
        public int ConstellationId {  get; set; }

        /// <summary>
        /// name string
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Position coordinates
        /// </summary>
        [JsonProperty("position")]
        public Position Position { get; set; }

        /// <summary>
        /// The region this constellation is in
        /// </summary>
        [JsonProperty("region_id")]
        public int RegionId { get; set; }

        /// <summary>
        /// systems array
        /// </summary>
        [JsonProperty("systems")]
        public int[] Systems { get; set; }
    }
}
