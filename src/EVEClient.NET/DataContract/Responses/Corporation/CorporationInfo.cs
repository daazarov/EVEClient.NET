using System;
using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class CorporationInfo
    {
        /// <summary>
        /// ID of the alliance that corporation is a member of, if any
        /// </summary>
        [JsonPropertyName("alliance_id")]
        public int? AllianceId { get; init; }

        /// <summary>
        /// ceo_id integer
        /// </summary>
        [JsonPropertyName("ceo_id")]
        public required int CeoId { get; init; }

        /// <summary>
        /// creator_id integer
        /// </summary>
        [JsonPropertyName("creator_id")]
        public required int CreatorId { get; init; }

        /// <summary>
        /// date_founded string
        /// </summary>
        [JsonPropertyName("date_founded")]
        public DateTime? DateFounded { get; init; }

        /// <summary>
        /// description string
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; init; }

        /// <summary>
        /// faction_id integer
        /// </summary>
        [JsonPropertyName("faction_id")]
        public int? FactionId { get; init; }

        /// <summary>
        /// home_station_id integer
        /// </summary>
        [JsonPropertyName("home_station_id")]
        public int? HomeStationId { get; init; }

        /// <summary>
        /// member_count integer
        /// </summary>
        [JsonPropertyName("member_count")]
        public required int MemberCount { get; init; }

        /// <summary>
        /// the full name of the corporation
        /// </summary>
        [JsonPropertyName("name")]
        public required string Name { get; init; }

        /// <summary>
        /// shares integer
        /// </summary>
        [JsonPropertyName("shares")]
        public long? Shares { get; init; }

        /// <summary>
        /// tax_rate number
        /// </summary>
        [JsonPropertyName("tax_rate")]
        public required float TaxRate { get; init; }

        /// <summary>
        /// the short name of the corporation
        /// </summary>
        [JsonPropertyName("ticker")]
        public required string Ticker { get; init; }

        /// <summary>
        /// url string
        /// </summary>
        [JsonPropertyName("url")]
        public string? Url { get; init; }

        /// <summary>
        /// war_eligible boolean
        /// </summary>
        [JsonPropertyName("war_eligible")]
        public bool? WarEligible { get; init; }
    }
}
