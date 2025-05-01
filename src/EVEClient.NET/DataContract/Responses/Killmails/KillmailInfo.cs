using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class KillmailInfo
    {
        /// <summary>
        /// attackers array
        /// </summary>
        [JsonPropertyName("attackers")]
        public required List<Attacker> Attackers { get; init; }

        /// <summary>
        /// ID of the killmail
        /// </summary>
        [JsonPropertyName("killmail_id")]
        public required int KillmailId { get; init; }

        /// <summary>
        /// Time that the victim was killed and the killmail generated
        /// </summary>
        [JsonPropertyName("killmail_time")]
        public required DateTime KillmailTime { get; init; }

        /// <summary>
        /// Moon if the kill took place at one
        /// </summary>
        [JsonPropertyName("moon_id")]
        public int? MoonId { get; init; }

        /// <summary>
        /// Solar system that the kill took place in
        /// </summary>
        [JsonPropertyName("solar_system_id")]
        public required int SolarSystemId { get; init; }

        /// <summary>
        /// victim info
        /// </summary>
        [JsonPropertyName("victim")]
        public required Victim Victim { get; init; }

        /// <summary>
        /// War if the killmail is generated in relation to an official war
        /// </summary>
        [JsonPropertyName("war_id")]
        public int? WarId { get; init; }
    }

    
}
