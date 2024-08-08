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
        public required string Description {  get; set; }

        /// <summary>
        /// fitting_id integer
        /// </summary>
        [JsonProperty("fitting_id")]
        public required int FittingId { get; init; }

        /// <summary>
        /// items array
        /// </summary>
        [JsonProperty("items")]
        public required List<FittingItem> Items { get; init; }

        /// <summary>
        /// name string
        /// </summary>
        [JsonProperty("name")]
        public required string Name { get; init; }

        /// <summary>
        /// ship_type_id integer
        /// </summary>
        [JsonProperty("ship_type_id")]
        public required int ShipTypeId { get; init; }

    }

    public class FittingItem
    {
        /// <summary>
        /// type_id integer
        /// </summary>
        [JsonProperty("type_id")]
        public required int TypeId { get; init; }

        /// <summary>
        /// flag string
        /// </summary>
        [JsonProperty("flag")]
        public required FittingFlag Flag { get; init; }

        /// <summary>
        /// quantity integer
        /// </summary>
        [JsonProperty("quantity")]
        public required int Quantity { get; init; }
    }
}
