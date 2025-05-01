using System;
using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class Observer
    {
        /// <summary>
        /// last_updated string
        /// </summary>
        [JsonPropertyName("last_updated")]
        public required DateTime LastUpdated { get; init; }

        /// <summary>
        /// The entity that was observing the asteroid field when it was mined.
        /// </summary>
        [JsonPropertyName("observer_id")]
        public required long ObserverId { get; init; }

        /// <summary>
        /// The category of the observing entity
        /// </summary>
        [JsonPropertyName("observer_type")]
        public required string ObserverType { get; init; }
    }
}
