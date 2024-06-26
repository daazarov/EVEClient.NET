﻿using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class SolarSystemSovereignty
    {
        /// <summary>
        /// alliance_id integer
        /// </summary>
        [JsonProperty("alliance_id")]
        public int? AllianceId {  get; set; }

        /// <summary>
        /// corporation_id integer
        /// </summary>
        [JsonProperty("corporation_id")]
        public int? CorporationId { get; set; }

        /// <summary>
        /// faction_id integer
        /// </summary>
        [JsonProperty("faction_id")]
        public int? FactionId { get; set; }

        /// <summary>
        /// system_id integer
        /// </summary>
        [JsonProperty("system_id")]
        public int SystemId { get; set; }
    }
}
