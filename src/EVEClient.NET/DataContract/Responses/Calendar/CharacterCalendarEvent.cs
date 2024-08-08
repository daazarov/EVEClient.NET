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
        public required DateTime Date { get; init; }

        /// <summary>
        /// Length in minutes
        /// </summary>
        [JsonProperty("duration")]
        public required int Duration { get; init; }

        /// <summary>
        /// event_id integer
        /// </summary>
        [JsonProperty("event_id")]
        public required int EventId { get; init; }

        /// <summary>
        /// importance integer
        /// </summary>
        [JsonProperty("importance")]
        public required int Importance { get; init; }

        /// <summary>
        /// owner_id integer
        /// </summary>
        [JsonProperty("owner_id")]
        public required int OwnerId { get; init; }

        /// <summary>
        /// owner_name string
        /// </summary>
        [JsonProperty("owner_name")]
        public required string OwnerName { get; init; }

        /// <summary>
        /// owner_type string
        /// </summary>
        [JsonProperty("owner_type")]
        public required OwnerType OwnerType { get; init; }

        /// <summary>
        /// response string
        /// </summary>
        [JsonProperty("response")]
        public required string Response { get; init; }

        /// <summary>
        /// text string
        /// </summary>
        [JsonProperty("text")]
        public required string Text { get; init; }

        /// <summary>
        /// title string
        /// </summary>
        [JsonProperty("title")]
        public required string Title { get; init; }
    }
}
