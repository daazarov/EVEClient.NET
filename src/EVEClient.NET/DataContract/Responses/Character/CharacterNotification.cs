using System;
using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class CharacterNotification
    {
        /// <summary>
        /// is_read boolean
        /// </summary>
        [JsonProperty("is_read")]
        public bool? IsRead { get; init; }

        /// <summary>
        /// notification_id integer
        /// </summary>
        [JsonProperty("notification_id")]
        public long NotificationId { get; init; }

        /// <summary>
        /// sender_id integer
        /// </summary>
        [JsonProperty("sender_id")]
        public int SenderId { get; init; }

        /// <summary>
        /// sender_type string
        /// </summary>
        [JsonProperty("sender_type")]
        public SenderType SenderType { get; init; }

        /// <summary>
        /// text string
        /// </summary>
        [JsonProperty("text")]
        public string? Text { get; init; }

        /// <summary>
        /// timestamp string
        /// </summary>
        [JsonProperty("timestamp")]
        public DateTime Timestamp { get; init; }

        /// <summary>
        /// type string
        /// </summary>
        [JsonProperty("type")]
        public NotificationType Type { get; init; }
    }
}
