using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class ItemLocation
    {
        /// <summary>
        /// item_id integer
        /// </summary>
        [JsonPropertyName("item_id")]
        public required long ItemId { get; init; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("position")]
        public required Position Position { get; init; }
    }
}
