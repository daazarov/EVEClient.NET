using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class BookmarkItem
    {
        /// <summary>
        /// item_id integer
        /// </summary>
        [JsonProperty("item_id")]
        public required long item_id { get; init; }

        /// <summary>
        /// type_id integer
        /// </summary>
        [JsonProperty("type_id")]
        public required int type_id { get; init; }
    }
}