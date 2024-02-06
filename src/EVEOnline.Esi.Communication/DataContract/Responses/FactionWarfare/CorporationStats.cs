using System;
using Newtonsoft.Json;

namespace EVEOnline.Esi.Communication.DataContract
{
    public class CorporationStats
    {
        /// <summary>
        /// The enlistment date of the given corporation into faction warfare.
        /// Will not be included if corporation is not enlisted in faction warfare
        /// </summary>
        [JsonProperty("enlisted_on")]
        public DateTime? EnlistedOn { get; set; }

        /// <summary>
        /// The faction the given corporation is enlisted to fight for.
        /// Will not be included if corporation is not enlisted in faction warfare
        /// </summary>
        [JsonProperty("faction_id")]
        public int? FactionId { get; set; }

        /// <summary>
        /// kills array
        /// </summary>
        [JsonProperty("kills")]
        public Totals Kills { get; set; }

        /// <summary>
        /// How many pilots the enlisted corporation has.
        /// Will not be included if corporation is not enlisted in faction warfare
        /// </summary>
        [JsonProperty("pilots")]
        public int? Pilots { get; set; }

        /// <summary>
        /// victory_points array
        /// </summary>
        [JsonProperty("victory_points")]
        public Totals VictoryPoints { get; set; }
    }
}
