using System;
using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class CharacterCorporationHistory
    {
        /// <summary>
        /// corporation_id integer
        /// </summary>
        [JsonPropertyName("corporation_id")]
        public required int CorporationId { get; init; }

        /// <summary>
        /// True if the corporation has been deleted
        /// </summary>
        [JsonPropertyName("is_deleted")]
        public bool? IsDeleted { get; init; }

        /// <summary>
        /// An incrementing ID that can be used to canonically establish order of records in cases where dates may be ambiguous
        /// </summary>
        [JsonPropertyName("record_id")]
        public required int RecordId { get; init; }

        /// <summary>
        /// start_date string
        /// </summary>
        [JsonPropertyName("start_date")]
        public required DateTime StartDate { get; init; }
    }
}
