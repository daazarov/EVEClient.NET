using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class ItemGroup
    {
        /// <summary>
        /// category_id integer
        /// </summary>
        [JsonProperty("category_id")]
        public required int CategoryId { get; init; }

        /// <summary>
        /// group_id integer
        /// </summary>
        [JsonProperty("group_id")]
        public required int GroupId { get; init; }

        /// <summary>
        /// name string
        /// </summary>
        [JsonProperty("name")]
        public required string Name { get; init; }

        /// <summary>
        /// published boolean
        /// </summary>
        [JsonProperty("published")]
        public required bool Published { get; init; }

        /// <summary>
        /// types array
        /// </summary>
        [JsonProperty("types")]
        public required int[] Types { get; init; }
    }
}
