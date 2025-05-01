using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class Shareholder
    {
        /// <summary>
        /// share_count integer
        /// </summary>
        [JsonPropertyName("share_count")]
        public required long ShareCount { get; init; }

        /// <summary>
        /// shareholder_id integer
        /// </summary>
        [JsonPropertyName("shareholder_id")]
        public required int ShareholderId { get; init; }

        /// <summary>
        /// shareholder_type string
        /// </summary>
        [JsonPropertyName("shareholder_type")]
        public required ShareholderType ShareholderType { get; init; }
    }
}
