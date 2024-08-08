using System;
using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class CharacterCalendarEvent
    {
        /// <summary>
        /// date string
        /// </summary>
        [JsonProperty("date")]
        public DateTime Date { get; init; }

        /// <summary>
        /// Length in minutes
        /// </summary>
        [JsonProperty("duration")]
        public int Duration { get; init; }

        /// <summary>
        /// event_id integer
        /// </summary>
        [JsonProperty("event_id")]
        public int EventId { get; init; }

        /// <summary>
        /// importance integer
        /// </summary>
        [JsonProperty("importance")]
        public int Importance { get; init; }

        /// <summary>
        /// owner_id integer
        /// </summary>
        [JsonProperty("owner_id")]
        public int OwnerId { get; init; }

        /// <summary>
        /// owner_name string
        /// </summary>
        [JsonProperty("owner_name")]
        public string OwnerName { get; init; }

        /// <summary>
        /// owner_type string
        /// </summary>
        [JsonProperty("owner_type")]
        public OwnerType OwnerType { get; init; }

        /// <summary>
        /// response string
        /// </summary>
        [JsonProperty("response")]
        public string Response { get; init; }

        /// <summary>
        /// text string
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; init; }

        /// <summary>
        /// title string
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; init; }
    }
}
