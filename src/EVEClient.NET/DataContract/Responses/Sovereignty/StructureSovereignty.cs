using System;
using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class StructureSovereignty
    {
        /// <summary>
        /// The alliance that owns the structure.
        /// </summary>
        [JsonProperty("alliance_id")]
        public required int AllianceId {  get; set; }

        /// <summary>
        /// Solar system in which the structure is located.
        /// </summary>
        [JsonProperty("solar_system_id")]
        public required int SolarSystemId { get; init; }

        /// <summary>
        /// Unique item ID for this structure.
        /// </summary>
        [JsonProperty("structure_id")]
        public required long StructureId { get; init; }

        /// <summary>
        /// A reference to the type of structure this is.
        /// </summary>
        [JsonProperty("structure_type_id")]
        public required int StructureTypeId { get; init; }

        /// <summary>
        /// The occupancy level for the next or current vulnerability window.
        /// This takes into account all development indexes and capital system bonuses.
        /// Also known as Activity Defense Multiplier from in the client.
        /// It increases the time that attackers must spend using their entosis links on the structure.
        /// </summary>
        [JsonProperty("vulnerability_occupancy_level")]
        public float? VulnerabilityOccupancyLevel { get; init; }

        /// <summary>
        /// The time at which the next or current vulnerability window ends.
        /// At the end of a vulnerability window the next window is recalculated and locked in along with the vulnerabilityOccupancyLevel.
        /// If the structure is not in 100% entosis control of the defender, it will go in to ‘overtime’ and stay vulnerable for as long as that situation persists.
        /// Only once the defenders have 100% entosis control and has the vulnerableEndTime passed does the vulnerability interval expire and a new one is calculated.
        /// </summary>
        [JsonProperty("vulnerable_end_time")]
        public DateTime? VulnerableEndTime { get; init; }

        /// <summary>
        /// The next time at which the structure will become vulnerable. Or the start time of the current window if current time is between this and vulnerableEndTime.
        /// </summary>
        [JsonProperty("vulnerable_start_time")]
        public DateTime? VulnerableStartTime { get; init; }
    }
}
