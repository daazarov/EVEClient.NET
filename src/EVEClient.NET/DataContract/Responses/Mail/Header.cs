using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class Header
    {
        /// <summary>
        /// From whom the mail was sent
        /// </summary>
        [JsonPropertyName("from")]
        public int? From { get; init; }

        /// <summary>
        /// is_read boolean
        /// </summary>
        [JsonPropertyName("is_read")]
        public bool? IsRead { get; init; }

        /// <summary>
        /// labels array
        /// </summary>
        [JsonPropertyName("labels")]
        public int[]? Labels { get; init; }

        /// <summary>
        /// mail_id integer
        /// </summary>
        [JsonPropertyName("mail_id")]
        public int? MailId { get; init; }

        /// <summary>
        /// Recipients of the mail
        /// </summary>
        [JsonPropertyName("recipients")]
        public List<Recipient>? Recipients { get; init; }

        /// <summary>
        /// Mail subject
        /// </summary>
        [JsonPropertyName("subject")]
        public string? Subject { get; init; }

        /// <summary>
        /// When the mail was sent
        /// </summary>
        [JsonPropertyName("timestamp")]
        public DateTime? Timestamp { get; init; }
    }
}
