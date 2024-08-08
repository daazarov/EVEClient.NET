using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class ItemLocation
    {
        /// <summary>
        /// item_id integer
        /// </summary>
        [JsonProperty("item_id")]
        public required long ItemId { get; init; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("position")]
        public required Position Position { get; init; }
    }
}
