using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace EVEOnline.ESI.Communication.DataContract
{
    public class Message
    {
        /// <summary>
        /// Mail’s body
        /// </summary>
        [JsonProperty("body")]
        public string Body { get; set; }

        /// <summary>
        /// From whom the mail was sent
        /// </summary>
        [JsonProperty("from")]
        public int? From { get; set; }

        /// <summary>
        /// Labels attached to the mail
        /// </summary>
        [JsonProperty("labels")]
        public int[] Labels { get; set; }

        /// <summary>
        /// Whether the mail is flagged as read
        /// </summary>
        [JsonProperty("read")]
        public bool? Read { get; set; }

        /// <summary>
        /// Recipients of the mail
        /// </summary>
        [JsonProperty("recipients")]
        public List<Recipient> Recipients { get; set; }

        /// <summary>
        /// Mail subject
        /// </summary>
        [JsonProperty("subject")]
        public string Subject { get; set; }

        /// <summary>
        /// When the mail was sent
        /// </summary>
        [JsonProperty("timestamp")]
        public DateTime? Timestamp { get; set; }
    }
}
