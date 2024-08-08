using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class Attendee
    {
        /// <summary>
        /// character_id integer
        /// </summary>
        [JsonProperty("character_id")]
        public int? CharacterId { get; init; }

        /// <summary>
        /// event_response string
        /// </summary>
        [JsonProperty("event_response")]
        public CalendarEventResponse? EventResponse { get; init; }
    }
}
