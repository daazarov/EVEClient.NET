using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class ItemLocation
    {
        /// <summary>
        /// item_id integer
        /// </summary>
        [JsonProperty("item_id")]
        public long ItemId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("position")]
        public Position Position { get; set; }
    }
}
