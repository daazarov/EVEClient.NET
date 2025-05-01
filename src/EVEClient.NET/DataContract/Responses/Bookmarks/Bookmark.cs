using System;
using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class Bookmark
    {
        /// <summary>
        /// bookmark_id integer
        /// </summary>
        [JsonPropertyName("bookmark_id")]
        public required int BookmarkId { get; init; }

        /// <summary>
        /// coordinates object
        /// </summary>
        [JsonPropertyName("coordinates")]
        public Coordinates? Coordinates { get; init; }

        /// <summary>
        /// created string
        /// </summary>
        [JsonPropertyName("created")]
        public required DateTime Created { get; init; }

        /// <summary>
        /// creator_id integer
        /// </summary>
        [JsonPropertyName("creator_id")]
        public required int CreatorId { get; init; }

        /// <summary>
        /// folder_id integer
        /// </summary>
        [JsonPropertyName("folder_id")]
        public int? FolderId { get; init; }

        /// <summary>
        /// item object
        /// </summary>
        [JsonPropertyName("item")]
        public BookmarkItem? Item { get; init; }

        /// <summary>
        /// label string
        /// </summary>
        [JsonPropertyName("label")]
        public required string Label { get; init; }

        /// <summary>
        /// location_id integer
        /// </summary>
        [JsonPropertyName("location_id")]
        public required int LocationId { get; init; }

        /// <summary>
        /// notes string
        /// </summary>
        [JsonPropertyName("notes")]
        public required string Notes { get; init; }
    }
}
