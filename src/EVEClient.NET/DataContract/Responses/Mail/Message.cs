using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class Message
    {
        /// <summary>
        /// Mail’s body
        /// </summary>
        [JsonPropertyName("body")]
        public string? Body { get; init; }

        /// <summary>
        /// From whom the mail was sent
        /// </summary>
        [JsonPropertyName("from")]
        public int? From { get; init; }

        /// <summary>
        /// Labels attached to the mail
        /// </summary>
        [JsonPropertyName("labels")]
        public int[]? Labels { get; init; }

        /// <summary>
        /// Whether the mail is flagged as read
        /// </summary>
        [JsonPropertyName("read")]
        public bool? Read { get; init; }

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
