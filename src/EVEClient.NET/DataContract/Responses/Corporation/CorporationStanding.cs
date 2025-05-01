using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class CorporationStanding
    {
        /// <summary>
        /// from_id integer
        /// </summary>
        [JsonPropertyName("from_id")]
        public required int FromId { get; init; }

        /// <summary>
        /// from_type string
        /// </summary>
        [JsonPropertyName("from_type")]
        public required StandingType StandingType { get; init; }

        /// <summary>
        /// standing number
        /// </summary>
        [JsonPropertyName("standing")]
        public required float Standing { get; init; }
    }
}
