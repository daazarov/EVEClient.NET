using System;
using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class MemberTracking
    {
        /// <summary>
        /// base_id integer
        /// </summary>
        [JsonPropertyName("base_id")]
        public int? BaseId { get; init; }

        /// <summary>
        /// character_id integer
        /// </summary>
        [JsonPropertyName("character_id")]
        public required int CharacterId { get; init; }

        /// <summary>
        /// location_id integer
        /// </summary>
        [JsonPropertyName("location_id")]
        public long? LocationId { get; init; }

        /// <summary>
        /// logoff_date string
        /// </summary>
        [JsonPropertyName("logoff_date")]
        public DateTime? LogoffDate { get; init; }

        /// <summary>
        /// logon_date string
        /// </summary>
        [JsonPropertyName("logon_date")]
        public DateTime? LogonDate { get; init; }

        /// <summary>
        /// ship_type_id integer
        /// </summary>
        [JsonPropertyName("ship_type_id")]
        public int? ShipTypeId { get; init; }

        /// <summary>
        /// start_date string
        /// </summary>
        [JsonPropertyName("start_date")]
        public DateTime? StartDate { get; init; }
    }
}
