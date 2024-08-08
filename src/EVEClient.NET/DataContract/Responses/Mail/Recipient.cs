using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class Recipient
    {
        /// <summary>
        /// recipient_id integer
        /// </summary>
        [JsonProperty("recipient_id")]
        public required int RecipientId { get; init; }

        /// <summary>
        /// recipient_type string
        /// </summary>
        [JsonProperty("recipient_type")]
        public required RecipientType RecipientType { get; init; }
    }
}
