﻿using Newtonsoft.Json;

namespace EVEOnline.ESI.Communication.DataContract
{
    public class Killmail
    {
        /// <summary>
        /// A hash of this killmail
        /// </summary>
        [JsonProperty("killmail_hash")]
        public string Hash { get; set; }

        /// <summary>
        /// ID of this killmail
        /// </summary>
        [JsonProperty("killmail_id")]
        public int Id { get; set; }
    }
}
