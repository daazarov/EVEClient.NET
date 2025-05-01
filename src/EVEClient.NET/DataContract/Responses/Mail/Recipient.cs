using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class Recipient
    {
        /// <summary>
        /// recipient_id integer
        /// </summary>
        [JsonPropertyName("recipient_id")]
        public required int RecipientId { get; init; }

        /// <summary>
        /// recipient_type string
        /// </summary>
        [JsonPropertyName("recipient_type")]
        public required RecipientType RecipientType { get; init; }
    }
}
