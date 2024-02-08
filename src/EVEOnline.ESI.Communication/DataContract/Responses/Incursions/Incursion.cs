using Newtonsoft.Json;

namespace EVEOnline.ESI.Communication.DataContract
{
    public class Incursion
    {
        /// <summary>
        /// The constellation id in which this incursion takes place
        /// </summary>
        [JsonProperty("constellation_id")]
        public int ConstellationId {  get; set; }

        /// <summary>
        /// The attacking faction’s id
        /// </summary>
        [JsonProperty("faction_id")]
        public int FactionId { get; set; }

        /// <summary>
        /// Whether the final encounter has boss or not
        /// </summary>
        [JsonProperty("has_boss")]
        public bool HasBoss { get; set; }

        /// <summary>
        /// A list of infested solar system ids that are a part of this incursion
        /// </summary>
        [JsonProperty("infested_solar_systems")]
        public int[] InfestedSolarSystems { get; set; }

        /// <summary>
        /// Influence of this incursion as a float from 0 to 1
        /// </summary>
        [JsonProperty("influence")]
        public float Influence {  get; set; }

        /// <summary>
        /// Staging solar system for this incursion
        /// </summary>
        [JsonProperty("staging_solar_system_id")]
        public int StagingSolarSystemId { get; set; }

        /// <summary>
        /// The state of this incursion
        /// </summary>
        [JsonProperty("state")]
        public IncursionState State { get; set; }

        /// <summary>
        /// The type of this incursion
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
