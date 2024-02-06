using Newtonsoft.Json;

namespace EVEOnline.Esi.Communication.DataContract
{
    public class FactionWarfareSystem
    {
        /// <summary>
        /// contested string
        /// </summary>
        [JsonProperty("contested")]
        public Contested Contested {  get; set; }

        /// <summary>
        /// occupier_faction_id integer
        /// </summary>
        [JsonProperty("occupier_faction_id")]
        public int OccupierFactionId { get; set; }

        /// <summary>
        /// owner_faction_id integer
        /// </summary>
        [JsonProperty("owner_faction_id")]
        public int OwnerFactionId { get; set; }

        /// <summary>
        /// solar_system_id integer
        /// </summary>
        [JsonProperty("solar_system_id")]
        public int SolarSystemId { get; set; }

        /// <summary>
        /// victory_points integer
        /// </summary>
        [JsonProperty("victory_points")]
        public int VictoryPoints {  get; set; }

        /// <summary>
        /// victory_points_threshold integer
        /// </summary>
        [JsonProperty("victory_points_threshold")]
        public int VictoryPointsThreshold { get; set; }
    }
}
