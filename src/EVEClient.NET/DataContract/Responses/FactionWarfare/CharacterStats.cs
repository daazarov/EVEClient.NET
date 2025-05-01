using System;
using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class CharacterStats
    {
        /// <summary>
        /// The given character’s current faction rank
        /// </summary>
        [JsonPropertyName("current_rank")]
        public int? CurrentRank { get; init; }

        /// <summary>
        /// The enlistment date of the given character into faction warfare.
        /// Will not be included if character is not enlisted in faction warfare
        /// </summary>
        [JsonPropertyName("enlisted_on")]
        public DateTime? EnlistedOn { get; init; }

        /// <summary>
        /// The faction the given character is enlisted to fight for.
        /// Will not be included if character is not enlisted in faction warfare
        /// </summary>
        [JsonPropertyName("faction_id")]
        public int? FactionId { get; init; }

        /// <summary>
        /// The given character’s highest faction rank achieved
        /// </summary>
        [JsonPropertyName("highest_rank")]
        public int? HighestRank { get; init; }

        /// <summary>
        /// kills array
        /// </summary>
        [JsonPropertyName("kills")]
        public required Totals Kills { get; init; }

        /// <summary>
        /// victory_points array
        /// </summary>
        [JsonPropertyName("victory_points")]
        public required Totals VictoryPoints { get; init; }
    }
}
