using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class Incursion
    {
        /// <summary>
        /// The constellation id in which this incursion takes place
        /// </summary>
        [JsonPropertyName("constellation_id")]
        public required int ConstellationId { get; init; }

        /// <summary>
        /// The attacking faction’s id
        /// </summary>
        [JsonPropertyName("faction_id")]
        public required int FactionId { get; init; }

        /// <summary>
        /// Whether the final encounter has boss or not
        /// </summary>
        [JsonPropertyName("has_boss")]
        public required bool HasBoss { get; init; }

        /// <summary>
        /// A list of infested solar system ids that are a part of this incursion
        /// </summary>
        [JsonPropertyName("infested_solar_systems")]
        public required int[] InfestedSolarSystems { get; init; }

        /// <summary>
        /// Influence of this incursion as a float from 0 to 1
        /// </summary>
        [JsonPropertyName("influence")]
        public required float Influence { get; init; }

        /// <summary>
        /// Staging solar system for this incursion
        /// </summary>
        [JsonPropertyName("staging_solar_system_id")]
        public required int StagingSolarSystemId { get; init; }

        /// <summary>
        /// The state of this incursion
        /// </summary>
        [JsonPropertyName("state")]
        public required IncursionState State { get; init; }

        /// <summary>
        /// The type of this incursion
        /// </summary>
        [JsonPropertyName("type")]
        public required string Type { get; init; }
    }
}
