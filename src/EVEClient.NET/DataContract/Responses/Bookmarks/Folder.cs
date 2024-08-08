using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class Folder
    {
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
