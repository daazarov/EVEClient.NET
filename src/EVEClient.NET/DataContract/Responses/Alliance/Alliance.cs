using System;
using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class Alliance
    {
        /// <summary>
        /// ID of the corporation that created the alliance
        /// </summary>
        [JsonPropertyName("creator_corporation_id")]
        public required int CreatorCorporationId { get; init; }

        /// <summary>
        /// ID of the character that created the alliance
        /// </summary>
        [JsonPropertyName("creator_id")]
        public required int CreatorId { get; init; }

        /// <summary>
        /// date_founded string
        /// </summary>
        [JsonPropertyName("date_founded")]
        public required DateTime DateFounded { get; init; }

        /// <summary>
        /// the executor corporation ID, if this alliance is not closed
        /// </summary>
        [JsonPropertyName("executor_corporation_id")]
        public int? ExecutorCorporationId { get; init; }

        /// <summary>
        /// Faction ID this alliance is fighting for, if this alliance is enlisted in factional warfare
        /// </summary>
        [JsonPropertyName("faction_id")]
        public int? FactionId { get; init; }

        /// <summary>
        /// the full name of the alliance
        /// </summary>
        [JsonPropertyName("name")]
        public required string Name { get; init; }

        /// <summary>
        /// the short name of the alliance
        /// </summary>
        [JsonPropertyName("ticker")]
        public required string Ticker { get; init; }
    }
}
