using Newtonsoft.Json;

namespace EVEOnline.ESI.Communication.DataContract
{
    public class ItemGroup
    {
        /// <summary>
        /// category_id integer
        /// </summary>
        [JsonProperty("category_id")]
        public int CategoryId {  get; set; }

        /// <summary>
        /// group_id integer
        /// </summary>
        [JsonProperty("group_id")]
        public int GroupId { get; set; }

        /// <summary>
        /// name string
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// published boolean
        /// </summary>
        [JsonProperty("published")]
        public bool Published { get; set; }

        /// <summary>
        /// types array
        /// </summary>
        [JsonProperty("types")]
        public int[] Types { get; set; }
    }
}
