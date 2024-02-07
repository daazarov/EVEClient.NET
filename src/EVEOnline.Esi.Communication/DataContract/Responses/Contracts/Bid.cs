using System;
using Newtonsoft.Json;

namespace EVEOnline.ESI.Communication.DataContract
{
    public class Bid
    {
        /// <summary>
        /// The amount bid, in ISK
        /// </summary>
        [JsonProperty("amount")]
        public float amount { get; set; }

        /// <summary>
        /// Unique ID for the bid
        /// </summary>
        [JsonProperty("bid_id")]
        public int bid_id { get; set; }

        /// <summary>
        /// Character ID of the bidder
        /// </summary>
        [JsonProperty("bidder_id")]
        public int bidder_id { get; set; }

        /// <summary>
        /// Datetime when the bid was placed
        /// </summary>
        [JsonProperty("date_bid")]
        public DateTime date_bid { get; set; }
    }
}
