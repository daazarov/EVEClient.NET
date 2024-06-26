﻿using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class Recipient
    {
        /// <summary>
        /// recipient_id integer
        /// </summary>
        [JsonProperty("recipient_id")]
        public int RecipientId { get; set; }

        /// <summary>
        /// recipient_type string
        /// </summary>
        [JsonProperty("recipient_type")]
        public RecipientType RecipientType { get; set; }
    }
}
