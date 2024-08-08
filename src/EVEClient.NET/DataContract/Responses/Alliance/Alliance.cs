using System;
using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class Alliance
    {
        /// <summary>
        /// ID of the corporation that created the alliance
        /// </summary>
        [JsonProperty("creator_corporation_id")]
        public int CreatorCorporationId { get; init; }

        /// <summary>
        /// ID of the character that created the alliance
        /// </summary>
        [JsonProperty("creator_id")]
        public int CreatorId { get; init; }

        /// <summary>
        /// date_founded string
        /// </summary>
        [JsonProperty("date_founded")]
        public DateTime DateFounded { get; init; }

        /// <summary>
        /// the executor corporation ID, if this alliance is not closed
        /// </summary>
        [JsonProperty("executor_corporation_id")]
        public int? ExecutorCorporationId { get; init; }

        /// <summary>
        /// Faction ID this alliance is fighting for, if this alliance is enlisted in factional warfare
        /// </summary>
        [JsonProperty("faction_id")]
        public int? FactionId { get; init; }

        /// <summary>
        /// the full name of the alliance
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; init; }

        /// <summary>
        /// the short name of the alliance
        /// </summary>
        [JsonProperty("ticker")]
        public string Ticker { get; init; }
    }
}
