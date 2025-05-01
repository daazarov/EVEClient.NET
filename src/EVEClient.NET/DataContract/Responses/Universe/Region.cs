using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class Region
    {
        /// <summary>
        /// constellations array
        /// </summary>
        [JsonPropertyName("constellations")]
        public required int[] Constellations { get; init; }

        /// <summary>
        /// description string
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; init; }

        /// <summary>
        /// name string
        /// </summary>
        [JsonPropertyName("name")]
        public required string Name { get; init; }

        /// <summary>
        /// region_id integer
        /// </summary>
        [JsonPropertyName("region_id")]
        public required int RegionId { get; init; }
    }
}
