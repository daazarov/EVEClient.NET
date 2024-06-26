﻿using System;
using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class FleetMember
    {
        /// <summary>
        /// character_id integer
        /// </summary>
        [JsonProperty("character_id")]
        public int CharacterId {  get; set; }

        /// <summary>
        /// join_time string
        /// </summary>
        [JsonProperty("join_time")]
        public DateTime JoinTime { get; set; }

        /// <summary>
        /// Member’s role in fleet
        /// </summary>
        [JsonProperty("role")]
        public FleetRole Role { get; set; }

        /// <summary>
        /// Localized role names
        /// </summary>
        [JsonProperty("role_name")]
        public string RoleName { get; set; }

        /// <summary>
        /// ship_type_id integer
        /// </summary>
        [JsonProperty("ship_type_id")]
        public int ShipTypeId { get; set; }

        /// <summary>
        /// Solar system the member is located in
        /// </summary>
        [JsonProperty("solar_system_id")]
        public int SolarSystemId { get; set; }

        /// <summary>
        /// ID of the squad the member is in. If not applicable, will be set to -1
        /// </summary>
        [JsonProperty("squad_id")]
        public long SquadId { get; set; }

        /// <summary>
        /// Station in which the member is docked in, if applicable
        /// </summary>
        [JsonProperty("station_id")]
        public long? StationId { get; set; }

        /// <summary>
        /// Whether the member take fleet warps
        /// </summary>
        [JsonProperty("takes_fleet_warp")]
        public bool TakesFleetWarp { get; set; }

        /// <summary>
        /// ID of the wing the member is in. If not applicable, will be set to -1
        /// </summary>
        [JsonProperty("wing_id")]
        public long WingId { get; set; }
    }
}
