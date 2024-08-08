using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class ItemGroup
    {
        /// <summary>
        /// category_id integer
        /// </summary>
        [JsonProperty("category_id")]
        public int CategoryId { get; init; }

        /// <summary>
        /// group_id integer
        /// </summary>
        [JsonProperty("group_id")]
        public int GroupId { get; init; }

        /// <summary>
        /// name string
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; init; }

        /// <summary>
        /// published boolean
        /// </summary>
        [JsonProperty("published")]
        public bool Published { get; init; }

        /// <summary>
        /// types array
        /// </summary>
        [JsonProperty("types")]
        public int[] Types { get; init; }
    }
}
