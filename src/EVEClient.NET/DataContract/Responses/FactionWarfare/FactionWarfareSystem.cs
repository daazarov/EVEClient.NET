using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class FactionWarfareSystem
    {
        /// <summary>
        /// contested string
        /// </summary>
        [JsonPropertyName("contested")]
        public required Contested Contested { get; init; }

        /// <summary>
        /// occupier_faction_id integer
        /// </summary>
        [JsonPropertyName("occupier_faction_id")]
        public required int OccupierFactionId { get; init; }

        /// <summary>
        /// owner_faction_id integer
        /// </summary>
        [JsonPropertyName("owner_faction_id")]
        public required int OwnerFactionId { get; init; }

        /// <summary>
        /// solar_system_id integer
        /// </summary>
        [JsonPropertyName("solar_system_id")]
        public required int SolarSystemId { get; init; }

        /// <summary>
        /// victory_points integer
        /// </summary>
        [JsonPropertyName("victory_points")]
        public required int VictoryPoints { get; init; }

        /// <summary>
        /// victory_points_threshold integer
        /// </summary>
        [JsonPropertyName("victory_points_threshold")]
        public required int VictoryPointsThreshold { get; init; }
    }
}
