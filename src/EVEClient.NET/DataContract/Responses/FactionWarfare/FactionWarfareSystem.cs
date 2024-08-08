using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class FactionWarfareSystem
    {
        /// <summary>
        /// contested string
        /// </summary>
        [JsonProperty("contested")]
        public Contested Contested { get; init; }

        /// <summary>
        /// occupier_faction_id integer
        /// </summary>
        [JsonProperty("occupier_faction_id")]
        public int OccupierFactionId { get; init; }

        /// <summary>
        /// owner_faction_id integer
        /// </summary>
        [JsonProperty("owner_faction_id")]
        public int OwnerFactionId { get; init; }

        /// <summary>
        /// solar_system_id integer
        /// </summary>
        [JsonProperty("solar_system_id")]
        public int SolarSystemId { get; init; }

        /// <summary>
        /// victory_points integer
        /// </summary>
        [JsonProperty("victory_points")]
        public int VictoryPoints { get; init; }

        /// <summary>
        /// victory_points_threshold integer
        /// </summary>
        [JsonProperty("victory_points_threshold")]
        public int VictoryPointsThreshold { get; init; }
    }
}
