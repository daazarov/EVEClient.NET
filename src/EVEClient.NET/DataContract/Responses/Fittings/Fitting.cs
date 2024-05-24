using System.Collections.Generic;
using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class Fitting
    {
        /// <summary>
        /// description string
        /// </summary>
        [JsonProperty("description")]
        public string Description {  get; set; }

        /// <summary>
        /// fitting_id integer
        /// </summary>
        [JsonProperty("fitting_id")]
        public int FittingId { get; set; }

        /// <summary>
        /// items array
        /// </summary>
        [JsonProperty("items")]
        public List<FittingItem> Items { get; set; } = new List<FittingItem>();

        /// <summary>
        /// name string
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// ship_type_id integer
        /// </summary>
        [JsonProperty("ship_type_id")]
        public int ShipTypeId { get; set; }

    }

    public class FittingItem
    {
        /// <summary>
        /// type_id integer
        /// </summary>
        [JsonProperty("type_id")]
        public int TypeId { get; set; }

        /// <summary>
        /// flag string
        /// </summary>
        [JsonProperty("flag")]
        public FittingFlag Flag { get; set; }

        /// <summary>
        /// quantity integer
        /// </summary>
        [JsonProperty("quantity")]
        public int Quantity { get; set; }
    }
}
