using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class ItemName
    {
        /// <summary>
        /// item_id integer
        /// </summary>
        [JsonProperty("item_id")]
        public long ItemId { get; init; }

        /// <summary>
        /// name string
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; init; }
    }
}
