using System;
using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class CorporationInfo
    {
        /// <summary>
        /// ID of the alliance that corporation is a member of, if any
        /// </summary>
        [JsonProperty("alliance_id")]
        public int? AllianceId { get; init; }

        /// <summary>
        /// ceo_id integer
        /// </summary>
        [JsonProperty("ceo_id")]
        public int CeoId { get; init; }

        /// <summary>
        /// creator_id integer
        /// </summary>
        [JsonProperty("creator_id")]
        public int CreatorId { get; init; }

        /// <summary>
        /// date_founded string
        /// </summary>
        [JsonProperty("date_founded")]
        public DateTime? DateFounded { get; init; }

        /// <summary>
        /// description string
        /// </summary>
        [JsonProperty("description")]
        public string? Description { get; init; }

        /// <summary>
        /// faction_id integer
        /// </summary>
        [JsonProperty("faction_id")]
        public int? FactionId { get; init; }

        /// <summary>
        /// home_station_id integer
        /// </summary>
        [JsonProperty("home_station_id")]
        public int? HomeStationId { get; init; }

        /// <summary>
        /// member_count integer
        /// </summary>
        [JsonProperty("member_count")]
        public int MemberCount { get; init; }

        /// <summary>
        /// the full name of the corporation
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; init; }

        /// <summary>
        /// shares integer
        /// </summary>
        [JsonProperty("shares")]
        public long? Shares { get; init; }

        /// <summary>
        /// tax_rate number
        /// </summary>
        [JsonProperty("tax_rate")]
        public float TaxRate { get; init; }

        /// <summary>
        /// the short name of the corporation
        /// </summary>
        [JsonProperty("ticker")]
        public string Ticker { get; init; }

        /// <summary>
        /// url string
        /// </summary>
        [JsonProperty("url")]
        public string? Url { get; init; }

        /// <summary>
        /// war_eligible boolean
        /// </summary>
        [JsonProperty("war_eligible")]
        public bool? WarEligible { get; init; }
    }
}
