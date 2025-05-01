using System;
using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class FleetMember
    {
        /// <summary>
        /// character_id integer
        /// </summary>
        [JsonPropertyName("character_id")]
        public required int CharacterId { get; init; }

        /// <summary>
        /// join_time string
        /// </summary>
        [JsonPropertyName("join_time")]
        public required DateTime JoinTime { get; init; }

        /// <summary>
        /// Member’s role in fleet
        /// </summary>
        [JsonPropertyName("role")]
        public required FleetRole Role { get; init; }

        /// <summary>
        /// Localized role names
        /// </summary>
        [JsonPropertyName("role_name")]
        public required string RoleName { get; init; }

        /// <summary>
        /// ship_type_id integer
        /// </summary>
        [JsonPropertyName("ship_type_id")]
        public required int ShipTypeId { get; init; }

        /// <summary>
        /// Solar system the member is located in
        /// </summary>
        [JsonPropertyName("solar_system_id")]
        public required int SolarSystemId { get; init; }

        /// <summary>
        /// ID of the squad the member is in. If not applicable, will be set to -1
        /// </summary>
        [JsonPropertyName("squad_id")]
        public required long SquadId { get; init; }

        /// <summary>
        /// Station in which the member is docked in, if applicable
        /// </summary>
        [JsonPropertyName("station_id")]
        public long? StationId { get; init; }

        /// <summary>
        /// Whether the member take fleet warps
        /// </summary>
        [JsonPropertyName("takes_fleet_warp")]
        public required bool TakesFleetWarp { get; init; }

        /// <summary>
        /// ID of the wing the member is in. If not applicable, will be set to -1
        /// </summary>
        [JsonPropertyName("wing_id")]
        public required long WingId { get; init; }
    }
}
