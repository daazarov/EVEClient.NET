using System;
using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class Bid
    {
        /// <summary>
        /// The amount bid, in ISK
        /// </summary>
        [JsonPropertyName("amount")]
        public required float Amount { get; init; }

        /// <summary>
        /// Unique ID for the bid
        /// </summary>
        [JsonPropertyName("bid_id")]
        public required int BidId { get; init; }

        /// <summary>
        /// Character ID of the bidder
        /// </summary>
        [JsonPropertyName("bidder_id")]
        public required int BidderId { get; init; }

        /// <summary>
        /// Datetime when the bid was placed
        /// </summary>
        [JsonPropertyName("date_bid")]
        public required DateTime DateBid { get; init; }
    }
}
