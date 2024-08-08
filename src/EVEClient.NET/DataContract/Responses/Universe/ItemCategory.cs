using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class ItemCategory
    {
        /// <summary>
        /// category_id integer
        /// </summary>
        [JsonProperty("category_id")]
        public required int CategoryId {  get; set; }

        /// <summary>
        /// groups array
        /// </summary>
        [JsonProperty("groups")]
        public required int[] Groups { get; init; }

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
    }
}
