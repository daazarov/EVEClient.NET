using System;
using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class CharacterCalendarItem
    {
        /// <summary>
        /// event_date string
        /// </summary>
        [JsonPropertyName("event_date")]
        public DateTime? EventDate { get; init; }

        /// <summary>
        /// event_id integer
        /// </summary>
        [JsonPropertyName("event_id")]
        public int? EventId { get; init; }

        /// <summary>
        /// event_response string
        /// </summary>
        [JsonPropertyName("event_response")]
        public CalendarEventResponse? EventResponse { get; init; }

        /// <summary>
        /// importance integer
        /// </summary>
        [JsonPropertyName("importance")]
        public int? Importance { get; init; }

        /// <summary>
        /// title string
        /// </summary>
        [JsonPropertyName("title")]
        public string? Title { get; init; }
    }
}
