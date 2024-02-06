using System;
using Newtonsoft.Json;

namespace EVEOnline.Esi.Communication.DataContract
{
    public class CharacterStats
    {
        /// <summary>
        /// The given character’s current faction rank
        /// </summary>
        [JsonProperty("current_rank")]
        public int? CurrentRank {  get; set; }

        /// <summary>
        /// The enlistment date of the given character into faction warfare.
        /// Will not be included if character is not enlisted in faction warfare
        /// </summary>
        [JsonProperty("enlisted_on")]
        public DateTime? EnlistedOn { get; set; }

        /// <summary>
        /// The faction the given character is enlisted to fight for.
        /// Will not be included if character is not enlisted in faction warfare
        /// </summary>
        [JsonProperty("faction_id")]
        public int? FactionId { get; set; }

        /// <summary>
        /// The given character’s highest faction rank achieved
        /// </summary>
        [JsonProperty("highest_rank")]
        public int? HighestRank { get; set; }

        /// <summary>
        /// kills array
        /// </summary>
        [JsonProperty("kills")]
        public Totals Kills { get; set; }

        /// <summary>
        /// victory_points array
        /// </summary>
        [JsonProperty("victory_points")]
        public Totals VictoryPoints { get; set; }
    }
}
