using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class Points
    {
        /// <summary>
        /// corporation_id integer
        /// </summary>
        [JsonProperty("corporation_id")]
        public required int CorporationId { get; init; }

        /// <summary>
        /// loyalty_points integer
        /// </summary>
        [JsonProperty("loyalty_points")]
        public required int LoyaltyPoints { get; init; }
    }
}
