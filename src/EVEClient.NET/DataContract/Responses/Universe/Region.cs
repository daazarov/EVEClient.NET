using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class Region
    {
        /// <summary>
        /// constellations array
        /// </summary>
        [JsonProperty("constellations")]
        public int[] Constellations {  get; set; }

        /// <summary>
        /// description string
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// name string
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// region_id integer
        /// </summary>
        [JsonProperty("region_id")]
        public int RegionId { get; set; }
    }
}
