using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class Region
    {
        /// <summary>
        /// constellations array
        /// </summary>
        [JsonProperty("constellations")]
        public int[] Constellations { get; init; }

        /// <summary>
        /// description string
        /// </summary>
        [JsonProperty("description")]
        public string? Description { get; init; }

        /// <summary>
        /// name string
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; init; }

        /// <summary>
        /// region_id integer
        /// </summary>
        [JsonProperty("region_id")]
        public int RegionId { get; init; }
    }
}
