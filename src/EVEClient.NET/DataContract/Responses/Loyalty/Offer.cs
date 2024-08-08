using System.Collections.Generic;
using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class Offer
    {
        /// <summary>
        /// Analysis kredit cost
        /// </summary>
        [JsonProperty("ak_cost")]
        public int? AkCost { get; init; }

        /// <summary>
        /// isk_cost integer
        /// </summary>
        [JsonProperty("isk_cost")]
        public long IskCost { get; init; }

        /// <summary>
        /// lp_cost integer
        /// </summary>
        [JsonProperty("lp_cost")]
        public int LpCost { get; init; }

        /// <summary>
        /// offer_id integer
        /// </summary>
        [JsonProperty("offer_id")]
        public int OfferId { get; init; }

        /// <summary>
        /// quantity integer
        /// </summary>
        [JsonProperty("quantity")]
        public int Quantity { get; init; }

        /// <summary>
        /// required_items array
        /// </summary>
        [JsonProperty("required_items")]
        public List<Item> RequiredItems { get; init; }

        /// <summary>
        /// type_id integer
        /// </summary>
        [JsonProperty("type_id")]
        public int TypeId { get; init; }
    }

    public class Item
    {
        /// <summary>
        /// quantity integer
        /// </summary>
        [JsonProperty("quantity")]
        public int Quantity { get; init; }

        /// <summary>
        /// type_id integer
        /// </summary>
        [JsonProperty("type_id")]
        public int TypeId { get; init; }
    }
}
