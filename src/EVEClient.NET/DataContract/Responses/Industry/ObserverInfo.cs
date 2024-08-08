using System;
using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class ObserverInfo
    {
        /// <summary>
        /// The character that did the mining
        /// </summary>
        [JsonProperty("character_id")]
        public int CharacterId { get; init; }

        /// <summary>
        /// last_updated string
        /// </summary>
        [JsonProperty("last_updated")]
        public DateTime LastUpdated { get; init; }

        /// <summary>
        /// quantity integer
        /// </summary>
        [JsonProperty("quantity")]
        public long Quantity { get; init; }

        /// <summary>
        /// The corporation id of the character at the time data was recorded.
        /// </summary>
        [JsonProperty("recorded_corporation_id")]
        public int RecordedCorporationId { get; init; }

        /// <summary>
        /// type_id integer
        /// </summary>
        [JsonProperty("type_id")]
        public int TypeId { get; init; }
    }
}
