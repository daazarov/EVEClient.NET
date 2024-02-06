using Newtonsoft.Json;

namespace EVEOnline.Esi.Communication.DataContract
{
    public class FactionStats
    {
        /// <summary>
        /// faction_id integer
        /// </summary>
        [JsonProperty("faction_id")]
        public int FactionId { get; set; }

        /// <summary>
        /// kills array
        /// </summary>
        [JsonProperty("kills")]
        public Totals Kills { get; set; }

        /// <summary>
        /// How many pilots fight for the given faction
        /// </summary>
        [JsonProperty("pilots")]
        public int Pilots { get; set; }

        /// <summary>
        /// The number of solar systems controlled by the given faction
        /// </summary>
        [JsonProperty("systems_controlled")]
        public int SystemsControlled { get; set; }

        /// <summary>
        /// victory_points array
        /// </summary>
        [JsonProperty("victory_points")]
        public Totals VictoryPoints { get; set; }
    }
}
