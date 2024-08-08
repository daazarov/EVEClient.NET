using System;
using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class Bookmark
    {
        /// <summary>
        /// bookmark_id integer
        /// </summary>
        [JsonProperty("bookmark_id")]
        public int BookmarkId { get; init; }

        /// <summary>
        /// coordinates object
        /// </summary>
        [JsonProperty("coordinates")]
        public Coordinates? Coordinates { get; init; }

        /// <summary>
        /// created string
        /// </summary>
        [JsonProperty("created")]
        public DateTime Created { get; init; }

        /// <summary>
        /// creator_id integer
        /// </summary>
        [JsonProperty("creator_id")]
        public int CreatorId { get; init; }

        /// <summary>
        /// folder_id integer
        /// </summary>
        [JsonProperty("folder_id")]
        public int? FolderId { get; init; }

        /// <summary>
        /// item object
        /// </summary>
        [JsonProperty("item")]
        public BookmarkItem? Item { get; init; }

        /// <summary>
        /// label string
        /// </summary>
        [JsonProperty("label")]
        public string Label { get; init; }

        /// <summary>
        /// location_id integer
        /// </summary>
        [JsonProperty("location_id")]
        public int LocationId { get; init; }

        /// <summary>
        /// notes string
        /// </summary>
        [JsonProperty("notes")]
        public string Notes { get; init; }
    }
}
