using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class Killmail
    {
        /// <summary>
        /// A hash of this killmail
        /// </summary>
        [JsonPropertyName("killmail_hash")]
        public required string Hash { get; init; }

        /// <summary>
        /// ID of this killmail
        /// </summary>
        [JsonPropertyName("killmail_id")]
        public required int Id { get; init; }
    }
}
