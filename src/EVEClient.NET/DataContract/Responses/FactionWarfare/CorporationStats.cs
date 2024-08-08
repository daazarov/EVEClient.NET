using System;
using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class CorporationStats
    {
        /// <summary>
        /// The enlistment date of the given corporation into faction warfare.
        /// Will not be included if corporation is not enlisted in faction warfare
        /// </summary>
        [JsonProperty("enlisted_on")]
        public DateTime? EnlistedOn { get; init; }

        /// <summary>
        /// The faction the given corporation is enlisted to fight for.
        /// Will not be included if corporation is not enlisted in faction warfare
        /// </summary>
        [JsonProperty("faction_id")]
        public int? FactionId { get; init; }

        /// <summary>
        /// kills array
        /// </summary>
        [JsonProperty("kills")]
        public Totals Kills { get; init; }

        /// <summary>
        /// How many pilots the enlisted corporation has.
        /// Will not be included if corporation is not enlisted in faction warfare
        /// </summary>
        [JsonProperty("pilots")]
        public int? Pilots { get; init; }

        /// <summary>
        /// victory_points array
        /// </summary>
        [JsonProperty("victory_points")]
        public Totals VictoryPoints { get; init; }
    }
}
