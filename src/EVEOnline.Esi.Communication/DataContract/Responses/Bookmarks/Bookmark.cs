using System;
using Newtonsoft.Json;

namespace EVEOnline.Esi.Communication.DataContract
{
    public class Bookmark
    {
        /// <summary>
        /// bookmark_id integer
        /// </summary>
        [JsonProperty("bookmark_id")]
        public int BookmarkId { get; set; }

        /// <summary>
        /// coordinates object
        /// </summary>
        [JsonProperty("coordinates")]
        public Coordinates Coordinates { get; set; }

        /// <summary>
        /// created string
        /// </summary>
        [JsonProperty("created")]
        public DateTime Created { get; set; }

        /// <summary>
        /// creator_id integer
        /// </summary>
        [JsonProperty("creator_id")]
        public int CreatorId { get; set; }

        /// <summary>
        /// folder_id integer
        /// </summary>
        [JsonProperty("folder_id")]
        public int? FolderId { get; set; }

        /// <summary>
        /// item object
        /// </summary>
        [JsonProperty("item")]
        public BookmarkItem Item { get; set; }

        /// <summary>
        /// label string
        /// </summary>
        [JsonProperty("label")]
        public string Label { get; set; }

        /// <summary>
        /// location_id integer
        /// </summary>
        [JsonProperty("location_id")]
        public int LocationId { get; set; }

        /// <summary>
        /// notes string
        /// </summary>
        [JsonProperty("notes")]
        public string Notes { get; set; }
    }
}
