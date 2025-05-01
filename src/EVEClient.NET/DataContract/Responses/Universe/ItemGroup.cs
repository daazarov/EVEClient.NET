using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class ItemGroup
    {
        /// <summary>
        /// category_id integer
        /// </summary>
        [JsonPropertyName("category_id")]
        public required int CategoryId { get; init; }

        /// <summary>
        /// group_id integer
        /// </summary>
        [JsonPropertyName("group_id")]
        public required int GroupId { get; init; }

        /// <summary>
        /// name string
        /// </summary>
        [JsonPropertyName("name")]
        public required string Name { get; init; }

        /// <summary>
        /// published boolean
        /// </summary>
        [JsonPropertyName("published")]
        public required bool Published { get; init; }

        /// <summary>
        /// types array
        /// </summary>
        [JsonPropertyName("types")]
        public required int[] Types { get; init; }
    }
}
