using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class Fitting
    {
        /// <summary>
        /// description string
        /// </summary>
        [JsonPropertyName("description")]
        public required string Description { get; init; }

        /// <summary>
        /// fitting_id integer
        /// </summary>
        [JsonPropertyName("fitting_id")]
        public required int FittingId { get; init; }

        /// <summary>
        /// items array
        /// </summary>
        [JsonPropertyName("items")]
        public required List<FittingItem> Items { get; init; }

        /// <summary>
        /// name string
        /// </summary>
        [JsonPropertyName("name")]
        public required string Name { get; init; }

        /// <summary>
        /// ship_type_id integer
        /// </summary>
        [JsonPropertyName("ship_type_id")]
        public required int ShipTypeId { get; init; }

    }

    public class FittingItem
    {
        /// <summary>
        /// type_id integer
        /// </summary>
        [JsonPropertyName("type_id")]
        public required int TypeId { get; init; }

        /// <summary>
        /// flag string
        /// </summary>
        [JsonPropertyName("flag")]
        public required FittingFlag Flag { get; init; }

        /// <summary>
        /// quantity integer
        /// </summary>
        [JsonPropertyName("quantity")]
        public required int Quantity { get; init; }
    }
}
