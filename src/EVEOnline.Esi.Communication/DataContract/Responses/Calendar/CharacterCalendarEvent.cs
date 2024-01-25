using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace EVEOnline.Esi.Communication.DataContract
{
    public class CharacterCalendarEvent
    {
        /// <summary>
        /// date string
        /// </summary>
        [JsonProperty("date")]
        public DateTime Date { get; set; }

        /// <summary>
        /// Length in minutes
        /// </summary>
        [JsonProperty("duration")]
        public int Duration { get; set; }

        /// <summary>
        /// event_id integer
        /// </summary>
        [JsonProperty("event_id")]
        public int EventId { get; set; }

        /// <summary>
        /// importance integer
        /// </summary>
        [JsonProperty("importance")]
        public int Importance { get; set; }

        /// <summary>
        /// owner_id integer
        /// </summary>
        [JsonProperty("owner_id")]
        public int OwnerId { get; set; }

        /// <summary>
        /// owner_name string
        /// </summary>
        [JsonProperty("owner_name")]
        public string OwnerName { get; set; }

        /// <summary>
        /// owner_type string
        /// </summary>
        [JsonProperty("owner_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public OwnerType OwnerType { get; set; }

        /// <summary>
        /// response string
        /// </summary>
        [JsonProperty("response")]
        public string Response { get; set; }

        /// <summary>
        /// text string
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; set; }

        /// <summary>
        /// title string
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }
    }
}
