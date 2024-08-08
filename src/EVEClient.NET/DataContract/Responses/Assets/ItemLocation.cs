using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class ItemLocation
    {
        /// <summary>
        /// item_id integer
        /// </summary>
        [JsonProperty("item_id")]
        public long ItemId { get; init; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("position")]
        public Position Position { get; init; }
    }
}
