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
        public required long NotificationId { get; init; }

        /// <summary>
        /// sender_id integer
        /// </summary>
        [JsonProperty("sender_id")]
        public required int SenderId { get; init; }

        /// <summary>
        /// sender_type string
        /// </summary>
        [JsonProperty("sender_type")]
        public required SenderType SenderType { get; init; }

        /// <summary>
        /// text string
        /// </summary>
        [JsonProperty("text")]
        public string? Text { get; init; }

        /// <summary>
        /// timestamp string
        /// </summary>
        [JsonProperty("timestamp")]
        public required DateTime Timestamp { get; init; }

        /// <summary>
        /// type string
        /// </summary>
        [JsonProperty("type")]
        public required NotificationType Type { get; init; }
    }
}
