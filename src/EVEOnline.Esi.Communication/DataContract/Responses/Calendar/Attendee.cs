using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace EVEOnline.Esi.Communication.DataContract
{
    public class Attendee
    {
        /// <summary>
        /// character_id integer
        /// </summary>
        [JsonProperty("character_id")]
        public int CharacterId { get; set; }

        /// <summary>
        /// event_response string
        /// </summary>
        [JsonProperty("event_response")]
        [JsonConverter(typeof(StringEnumConverter))]
        public CalendarEventResponse EventResponse { get; set; }
    }
}
