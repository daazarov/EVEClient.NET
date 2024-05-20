using Newtonsoft.Json;

namespace EVEOnline.ESI.Communication.DataContract
{
    public class Kill
    {
        /// <summary>
        /// A hash of this killmail
        /// </summary>
        [JsonProperty("killmail_hash")]
        public string KillmailHash { get; set; }

        /// <summary>
        /// ID of this killmail
        /// </summary>
        [JsonProperty("killmail_id")]
        public int KillmailId { get; set; }
    }
}
