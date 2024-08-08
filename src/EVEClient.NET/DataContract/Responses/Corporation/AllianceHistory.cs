using System;
using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class AllianceHistory
    {
        /// <summary>
        /// alliance_id integer
        /// </summary>
        [JsonProperty("alliance_id")]
        public int? AllianceId { get; init; }

        /// <summary>
        /// True if the alliance has been closed
        /// </summary>
        [JsonProperty("is_deleted")]
        public bool? IsDeleted { get; init; }

        /// <summary>
        /// An incrementing ID that can be used to canonically establish order of records in cases where dates may be ambiguous
        /// </summary>
        [JsonProperty("record_id")]
        public required int RecordId { get; init; }

        /// <summary>
        /// start_date string
        /// </summary>
        [JsonProperty("start_date")]
        public required DateTime StartDate { get; init; }
    }
}
