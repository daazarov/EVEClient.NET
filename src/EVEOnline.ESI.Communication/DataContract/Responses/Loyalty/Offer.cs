using System.Collections.Generic;
using Newtonsoft.Json;

namespace EVEOnline.ESI.Communication.DataContract
{
    public class Offer
    {
        /// <summary>
        /// Analysis kredit cost
        /// </summary>
        [JsonProperty("ak_cost")]
        public int? AkCost { get; set; }

        /// <summary>
        /// isk_cost integer
        /// </summary>
        [JsonProperty("isk_cost")]
        public long IskCost { get; set; }

        /// <summary>
        /// lp_cost integer
        /// </summary>
        [JsonProperty("lp_cost")]
        public int LpCost { get; set; }

        /// <summary>
        /// offer_id integer
        /// </summary>
        [JsonProperty("offer_id")]
        public int OfferId { get; set; }

        /// <summary>
        /// quantity integer
        /// </summary>
        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        /// <summary>
        /// required_items array
        /// </summary>
        [JsonProperty("required_items")]
        public List<Item> RequiredItems { get; set; } = new List<Item>();

        /// <summary>
        /// type_id integer
        /// </summary>
        [JsonProperty("type_id")]
        public int TypeId { get; set; }
    }

    public class Item
    {
        /// <summary>
        /// quantity integer
        /// </summary>
        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        /// <summary>
        /// type_id integer
        /// </summary>
        [JsonProperty("type_id")]
        public int TypeId { get; set; }
    }
}
