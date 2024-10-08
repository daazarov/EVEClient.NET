﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class Header
    {
        /// <summary>
        /// From whom the mail was sent
        /// </summary>
        [JsonProperty("from")]
        public int? From { get; init; }

        /// <summary>
        /// is_read boolean
        /// </summary>
        [JsonProperty("is_read")]
        public bool? IsRead { get; init; }

        /// <summary>
        /// labels array
        /// </summary>
        [JsonProperty("labels")]
        public int[]? Labels { get; init; }

        /// <summary>
        /// mail_id integer
        /// </summary>
        [JsonProperty("mail_id")]
        public int? MailId { get; init; }

        /// <summary>
        /// Recipients of the mail
        /// </summary>
        [JsonProperty("recipients")]
        public List<Recipient>? Recipients { get; init; }

        /// <summary>
        /// Mail subject
        /// </summary>
        [JsonProperty("subject")]
        public string? Subject { get; init; }

        /// <summary>
        /// When the mail was sent
        /// </summary>
        [JsonProperty("timestamp")]
        public DateTime? Timestamp { get; init; }
    }
}
