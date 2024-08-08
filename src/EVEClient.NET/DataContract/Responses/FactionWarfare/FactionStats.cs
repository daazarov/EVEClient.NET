using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class FactionStats
    {
        /// <summary>
        /// faction_id integer
        /// </summary>
        [JsonProperty("faction_id")]
        public int FactionId { get; init; }

        /// <summary>
        /// kills array
        /// </summary>
        [JsonProperty("kills")]
        public Totals Kills { get; init; }

        /// <summary>
        /// How many pilots fight for the given faction
        /// </summary>
        [JsonProperty("pilots")]
        public int Pilots { get; init; }

        /// <summary>
        /// The number of solar systems controlled by the given faction
        /// </summary>
        [JsonProperty("systems_controlled")]
        public int SystemsControlled { get; init; }

        /// <summary>
        /// victory_points array
        /// </summary>
        [JsonProperty("victory_points")]
        public Totals VictoryPoints { get; init; }
    }
}
