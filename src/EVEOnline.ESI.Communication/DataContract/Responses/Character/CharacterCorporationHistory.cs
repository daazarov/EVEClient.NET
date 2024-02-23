using System;
using Newtonsoft.Json;

namespace EVEOnline.ESI.Communication.DataContract
{
    public class CharacterCorporationHistory
    {
        /// <summary>
        /// corporation_id integer
        /// </summary>
        [JsonProperty("corporation_id")]
        public int CorporationId { get; set; }

        /// <summary>
        /// True if the corporation has been deleted
        /// </summary>
        [JsonProperty("is_deleted")]
        public bool IsDeleted { get; set; }

        /// <summary>
        /// An incrementing ID that can be used to canonically establish order of records in cases where dates may be ambiguous
        /// </summary>
        [JsonProperty("record_id")]
        public int RecordId { get; set; }

        /// <summary>
        /// start_date string
        /// </summary>
        [JsonProperty("start_date")]
        public DateTime StartDate { get; set; }
    }
}
