using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class Points
    {
        /// <summary>
        /// corporation_id integer
        /// </summary>
        [JsonPropertyName("corporation_id")]
        public required int CorporationId { get; init; }

        /// <summary>
        /// loyalty_points integer
        /// </summary>
        [JsonPropertyName("loyalty_points")]
        public required int LoyaltyPoints { get; init; }
    }
}
