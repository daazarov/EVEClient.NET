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
        public required float Amount { get; init; }

        /// <summary>
        /// Unique ID for the bid
        /// </summary>
        [JsonProperty("bid_id")]
        public required int BidId { get; init; }

        /// <summary>
        /// Character ID of the bidder
        /// </summary>
        [JsonProperty("bidder_id")]
        public required int BidderId { get; init; }

        /// <summary>
        /// Datetime when the bid was placed
        /// </summary>
        [JsonProperty("date_bid")]
        public required DateTime DateBid { get; init; }
    }
}
