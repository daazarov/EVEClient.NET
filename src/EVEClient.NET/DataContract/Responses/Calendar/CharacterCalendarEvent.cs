using System;
using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class CharacterCalendarEvent
    {
        /// <summary>
        /// date string
        /// </summary>
        [JsonPropertyName("date")]
        public required DateTime Date { get; init; }

        /// <summary>
        /// Length in minutes
        /// </summary>
        [JsonPropertyName("duration")]
        public required int Duration { get; init; }

        /// <summary>
        /// event_id integer
        /// </summary>
        [JsonPropertyName("event_id")]
        public required int EventId { get; init; }

        /// <summary>
        /// importance integer
        /// </summary>
        [JsonPropertyName("importance")]
        public required int Importance { get; init; }

        /// <summary>
        /// owner_id integer
        /// </summary>
        [JsonPropertyName("owner_id")]
        public required int OwnerId { get; init; }

        /// <summary>
        /// owner_name string
        /// </summary>
        [JsonPropertyName("owner_name")]
        public required string OwnerName { get; init; }

        /// <summary>
        /// owner_type string
        /// </summary>
        [JsonPropertyName("owner_type")]
        public required OwnerType OwnerType { get; init; }

        /// <summary>
        /// response string
        /// </summary>
        [JsonPropertyName("response")]
        public required string Response { get; init; }

        /// <summary>
        /// text string
        /// </summary>
        [JsonPropertyName("text")]
        public required string Text { get; init; }

        /// <summary>
        /// title string
        /// </summary>
        [JsonPropertyName("title")]
        public required string Title { get; init; }
    }
}
