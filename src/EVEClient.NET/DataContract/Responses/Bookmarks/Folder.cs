using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class Folder
    {
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
