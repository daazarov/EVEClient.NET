﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace EVEOnline.Esi.Communication.DataContract
{
    public class CharacterStanding
    {
        /// <summary>
        /// from_id integer
        /// </summary>
        [JsonProperty("from_id")]
        public int FromId { get; set; }

        /// <summary>
        /// from_type string
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public StandingType StandingType { get; set; }

        /// <summary>
        /// standing number
        /// </summary>
        [JsonProperty("standing")]
        public float Standing { get; set; }
    }
}
