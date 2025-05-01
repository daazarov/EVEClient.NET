using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class CharacterMedal
    {
        /// <summary>
        /// corporation_id integer
        /// </summary>
        [JsonPropertyName("corporation_id")]
        public required int CorporationId { get; init; }

        /// <summary>
        /// date string
        /// </summary>
        [JsonPropertyName("date")]
        public required DateTime Date { get; init; }

        /// <summary>
        /// description string
        /// </summary>
        [JsonPropertyName("description")]
        public required string Description { get; init; }

        /// <summary>
        /// graphics array
        /// </summary>
        [JsonPropertyName("graphics")]
        public required List<CharacterMedalGraphics> Graphics { get; init; }

        /// <summary>
        /// issuer_id integer
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
        public required Status Status { get; init; }

        /// <summary>
        /// title string
        /// </summary>
        [JsonPropertyName("title")]
        public required string Title { get; init; }

    }

    public class CharacterMedalGraphics
    {
        /// <summary>
        /// color integer
        /// </summary>
        [JsonPropertyName("color")]
        public int? Color { get; init; }

        /// <summary>
        /// graphic string
        /// </summary>
        [JsonPropertyName("graphic")]
        public required string Graphic { get; init; }

        /// <summary>
        /// layer integer
        /// </summary>
        [JsonPropertyName("layer")]
        public required int Layer { get; init; }

        /// <summary>
        /// part integer
        /// </summary>
        [JsonPropertyName("part")]
        public required int Part { get; init; }
    }
}
