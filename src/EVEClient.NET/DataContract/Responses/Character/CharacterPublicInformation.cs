using Newtonsoft.Json;
using System;

namespace EVEClient.NET.DataContract
{
    public class CharacterPublicInformation
    {
        /// <summary>
        /// The character’s alliance ID
        /// </summary>
        [JsonProperty("alliance_id")]
        public int? AlianceId { get; init; }

        /// <summary>
        /// Creation date of the character
        /// </summary>
        [JsonProperty("birthday")]
        public DateTime Birthdate { get; init; }

        /// <summary>
        /// bloodline_id integer
        /// </summary>
        [JsonProperty("bloodline_id")]
        public int Bloodline { get; init; }

        /// <summary>
        /// The character’s corporation ID
        /// </summary>
        [JsonProperty("corporation_id")]
        public int CorporationId { get; init; }

        /// <summary>
        /// description string
        /// </summary>
        [JsonProperty("description")]
        public string? Description { get; init; }

        /// <summary>
        /// ID of the faction the character is fighting for, if the character is enlisted in Factional Warfare
        /// </summary>
        [JsonProperty("faction_id")]
        public int? FactionId { get; init; }

        /// <summary>
        /// The character’s gender
        /// </summary>
        [JsonProperty("gender")]
        public Gender Gender { get; init; }

        /// <summary>
        /// The character's name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; init; }

        /// <summary>
        /// race_id integer
        /// </summary>
        [JsonProperty("race_id")]
        public int RaceId { get; init; }

        /// <summary>
        /// security_status number
        /// </summary>
        [JsonProperty("security_status")]
        public float? SecurityStatus { get; init; }

        /// <summary>
        /// The individual title of the character
        /// </summary>
        [JsonProperty("title")]
        public string? Title { get; init; }
    }
}
