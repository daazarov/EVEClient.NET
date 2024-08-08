using System;
using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class MemberTracking
    {
        /// <summary>
        /// base_id integer
        /// </summary>
        [JsonProperty("base_id")]
        public int? BaseId {  get; set; }

        /// <summary>
        /// character_id integer
        /// </summary>
        [JsonProperty("character_id")]
        public required int CharacterId { get; init; }

        /// <summary>
        /// location_id integer
        /// </summary>
        [JsonProperty("location_id")]
        public long? LocationId { get; init; }

        /// <summary>
        /// logoff_date string
        /// </summary>
        [JsonProperty("logoff_date")]
        public DateTime? LogoffDate { get; init; }

        /// <summary>
        /// logon_date string
        /// </summary>
        [JsonProperty("logon_date")]
        public DateTime? LogonDate { get; init; }

        /// <summary>
        /// ship_type_id integer
        /// </summary>
        [JsonProperty("ship_type_id")]
        public int? ShipTypeId { get; init; }

        /// <summary>
        /// start_date string
        /// </summary>
        [JsonProperty("start_date")]
        public DateTime? StartDate { get; init; }
    }
}
