using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace EVEOnline.Esi.Communication.DataContract
{
    public class CharacterMedal
    {
        /// <summary>
        /// corporation_id integer
        /// </summary>
        [JsonProperty("corporation_id")]
        public int CorporationId { get; set; }

        /// <summary>
        /// date string
        /// </summary>
        [JsonProperty("date")]
        public DateTime Date { get; set; }

        /// <summary>
        /// description string
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// graphics array
        /// </summary>
        [JsonProperty("graphics")]
        public List<CharacterMedalGraphics> Graphics { get; set; }

        /// <summary>
        /// issuer_id integer
        /// </summary>
        [JsonProperty("issuer_id")]
        public int IssuerId { get; set; }

        /// <summary>
        /// medal_id integer
        /// </summary>
        [JsonProperty("medal_id")]
        public int MedalId { get; set; }

        /// <summary>
        /// reason string
        /// </summary>
        [JsonProperty("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// status string
        /// </summary>
        [JsonProperty("status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public Status Status { get; set; }

        /// <summary>
        /// title string
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

    }

    public class CharacterMedalGraphics
    {
        /// <summary>
        /// color integer
        /// </summary>
        [JsonProperty("color")]
        public int? Color { get; set; }

        /// <summary>
        /// graphic string
        /// </summary>
        [JsonProperty("graphic")]
        public string Graphic { get; set; }

        /// <summary>
        /// layer integer
        /// </summary>
        [JsonProperty("layer")]
        public int Layer { get; set; }

        /// <summary>
        /// part integer
        /// </summary>
        [JsonProperty("part")]
        public int Part {  get; set; }
    }
}
