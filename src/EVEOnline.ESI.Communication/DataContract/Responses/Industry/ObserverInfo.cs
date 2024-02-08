using System;
using Newtonsoft.Json;

namespace EVEOnline.ESI.Communication.DataContract
{
    public class ObserverInfo
    {
        /// <summary>
        /// The character that did the mining
        /// </summary>
        [JsonProperty("character_id")]
        public int CharacterId { get; set; }

        /// <summary>
        /// last_updated string
        /// </summary>
        [JsonProperty("last_updated")]
        public DateTime LastUpdated { get; set; }

        /// <summary>
        /// quantity integer
        /// </summary>
        [JsonProperty("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// The corporation id of the character at the time data was recorded.
        /// </summary>
        [JsonProperty("recorded_corporation_id")]
        public int RecordedCorporationId { get; set; }

        /// <summary>
        /// type_id integer
        /// </summary>
        [JsonProperty("type_id")]
        public int TypeId { get; set; }
    }
}
