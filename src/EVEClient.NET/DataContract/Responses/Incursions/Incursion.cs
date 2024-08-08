using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class Incursion
    {
        /// <summary>
        /// The constellation id in which this incursion takes place
        /// </summary>
        [JsonProperty("constellation_id")]
        public required int ConstellationId {  get; set; }

        /// <summary>
        /// The attacking faction’s id
        /// </summary>
        [JsonProperty("faction_id")]
        public required int FactionId { get; init; }

        /// <summary>
        /// Whether the final encounter has boss or not
        /// </summary>
        [JsonProperty("has_boss")]
        public required bool HasBoss { get; init; }

        /// <summary>
        /// A list of infested solar system ids that are a part of this incursion
        /// </summary>
        [JsonProperty("infested_solar_systems")]
        public required int[] InfestedSolarSystems { get; init; }

        /// <summary>
        /// Influence of this incursion as a float from 0 to 1
        /// </summary>
        [JsonProperty("influence")]
        public required float Influence {  get; set; }

        /// <summary>
        /// Staging solar system for this incursion
        /// </summary>
        [JsonProperty("staging_solar_system_id")]
        public required int StagingSolarSystemId { get; init; }

        /// <summary>
        /// The state of this incursion
        /// </summary>
        [JsonProperty("state")]
        public required IncursionState State { get; init; }

        /// <summary>
        /// The type of this incursion
        /// </summary>
        [JsonProperty("type")]
        public required string Type { get; init; }
    }
}
