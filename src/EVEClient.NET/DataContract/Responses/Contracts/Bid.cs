using System;
using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class Bid
    {
        /// <summary>
        /// The amount bid, in ISK
        /// </summary>
        [JsonProperty("amount")]
        public float Amount { get; init; }

        /// <summary>
        /// Unique ID for the bid
        /// </summary>
        [JsonProperty("bid_id")]
        public int BidId { get; init; }

        /// <summary>
        /// Character ID of the bidder
        /// </summary>
        [JsonProperty("bidder_id")]
        public int BidderId { get; init; }

        /// <summary>
        /// Datetime when the bid was placed
        /// </summary>
        [JsonProperty("date_bid")]
        public DateTime DateBid { get; init; }
    }
}
