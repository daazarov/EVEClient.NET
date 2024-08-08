using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class Kill
    {
        /// <summary>
        /// A hash of this killmail
        /// </summary>
        [JsonProperty("killmail_hash")]
        public string KillmailHash { get; init; }

        /// <summary>
        /// ID of this killmail
        /// </summary>
        [JsonProperty("killmail_id")]
        public int KillmailId { get; init; }
    }
}
