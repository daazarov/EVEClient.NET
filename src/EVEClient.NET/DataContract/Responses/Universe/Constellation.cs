using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class Constellation
    {
        /// <summary>
        /// constellation_id integer
        /// </summary>
        [JsonPropertyName("constellation_id")]
        public required int ConstellationId { get; init; }

        /// <summary>
        /// name string
        /// </summary>
        [JsonPropertyName("name")]
        public required string Name { get; init; }

        /// <summary>
        /// Position coordinates
        /// </summary>
        [JsonPropertyName("position")]
        public required Position Position { get; init; }

        /// <summary>
        /// The region this constellation is in
        /// </summary>
        [JsonPropertyName("region_id")]
        public required int RegionId { get; init; }

        /// <summary>
        /// systems array
        /// </summary>
        [JsonPropertyName("systems")]
        public required int[] Systems { get; init; }
    }
}
