using System;
using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class Starbase
    {
        /// <summary>
        /// The moon this starbase (POS) is anchored on, unanchored POSes do not have this information
        /// </summary>
        [JsonPropertyName("moon_id")]
        public int? MoonId { get; init; }

        /// <summary>
        /// When the POS onlined, for starbases (POSes) in online state
        /// </summary>
        [JsonPropertyName("onlined_since")]
        public DateTime? OnlinedSince { get; init; }

        /// <summary>
        /// When the POS will be out of reinforcement, for starbases (POSes) in reinforced state
        /// </summary>
        [JsonPropertyName("reinforced_until")]
        public DateTime? ReinforcedUntil { get; init; }

        /// <summary>
        /// Unique ID for this starbase (POS)
        /// </summary>
        [JsonPropertyName("starbase_id")]
        public required long StarbaseId { get; init; }

        /// <summary>
        /// state string
        /// </summary>
        [JsonPropertyName("state")]
        public StarbaseState? State { get; init; }

        /// <summary>
        /// The solar system this starbase (POS) is in, unanchored POSes have this information
        /// </summary>
        [JsonPropertyName("system_id")]
        public required int SystemId { get; init; }

        /// <summary>
        /// Starbase (POS) type
        /// </summary>
        [JsonPropertyName("type_id")]
        public required int TypeId { get; init; }

        /// <summary>
        /// When the POS started unanchoring, for starbases (POSes) in unanchoring state
        /// </summary>
        [JsonPropertyName("unanchor_at")]
        public DateTime? UnanchorAt { get; init; }
    }
}
