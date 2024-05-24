using System;
using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class CharacterContactNotification
    {
        /// <summary>
        /// message string
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; }

        /// <summary>
        /// notification_id integer
        /// </summary>
        [JsonProperty("notification_id")]
        public int NotificationId { get; set; }

        /// <summary>
        /// send_date string
        /// </summary>
        [JsonProperty("send_date")]
        public DateTime SendDate { get; set; }

        /// <summary>
        /// sender_character_id integer
        /// </summary>
        [JsonProperty("sender_character_id")]
        public int SenderCharacterId { get; set; }

        /// <summary>
        /// A number representing the standing level the receiver has been added at by the sender.
        /// The standing levels are as follows: -10 -> Terrible | -5 -> Bad | 0 -> Neutral | 5 -> Good | 10 -> Excellent
        /// </summary>
        [JsonProperty("standing_level")]
        public float StandingLevel { get; set; }
    }
}
