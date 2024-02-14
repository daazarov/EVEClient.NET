using Newtonsoft.Json;

namespace EVEOnline.ESI.Communication.DataContract
{
    public class Points
    {
        /// <summary>
        /// corporation_id integer
        /// </summary>
        [JsonProperty("corporation_id")]
        public int CorporationId { get; set; }

        /// <summary>
        /// loyalty_points integer
        /// </summary>
        [JsonProperty("loyalty_points")]
        public int LoyaltyPoints { get; set; }
    }
}
