using System;
using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class CharacterCalendarItem
    {
        /// <summary>
        /// event_date string
        /// </summary>
        [JsonProperty("event_date")]
        public DateTime? EventDate { get; init; }

        /// <summary>
        /// event_id integer
        /// </summary>
        [JsonProperty("event_id")]
        public int? EventId { get; init; }

        /// <summary>
        /// event_response string
        /// </summary>
        [JsonProperty("event_response")]
        public CalendarEventResponse? EventResponse { get; init; }

        /// <summary>
        /// importance integer
        /// </summary>
        [JsonProperty("importance")]
        public int? Importance { get; init; }

        /// <summary>
        /// title string
        /// </summary>
        [JsonProperty("title")]
        public string? Title { get; init; }
    }
}
