using Newtonsoft.Json;

namespace EVEOnline.Esi.Communication.DataContract
{
    public class BookmarkItem
    {
        /// <summary>
        /// item_id integer
        /// </summary>
        [JsonProperty("item_id")]
        public long item_id { get; set; }

        /// <summary>
        /// type_id integer
        /// </summary>
        [JsonProperty("type_id")]
        public int type_id { get; set; }
    }
}