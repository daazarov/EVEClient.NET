using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class Constellation
    {
        /// <summary>
        /// constellation_id integer
        /// </summary>
        [JsonProperty("constellation_id")]
        public required int ConstellationId {  get; set; }

        /// <summary>
        /// name string
        /// </summary>
        [JsonProperty("name")]
        public required string Name { get; init; }

        /// <summary>
        /// Position coordinates
        /// </summary>
        [JsonProperty("position")]
        public required Position Position { get; init; }

        /// <summary>
        /// The region this constellation is in
        /// </summary>
        [JsonProperty("region_id")]
        public required int RegionId { get; init; }

        /// <summary>
        /// systems array
        /// </summary>
        [JsonProperty("systems")]
        public required int[] Systems { get; init; }
    }
}
