using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class ItemCategory
    {
        /// <summary>
        /// category_id integer
        /// </summary>
        [JsonPropertyName("category_id")]
        public required int CategoryId { get; init; }

        /// <summary>
        /// groups array
        /// </summary>
        [JsonPropertyName("groups")]
        public required int[] Groups { get; init; }

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
    }
}
