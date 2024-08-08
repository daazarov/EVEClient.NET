using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class Structure
    {
        /// <summary>
        /// ID of the corporation that owns the structure
        /// </summary>
        [JsonProperty("corporation_id")]
        public required int CorporationId { get; init; }

        /// <summary>
        /// Date on which the structure will run out of fuel
        /// </summary>
        [JsonProperty("fuel_expires")]
        public DateTime? FuelExpires { get; init; }

        /// <summary>
        /// The structure name
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; init; }

        /// <summary>
        /// The date and time when the structure’s newly requested reinforcement times (e.g. next_reinforce_hour and next_reinforce_day) will take effect
        /// </summary>
        [JsonProperty("next_reinforce_apply")]
        public DateTime? NextReinforceApply { get; init; }

        /// <summary>
        /// The requested change to reinforce_hour that will take effect at the time shown by next_reinforce_apply
        /// </summary>
        [JsonProperty("next_reinforce_hour")]
        public int? NextReinforceHour { get; init; }

        /// <summary>
        /// The id of the ACL profile for this citadel
        /// </summary>
        [JsonProperty("profile_id")]
        public required int ProfileId { get; init; }

        /// <summary>
        /// The hour of day that determines the four hour window when the structure will randomly exit its reinforcement periods and become vulnerable to attack against its armor and/or hull.
        /// The structure will become vulnerable at a random time that is +/- 2 hours centered on the value of this property
        /// </summary>
        [JsonProperty("reinforce_hour")]
        public int? ReinforceHour { get; init; }

        /// <summary>
        /// Contains a list of service upgrades, and their state
        /// </summary>
        [JsonProperty("services")]
        public List<StructureService>? Services { get; init; }

        /// <summary>
        /// state string
        /// </summary>
        [JsonProperty("state")]
        public required StructureState State { get; init; }

        /// <summary>
        /// Date at which the structure will move to it’s next state
        /// </summary>
        [JsonProperty("state_timer_end")]
        public DateTime? StateTimerEnd { get; init; }

        /// <summary>
        /// Date at which the structure entered it’s current state
        /// </summary>
        [JsonProperty("state_timer_start")]
        public DateTime? StateTimerStart { get; init; }

        /// <summary>
        /// The solar system the structure is in
        /// </summary>
        [JsonProperty("structure_id")]
        public required long StructureId { get; init; }

        /// <summary>
        /// The solar system the structure is in
        /// </summary>
        [JsonProperty("system_id")]
        public required int SystemId { get; init; }

        /// <summary>
        /// The type id of the structure
        /// </summary>
        [JsonProperty("type_id")]
        public required int TypeId { get; init; }

        /// <summary>
        /// Date at which the structure will unanchor
        /// </summary>
        [JsonProperty("unanchors_at")]
        public DateTime? InanchorsAt {  get; set; }
    }

    public class StructureService
    {
        /// <summary>
        /// name string
        /// </summary>
        [JsonProperty("name")]
        public required string Name { get; init; }

        /// <summary>
        /// state string
        /// </summary>
        [JsonProperty("state")]
        public required ServiceState State { get; init; }
    }
}
