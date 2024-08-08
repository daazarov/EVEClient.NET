using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class Shareholder
    {
        /// <summary>
        /// share_count integer
        /// </summary>
        [JsonProperty("share_count")]
        public long ShareCount { get; init; }

        /// <summary>
        /// shareholder_id integer
        /// </summary>
        [JsonProperty("shareholder_id")]
        public int ShareholderId { get; init; }

        /// <summary>
        /// shareholder_type string
        /// </summary>
        [JsonProperty("shareholder_type")]
        public ShareholderType ShareholderType { get; init; }
    }
}
