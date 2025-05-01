using System.Text.Json.Serialization;
using System;

namespace EVEClient.NET.DataContract
{
    public class CharacterPublicInformation
    {
        /// <summary>
        /// The character’s alliance ID
        /// </summary>
        [JsonPropertyName("alliance_id")]
        public int? AlianceId { get; init; }

        /// <summary>
        /// Creation date of the character
        /// </summary>
        [JsonPropertyName("birthday")]
        public required DateTime Birthdate { get; init; }

        /// <summary>
        /// bloodline_id integer
        /// </summary>
        [JsonPropertyName("bloodline_id")]
        public required int Bloodline { get; init; }

        /// <summary>
        /// The character’s corporation ID
        /// </summary>
        [JsonPropertyName("corporation_id")]
        public required int CorporationId { get; init; }

        /// <summary>
        /// description string
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; init; }

        /// <summary>
        /// ID of the faction the character is fighting for, if the character is enlisted in Factional Warfare
        /// </summary>
        [JsonPropertyName("faction_id")]
        public int? FactionId { get; init; }

        /// <summary>
        /// The character’s gender
        /// </summary>
        [JsonPropertyName("gender")]
        public required Gender Gender { get; init; }

        /// <summary>
        /// The character's name
        /// </summary>
        [JsonPropertyName("name")]
        public required string Name { get; init; }

        /// <summary>
        /// race_id integer
        /// </summary>
        [JsonPropertyName("race_id")]
        public required int RaceId { get; init; }

        /// <summary>
        /// security_status number
        /// </summary>
        [JsonPropertyName("security_status")]
        public float? SecurityStatus { get; init; }

        /// <summary>
        /// The individual title of the character
        /// </summary>
        [JsonPropertyName("title")]
        public string? Title { get; init; }
    }
}
