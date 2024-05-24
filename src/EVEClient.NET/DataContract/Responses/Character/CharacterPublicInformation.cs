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
        public int? AlianceId { get; set; }

        /// <summary>
        /// Creation date of the character
        /// </summary>
        [JsonProperty("birthday")]
        public DateTime Birthdate { get; set; }

        /// <summary>
        /// bloodline_id integer
        /// </summary>
        [JsonProperty("bloodline_id")]
        public int Bloodline { get; set; }

        /// <summary>
        /// The character’s corporation ID
        /// </summary>
        [JsonProperty("corporation_id")]
        public int? CorporationId { get; set; }

        /// <summary>
        /// description string
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// The character’s gender
        /// </summary>
        [JsonProperty("gender")]
        public Gender Gender { get; set; }

        /// <summary>
        /// The character's name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// race_id integer
        /// </summary>
        [JsonProperty("race_id")]
        public int RaceId { get; set; }

        /// <summary>
        /// security_status number
        /// </summary>
        [JsonProperty("security_status")]
        public float SecurityStatus { get; set; }

        /// <summary>
        /// The individual title of the character
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }
    }
}
