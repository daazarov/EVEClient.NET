using System;
using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class CorporationMedal
    {
        /// <summary>
        /// created_at string
        /// </summary>
        [JsonPropertyName("created_at")]
        public required DateTime CreatedAt { get; init; }

        /// <summary>
        /// ID of the character who created this medal
        /// </summary>
        [JsonPropertyName("creator_id")]
        public required int CreatorId { get; init; }

        /// <summary>
        /// description string
        /// </summary>
        [JsonPropertyName("description")]
        public required string Description { get; init; }

        /// <summary>
        /// medal_id integer
        /// </summary>
        [JsonPropertyName("medal_id")]
        public required int MedalId { get; init; }

        /// <summary>
        /// title string
        /// </summary>
        [JsonPropertyName("title")]
        public required string Title { get; init; }
    }
}
