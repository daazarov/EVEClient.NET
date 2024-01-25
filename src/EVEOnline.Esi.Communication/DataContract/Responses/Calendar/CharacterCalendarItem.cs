using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace EVEOnline.Esi.Communication.DataContract
{
    public class CharacterCalendarItem
    {
        /// <summary>
        /// event_date string
        /// </summary>
        [JsonProperty("event_date")]
        public DateTime EventDate { get; set; }

        /// <summary>
        /// event_id integer
        /// </summary>
        [JsonProperty("event_id")]
        public int EventId { get; set; }

        /// <summary>
        /// event_response string
        /// </summary>
        [JsonProperty("event_response")]
        [JsonConverter(typeof(StringEnumConverter))]
        public CalendarEventResponse EventResponse { get; set; }

        /// <summary>
        /// importance integer
        /// </summary>
        [JsonProperty("importance")]
        public int Importance { get; set; }

        /// <summary>
        /// title string
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }
    }
}
