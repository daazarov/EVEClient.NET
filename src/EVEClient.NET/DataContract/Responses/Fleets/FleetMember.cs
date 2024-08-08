using System;
using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class FleetMember
    {
        /// <summary>
        /// character_id integer
        /// </summary>
        [JsonProperty("character_id")]
        public required int CharacterId {  get; set; }

        /// <summary>
        /// join_time string
        /// </summary>
        [JsonProperty("join_time")]
        public required DateTime JoinTime { get; init; }

        /// <summary>
        /// Member’s role in fleet
        /// </summary>
        [JsonProperty("role")]
        public required FleetRole Role { get; init; }

        /// <summary>
        /// Localized role names
        /// </summary>
        [JsonProperty("role_name")]
        public required string RoleName { get; init; }

        /// <summary>
        /// ship_type_id integer
        /// </summary>
        [JsonProperty("ship_type_id")]
        public required int ShipTypeId { get; init; }

        /// <summary>
        /// Solar system the member is located in
        /// </summary>
        [JsonProperty("solar_system_id")]
        public required int SolarSystemId { get; init; }

        /// <summary>
        /// ID of the squad the member is in. If not applicable, will be set to -1
        /// </summary>
        [JsonProperty("squad_id")]
        public required long SquadId { get; init; }

        /// <summary>
        /// Station in which the member is docked in, if applicable
        /// </summary>
        [JsonProperty("station_id")]
        public long? StationId { get; init; }

        /// <summary>
        /// Whether the member take fleet warps
        /// </summary>
        [JsonProperty("takes_fleet_warp")]
        public required bool TakesFleetWarp { get; init; }

        /// <summary>
        /// ID of the wing the member is in. If not applicable, will be set to -1
        /// </summary>
        [JsonProperty("wing_id")]
        public required long WingId { get; init; }
    }
}
