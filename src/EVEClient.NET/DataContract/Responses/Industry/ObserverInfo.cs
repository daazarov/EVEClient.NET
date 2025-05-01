using System;
using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class ObserverInfo
    {
        /// <summary>
        /// The character that did the mining
        /// </summary>
        [JsonPropertyName("character_id")]
        public required int CharacterId { get; init; }

        /// <summary>
        /// last_updated string
        /// </summary>
        [JsonPropertyName("last_updated")]
        public required DateTime LastUpdated { get; init; }

        /// <summary>
        /// quantity integer
        /// </summary>
        [JsonPropertyName("quantity")]
        public required long Quantity { get; init; }

        /// <summary>
        /// The corporation id of the character at the time data was recorded.
        /// </summary>
        [JsonPropertyName("recorded_corporation_id")]
        public required int RecordedCorporationId { get; init; }

        /// <summary>
        /// type_id integer
        /// </summary>
        [JsonPropertyName("type_id")]
        public required int TypeId { get; init; }
    }
}
