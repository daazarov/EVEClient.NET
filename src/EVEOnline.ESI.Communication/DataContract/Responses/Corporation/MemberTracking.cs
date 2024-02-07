using System;
using Newtonsoft.Json;

namespace EVEOnline.ESI.Communication.DataContract
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
        public int CharacterId { get; set; }

        /// <summary>
        /// location_id integer
        /// </summary>
        [JsonProperty("location_id")]
        public long? LocationId { get; set; }

        /// <summary>
        /// logoff_date string
        /// </summary>
        [JsonProperty("logoff_date")]
        public DateTime? LogoffDate { get; set; }

        /// <summary>
        /// logon_date string
        /// </summary>
        [JsonProperty("logon_date")]
        public DateTime? LogonDate { get; set; }

        /// <summary>
        /// ship_type_id integer
        /// </summary>
        [JsonProperty("ship_type_id")]
        public int? ShipTypeId { get; set; }

        /// <summary>
        /// start_date string
        /// </summary>
        [JsonProperty("start_date")]
        public DateTime? StartDate { get; set; }
    }
}
