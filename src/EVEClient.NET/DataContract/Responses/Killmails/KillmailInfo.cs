using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class KillmailInfo
    {
        /// <summary>
        /// attackers array
        /// </summary>
        [JsonProperty("attackers")]
        public List<Attacker> Attackers { get; init; }

        /// <summary>
        /// ID of the killmail
        /// </summary>
        [JsonProperty("killmail_id")]
        public int KillmailId { get; init; }

        /// <summary>
        /// Time that the victim was killed and the killmail generated
        /// </summary>
        [JsonProperty("killmail_time")]
        public DateTime KillmailTime { get; init; }

        /// <summary>
        /// Moon if the kill took place at one
        /// </summary>
        [JsonProperty("moon_id")]
        public int? MoonId { get; init; }

        /// <summary>
        /// Solar system that the kill took place in
        /// </summary>
        [JsonProperty("solar_system_id")]
        public int SolarSystemId { get; init; }

        /// <summary>
        /// victim info
        /// </summary>
        [JsonProperty("victim")]
        public Victim Victim { get; init; }

        /// <summary>
        /// War if the killmail is generated in relation to an official war
        /// </summary>
        [JsonProperty("war_id")]
        public int? WarId { get; init; }
    }

    
}
