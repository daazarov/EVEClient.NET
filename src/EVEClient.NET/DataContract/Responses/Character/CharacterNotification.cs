using System;
using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class CharacterNotification
    {
        /// <summary>
        /// is_read boolean
        /// </summary>
        [JsonPropertyName("is_read")]
        public bool? IsRead { get; init; }

        /// <summary>
        /// notification_id integer
        /// </summary>
        [JsonPropertyName("notification_id")]
        public required long NotificationId { get; init; }

        /// <summary>
        /// sender_id integer
        /// </summary>
        [JsonPropertyName("sender_id")]
        public required int SenderId { get; init; }

        /// <summary>
        /// sender_type string
        /// </summary>
        [JsonPropertyName("sender_type")]
        public required SenderType SenderType { get; init; }

        /// <summary>
        /// text string
        /// </summary>
        [JsonPropertyName("text")]
        public string? Text { get; init; }

        /// <summary>
        /// timestamp string
        /// </summary>
        [JsonPropertyName("timestamp")]
        public required DateTime Timestamp { get; init; }

        /// <summary>
        /// type string
        /// </summary>
        [JsonPropertyName("type")]
        public required NotificationType Type { get; init; }
    }
}
