using System;
using Newtonsoft.Json;

namespace EVEOnline.Esi.Communication.DataContract
{
    public class CorporationInfo
    {
        /// <summary>
        /// ID of the alliance that corporation is a member of, if any
        /// </summary>
        [JsonProperty("alliance_id")]
        public int? AllianceId {  get; set; }

        /// <summary>
        /// ceo_id integer
        /// </summary>
        [JsonProperty("ceo_id")]
        public int CeoId { get; set; }

        /// <summary>
        /// creator_id integer
        /// </summary>
        [JsonProperty("creator_id")]
        public int CreatorId { get; set; }

        /// <summary>
        /// date_founded string
        /// </summary>
        [JsonProperty("date_founded")]
        public DateTime? DateFounded { get; set; }

        /// <summary>
        /// description string
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// faction_id integer
        /// </summary>
        [JsonProperty("faction_id")]
        public int? FactionId { get; set; }

        /// <summary>
        /// home_station_id integer
        /// </summary>
        [JsonProperty("home_station_id")]
        public int? HomeStationId { get; set; }

        /// <summary>
        /// member_count integer
        /// </summary>
        [JsonProperty("member_count")]
        public int MemberCount { get; set; }

        /// <summary>
        /// the full name of the corporation
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// shares integer
        /// </summary>
        [JsonProperty("shares")]
        public long? Shares { get; set; }

        /// <summary>
        /// tax_rate number
        /// </summary>
        [JsonProperty("tax_rate")]
        public float TaxRate { get; set; }

        /// <summary>
        /// the short name of the corporation
        /// </summary>
        [JsonProperty("ticker")]
        public string Ticker { get; set; }

        /// <summary>
        /// url string
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// war_eligible boolean
        /// </summary>
        [JsonProperty("war_eligible")]
        public bool? WarEligible { get; set; }
    }
}
