using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class CorporationFolder
    {
        /// <summary>
        /// folder_id integer
        /// </summary>
        [JsonProperty("creator_id integer")]
        public int? CreatorId { get; init; }

        /// <summary>
        /// folder_id integer
        /// </summary>
        [JsonProperty("folder_id")]
        public int FolderId { get; init; }

        /// <summary>
        /// name string
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; init; }
    }
}
