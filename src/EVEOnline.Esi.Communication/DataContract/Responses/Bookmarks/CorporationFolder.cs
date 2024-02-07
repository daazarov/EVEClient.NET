using Newtonsoft.Json;

namespace EVEOnline.ESI.Communication.DataContract
{
    public class CorporationFolder
    {
        /// <summary>
        /// folder_id integer
        /// </summary>
        [JsonProperty("creator_id integer")]
        public int? CreatorId { get; set; }

        /// <summary>
        /// folder_id integer
        /// </summary>
        [JsonProperty("folder_id")]
        public int FolderId { get; set; }

        /// <summary>
        /// name string
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
