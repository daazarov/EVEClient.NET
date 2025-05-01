using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class ItemName
    {
        /// <summary>
        /// item_id integer
        /// </summary>
        [JsonPropertyName("item_id")]
        public required long ItemId { get; init; }

        /// <summary>
        /// name string
        /// </summary>
        [JsonPropertyName("name")]
        public required string Name { get; init; }
    }
}
