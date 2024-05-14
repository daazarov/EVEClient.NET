using Newtonsoft.Json;

namespace EVEOnline.ESI.Communication.DataContract
{
    public class ItemCategory
    {
        /// <summary>
        /// category_id integer
        /// </summary>
        [JsonProperty("category_id")]
        public int CategoryId {  get; set; }

        /// <summary>
        /// groups array
        /// </summary>
        [JsonProperty("groups")]
        public int[] Groups { get; set; }

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
    }
}
