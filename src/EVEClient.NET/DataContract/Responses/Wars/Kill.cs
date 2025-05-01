using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class Kill
    {
        /// <summary>
        /// A hash of this killmail
        /// </summary>
        [JsonPropertyName("killmail_hash")]
        public required string KillmailHash { get; init; }

        /// <summary>
        /// ID of this killmail
        /// </summary>
        [JsonPropertyName("killmail_id")]
        public required int KillmailId { get; init; }
    }
}
