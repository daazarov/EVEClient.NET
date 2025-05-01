using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class SolarSystemSovereignty
    {
        /// <summary>
        /// alliance_id integer
        /// </summary>
        [JsonPropertyName("alliance_id")]
        public int? AllianceId { get; init; }

        /// <summary>
        /// corporation_id integer
        /// </summary>
        [JsonPropertyName("corporation_id")]
        public int? CorporationId { get; init; }

        /// <summary>
        /// faction_id integer
        /// </summary>
        [JsonPropertyName("faction_id")]
        public int? FactionId { get; init; }

        /// <summary>
        /// system_id integer
        /// </summary>
        [JsonPropertyName("system_id")]
        public required int SystemId { get; init; }
    }
}
