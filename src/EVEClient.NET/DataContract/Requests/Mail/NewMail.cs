using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class NewMail
    {
        [JsonPropertyName("approved_cost")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public long? ApprovedCost { get; set; }

        [JsonPropertyName("body")]
        public required string Body { get; set; }

        [JsonPropertyName("recipients")]
        public required List<Recipient> Recipients { get; set; }

        [JsonPropertyName("subject")]
        public required string Subject { get; set; }

        public class Recipient
        {
            [JsonPropertyName("recipient_id")]
            public required int RecipientId { get; set; }

            [JsonPropertyName("recipient_type")]
            public required RecipientType RecipientType { get; set; }
        }
    }
}
