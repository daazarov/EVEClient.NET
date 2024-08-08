using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class CharacterMedal
    {
        /// <summary>
        /// corporation_id integer
        /// </summary>
        [JsonProperty("corporation_id")]
        public required int CorporationId { get; init; }

        /// <summary>
        /// date string
        /// </summary>
        [JsonProperty("date")]
        public required DateTime Date { get; init; }

        /// <summary>
        /// description string
        /// </summary>
        [JsonProperty("description")]
        public required string Description { get; init; }

        /// <summary>
        /// graphics array
        /// </summary>
        [JsonProperty("graphics")]
        public required List<CharacterMedalGraphics> Graphics { get; init; }

        /// <summary>
        /// issuer_id integer
        /// </summary>
        [JsonProperty("issuer_id")]
        public required int IssuerId { get; init; }

        /// <summary>
        /// medal_id integer
        /// </summary>
        [JsonProperty("medal_id")]
        public required int MedalId { get; init; }

        /// <summary>
        /// reason string
        /// </summary>
        [JsonProperty("reason")]
        public required string Reason { get; init; }

        /// <summary>
        /// status string
        /// </summary>
        [JsonProperty("status")]
        public required Status Status { get; init; }

        /// <summary>
        /// title string
        /// </summary>
        [JsonProperty("title")]
        public required string Title { get; init; }

    }

    public class CharacterMedalGraphics
    {
        /// <summary>
        /// color integer
        /// </summary>
        [JsonProperty("color")]
        public int? Color { get; init; }

        /// <summary>
        /// graphic string
        /// </summary>
        [JsonProperty("graphic")]
        public required string Graphic { get; init; }

        /// <summary>
        /// layer integer
        /// </summary>
        [JsonProperty("layer")]
        public required int Layer { get; init; }

        /// <summary>
        /// part integer
        /// </summary>
        [JsonProperty("part")]
        public required int Part {  get; set; }
    }
}
