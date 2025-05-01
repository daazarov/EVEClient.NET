using System;
using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class CharacterContactNotification
    {
        /// <summary>
        /// message string
        /// </summary>
        [JsonPropertyName("message")]
        public required string Message { get; init; }

        /// <summary>
        /// notification_id integer
        /// </summary>
        [JsonPropertyName("notification_id")]
        public required int NotificationId { get; init; }

        /// <summary>
        /// send_date string
        /// </summary>
        [JsonPropertyName("send_date")]
        public required DateTime SendDate { get; init; }

        /// <summary>
        /// sender_character_id integer
        /// </summary>
        [JsonPropertyName("sender_character_id")]
        public required int SenderCharacterId { get; init; }

        /// <summary>
        /// A number representing the standing level the receiver has been added at by the sender.
        /// The standing levels are as follows: -10 -> Terrible | -5 -> Bad | 0 -> Neutral | 5 -> Good | 10 -> Excellent
        /// </summary>
        [JsonPropertyName("standing_level")]
        public required float StandingLevel { get; init; }
    }
}
