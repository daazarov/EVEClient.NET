using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class Attendee
    {
        /// <summary>
        /// character_id integer
        /// </summary>
        [JsonPropertyName("character_id")]
        public int? CharacterId { get; init; }

        /// <summary>
        /// event_response string
        /// </summary>
        [JsonPropertyName("event_response")]
        public CalendarEventResponse? EventResponse { get; init; }
    }
}
