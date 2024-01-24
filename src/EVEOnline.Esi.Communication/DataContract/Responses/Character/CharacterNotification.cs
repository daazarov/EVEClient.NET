using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace EVEOnline.Esi.Communication.DataContract
{
    public class CharacterNotification
    {
        /// <summary>
        /// is_read boolean
        /// </summary>
        [JsonProperty("is_read")]
        public bool? IsRead { get; set; }

        /// <summary>
        /// notification_id integer
        /// </summary>
        [JsonProperty("notification_id")]
        public long NotificationId { get; set; }

        /// <summary>
        /// sender_id integer
        /// </summary>
        [JsonProperty("sender_id")]
        public int SenderId { get; set; }

        /// <summary>
        /// sender_type string
        /// </summary>
        [JsonProperty("sender_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public SenderType SenderType { get; set; }

        /// <summary>
        /// text string
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; set; }

        /// <summary>
        /// timestamp string
        /// </summary>
        [JsonProperty("timestamp")]
        public DateTime Timestamp { get; set; }

        /// <summary>
        /// type string
        /// </summary>
        [JsonProperty("type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NotificationType Type { get; set; }
    }
}
