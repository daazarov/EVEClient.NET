using System;
using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class CorporationIssuedMedal
    {
        /// <summary>
        /// ID of the character who was rewarded this medal
        /// </summary>
        [JsonPropertyName("character_id")]
        public required int CharacterId { get; init; }

        /// <summary>
        /// issued_at string
        /// </summary>
        [JsonPropertyName("issued_at")]
        public required DateTime IssuedAt { get; init; }

        /// <summary>
        /// ID of the character who issued the medal
        /// </summary>
        [JsonPropertyName("issuer_id")]
        public required int IssuerId { get; init; }

        /// <summary>
        /// medal_id integer
        /// </summary>
        [JsonPropertyName("medal_id")]
        public required int MedalId { get; init; }

        /// <summary>
        /// reason string
        /// </summary>
        [JsonPropertyName("reason")]
        public required string Reason { get; init; }

        /// <summary>
        /// status string
        /// </summary>
        [JsonPropertyName("status")]
        public required MedalStatus Status { get; init; }
    }
}
