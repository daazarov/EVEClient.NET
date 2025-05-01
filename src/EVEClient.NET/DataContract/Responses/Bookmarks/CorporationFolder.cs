using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class CorporationFolder
    {
        /// <summary>
        /// folder_id integer
        /// </summary>
        [JsonPropertyName("creator_id integer")]
        public int? CreatorId { get; init; }

        /// <summary>
        /// folder_id integer
        /// </summary>
        [JsonPropertyName("folder_id")]
        public required int FolderId { get; init; }

        /// <summary>
        /// name string
        /// </summary>
        [JsonPropertyName("name")]
        public required string Name { get; init; }
    }
}
