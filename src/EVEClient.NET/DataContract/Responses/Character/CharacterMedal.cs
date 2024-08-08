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
        public int CorporationId { get; init; }

        /// <summary>
        /// date string
        /// </summary>
        [JsonProperty("date")]
        public DateTime Date { get; init; }

        /// <summary>
        /// description string
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; init; }

        /// <summary>
        /// graphics array
        /// </summary>
        [JsonProperty("graphics")]
        public List<CharacterMedalGraphics> Graphics { get; init; }

        /// <summary>
        /// issuer_id integer
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
        public Status Status { get; init; }

        /// <summary>
        /// title string
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; init; }

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
        public string Graphic { get; init; }

        /// <summary>
        /// layer integer
        /// </summary>
        [JsonProperty("layer")]
        public int Layer { get; init; }

        /// <summary>
        /// part integer
        /// </summary>
        [JsonProperty("part")]
        public int Part { get; init; }
    }
}
