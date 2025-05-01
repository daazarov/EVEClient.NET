using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class BookmarkItem
    {
        /// <summary>
        /// item_id integer
        /// </summary>
        [JsonPropertyName("item_id")]
        public required long item_id { get; init; }

        /// <summary>
        /// type_id integer
        /// </summary>
        [JsonPropertyName("type_id")]
        public required int type_id { get; init; }
    }
}