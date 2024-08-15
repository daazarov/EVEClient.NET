using System;
using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class Starbase
    {
        /// <summary>
        /// The moon this starbase (POS) is anchored on, unanchored POSes do not have this information
        /// </summary>
        [JsonProperty("moon_id")]
        public int? MoonId { get; init; }

        /// <summary>
        /// When the POS onlined, for starbases (POSes) in online state
        /// </summary>
        [JsonProperty("onlined_since")]
        public DateTime? OnlinedSince { get; init; }

        /// <summary>
        /// When the POS will be out of reinforcement, for starbases (POSes) in reinforced state
        /// </summary>
        [JsonProperty("reinforced_until")]
        public DateTime? ReinforcedUntil { get; init; }

        /// <summary>
        /// Unique ID for this starbase (POS)
        /// </summary>
        [JsonProperty("starbase_id")]
        public required long StarbaseId { get; init; }

        /// <summary>
        /// state string
        /// </summary>
        [JsonProperty("state")]
        public StarbaseState? State { get; init; }

        /// <summary>
        /// The solar system this starbase (POS) is in, unanchored POSes have this information
        /// </summary>
        [JsonProperty("system_id")]
        public required int SystemId { get; init; }

        /// <summary>
        /// Starbase (POS) type
        /// </summary>
        [JsonProperty("type_id")]
        public required int TypeId { get; init; }

        /// <summary>
        /// When the POS started unanchoring, for starbases (POSes) in unanchoring state
        /// </summary>
        [JsonProperty("unanchor_at")]
        public DateTime? UnanchorAt { get; init; }
    }
}
