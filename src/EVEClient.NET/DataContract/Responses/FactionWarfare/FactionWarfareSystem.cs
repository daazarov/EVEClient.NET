using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class FactionWarfareSystem
    {
        /// <summary>
        /// contested string
        /// </summary>
        [JsonProperty("contested")]
        public required Contested Contested { get; init; }

        /// <summary>
        /// occupier_faction_id integer
        /// </summary>
        [JsonProperty("occupier_faction_id")]
        public required int OccupierFactionId { get; init; }

        /// <summary>
        /// owner_faction_id integer
        /// </summary>
        [JsonProperty("owner_faction_id")]
        public required int OwnerFactionId { get; init; }

        /// <summary>
        /// solar_system_id integer
        /// </summary>
        [JsonProperty("solar_system_id")]
        public required int SolarSystemId { get; init; }

        /// <summary>
        /// victory_points integer
        /// </summary>
        [JsonProperty("victory_points")]
        public required int VictoryPoints { get; init; }

        /// <summary>
        /// victory_points_threshold integer
        /// </summary>
        [JsonProperty("victory_points_threshold")]
        public required int VictoryPointsThreshold { get; init; }
    }
}
