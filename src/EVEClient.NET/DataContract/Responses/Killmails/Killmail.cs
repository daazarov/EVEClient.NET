using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class Killmail
    {
        /// <summary>
        /// A hash of this killmail
        /// </summary>
        [JsonProperty("killmail_hash")]
        public required string Hash { get; init; }

        /// <summary>
        /// ID of this killmail
        /// </summary>
        [JsonProperty("killmail_id")]
        public required int Id { get; init; }
    }
}
