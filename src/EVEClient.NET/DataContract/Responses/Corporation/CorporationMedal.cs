﻿using System;
using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class CorporationMedal
    {
        /// <summary>
        /// created_at string
        /// </summary>
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; init; }

        /// <summary>
        /// ID of the character who created this medal
        /// </summary>
        [JsonProperty("creator_id")]
        public int CreatorId { get; init; }

        /// <summary>
        /// description string
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; init; }

        /// <summary>
        /// medal_id integer
        /// </summary>
        [JsonProperty("medal_id")]
        public int MedalId { get; init; }

        /// <summary>
        /// title string
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; init; }
    }
}
