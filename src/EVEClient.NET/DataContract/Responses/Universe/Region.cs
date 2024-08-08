using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class Region
    {
        /// <summary>
        /// constellations array
        /// </summary>
        [JsonProperty("constellations")]
        public required int[] Constellations {  get; set; }

        /// <summary>
        /// description string
        /// </summary>
        [JsonProperty("description")]
        public string? Description { get; init; }

        /// <summary>
        /// name string
        /// </summary>
        [JsonProperty("name")]
        public required string Name { get; init; }

        /// <summary>
        /// region_id integer
        /// </summary>
        [JsonProperty("region_id")]
        public required int RegionId { get; init; }
    }
}
