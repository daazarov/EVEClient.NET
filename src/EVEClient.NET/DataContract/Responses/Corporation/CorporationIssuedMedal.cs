using System;
using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class CorporationIssuedMedal
    {
        /// <summary>
        /// ID of the character who was rewarded this medal
        /// </summary>
        [JsonProperty("character_id")]
        public int CharacterId { get; init; }

        /// <summary>
        /// issued_at string
        /// </summary>
        [JsonProperty("issued_at")]
        public DateTime IssuedAt { get; init; }

        /// <summary>
        /// ID of the character who issued the medal
        /// </summary>
        [JsonProperty("issuer_id")]
        public int IssuerId { get; init; }

        /// <summary>
        /// medal_id integer
        /// </summary>
        [JsonProperty("medal_id")]
        public int MedalId { get; init; }

        /// <summary>
        /// reason string
        /// </summary>
        [JsonProperty("reason")]
        public string Reason { get; init; }

        /// <summary>
        /// status string
        /// </summary>
        [JsonProperty("status")]
        public MedalStatus Status { get; init; }
    }
}
