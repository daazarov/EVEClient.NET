using System;
using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class CorporationStats
    {
        /// <summary>
        /// The enlistment date of the given corporation into faction warfare.
        /// Will not be included if corporation is not enlisted in faction warfare
        /// </summary>
        [JsonPropertyName("enlisted_on")]
        public DateTime? EnlistedOn { get; init; }

        /// <summary>
        /// The faction the given corporation is enlisted to fight for.
        /// Will not be included if corporation is not enlisted in faction warfare
        /// </summary>
        [JsonPropertyName("faction_id")]
        public int? FactionId { get; init; }

        /// <summary>
        /// kills array
        /// </summary>
        [JsonPropertyName("kills")]
        public required Totals Kills { get; init; }

        /// <summary>
        /// How many pilots the enlisted corporation has.
        /// Will not be included if corporation is not enlisted in faction warfare
        /// </summary>
        [JsonPropertyName("pilots")]
        public int? Pilots { get; init; }

        /// <summary>
        /// victory_points array
        /// </summary>
        [JsonPropertyName("victory_points")]
        public required Totals VictoryPoints { get; init; }
    }
}
