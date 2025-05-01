using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class FactionStats
    {
        /// <summary>
        /// faction_id integer
        /// </summary>
        [JsonPropertyName("faction_id")]
        public required int FactionId { get; init; }

        /// <summary>
        /// kills array
        /// </summary>
        [JsonPropertyName("kills")]
        public required Totals Kills { get; init; }

        /// <summary>
        /// How many pilots fight for the given faction
        /// </summary>
        [JsonPropertyName("pilots")]
        public required int Pilots { get; init; }

        /// <summary>
        /// The number of solar systems controlled by the given faction
        /// </summary>
        [JsonPropertyName("systems_controlled")]
        public required int SystemsControlled { get; init; }

        /// <summary>
        /// victory_points array
        /// </summary>
        [JsonPropertyName("victory_points")]
        public required Totals VictoryPoints { get; init; }
    }
}
