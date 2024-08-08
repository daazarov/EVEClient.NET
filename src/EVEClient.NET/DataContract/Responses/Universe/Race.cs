﻿using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class Race
    {
        /// <summary>
        /// The alliance generally associated with this race
        /// </summary>
        [JsonProperty("alliance_id")]
        public int AllianceId { get; init; }

        /// <summary>
        /// description string
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; init; }

        /// <summary>
        /// name string
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; init; }

        /// <summary>
        /// race_id integer
        /// </summary>
        [JsonProperty("race_id")]
        public int RaceId { get; init; }
    }
}
