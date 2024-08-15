using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class Shareholder
    {
        /// <summary>
        /// share_count integer
        /// </summary>
        [JsonProperty("share_count")]
        public required long ShareCount { get; init; }

        /// <summary>
        /// shareholder_id integer
        /// </summary>
        [JsonProperty("shareholder_id")]
        public required int ShareholderId { get; init; }

        /// <summary>
        /// shareholder_type string
        /// </summary>
        [JsonProperty("shareholder_type")]
        public required ShareholderType ShareholderType { get; init; }
    }
}
