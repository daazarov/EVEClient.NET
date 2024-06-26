﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class CorporationContact
    {
        /// <summary>
        /// contact_id integer
        /// </summary>
        [JsonProperty("contact_id")]
        public int ContactId { get; set; }

        /// <summary>
        /// contact_type string
        /// </summary>
        [JsonProperty("contact_type")]
        public ContactType ContactType { get; set; }

        /// <summary>
        /// Whether this contact is being watched
        /// </summary>
        [JsonProperty("is_watched")]
        public bool? IsWatched { get; set; }


        /// <summary>
        /// Label IDs applied to the contact
        /// </summary>
        [JsonProperty("label_ids")]
        public List<long> LabelIds { get; set; } = new List<long>();

        /// <summary>
        /// Standing of the contact
        /// </summary>
        [JsonProperty("standing")]
        public float Standing { get; set; }
    }
}
