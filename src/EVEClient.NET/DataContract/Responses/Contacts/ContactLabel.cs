using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class ContactLabel
    {
        /// <summary>
        /// label_id integer
        /// </summary>
        [JsonPropertyName("label_id")]
        public required long LabelId { get; init; }

        /// <summary>
        /// label_name string
        /// </summary>
        [JsonPropertyName("label_name")]
        public required string LabelName { get; init; }
    }
}
