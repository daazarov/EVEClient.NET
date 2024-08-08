using System;
using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class CorporationMedal
    {
        /// <summary>
        /// created_at string
        /// </summary>
        [JsonProperty("created_at")]
        public required DateTime CreatedAt {  get; set; }

        /// <summary>
        /// ID of the character who created this medal
        /// </summary>
        [JsonProperty("creator_id")]
        public required int CreatorId { get; init; }

        /// <summary>
        /// description string
        /// </summary>
        [JsonProperty("description")]
        public required string Description { get; init; }

        /// <summary>
        /// medal_id integer
        /// </summary>
        [JsonProperty("medal_id")]
        public required int MedalId { get; init; }

        /// <summary>
        /// title string
        /// </summary>
        [JsonProperty("title")]
        public required string Title { get; init; }
    }
}
