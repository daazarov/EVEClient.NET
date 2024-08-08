using System;
using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class CharacterCorporationHistory
    {
        /// <summary>
        /// corporation_id integer
        /// </summary>
        [JsonProperty("corporation_id")]
        public int CorporationId { get; init; }

        /// <summary>
        /// True if the corporation has been deleted
        /// </summary>
        [JsonProperty("is_deleted")]
        public bool? IsDeleted { get; init; }

        /// <summary>
        /// An incrementing ID that can be used to canonically establish order of records in cases where dates may be ambiguous
        /// </summary>
        [JsonProperty("record_id")]
        public int RecordId { get; init; }

        /// <summary>
        /// start_date string
        /// </summary>
        [JsonProperty("start_date")]
        public DateTime StartDate { get; init; }
    }
}
