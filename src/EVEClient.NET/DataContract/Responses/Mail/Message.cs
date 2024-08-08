using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class Message
    {
        /// <summary>
        /// Mail’s body
        /// </summary>
        [JsonProperty("body")]
        public string? Body { get; init; }

        /// <summary>
        /// From whom the mail was sent
        /// </summary>
        [JsonProperty("from")]
        public int? From { get; init; }

        /// <summary>
        /// Labels attached to the mail
        /// </summary>
        [JsonProperty("labels")]
        public int[]? Labels { get; init; }

        /// <summary>
        /// Whether the mail is flagged as read
        /// </summary>
        [JsonProperty("read")]
        public bool? Read { get; init; }

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
