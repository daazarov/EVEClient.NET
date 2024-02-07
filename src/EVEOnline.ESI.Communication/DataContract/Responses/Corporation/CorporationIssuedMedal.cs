using System;
using Newtonsoft.Json;

namespace EVEOnline.ESI.Communication.DataContract
{
    public class CorporationIssuedMedal
    {
        /// <summary>
        /// ID of the character who was rewarded this medal
        /// </summary>
        [JsonProperty("character_id")]
        public int character_id {  get; set; }

        /// <summary>
        /// issued_at string
        /// </summary>
        [JsonProperty("issued_at")]
        public DateTime issued_at { get; set; }

        /// <summary>
        /// ID of the character who issued the medal
        /// </summary>
        [JsonProperty("issuer_id")]
        public int issuer_id { get; set; }

        /// <summary>
        /// medal_id integer
        /// </summary>
        [JsonProperty("medal_id")]
        public int medal_id { get; set; }

        /// <summary>
        /// reason string
        /// </summary>
        [JsonProperty("reason")]
        public string reason { get; set; }

        /// <summary>
        /// status string
        /// </summary>
        [JsonProperty("status")]
        public MedalStatus status { get; set; }
    }
}
