using EVEClient.NET.Extensions;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class NewFitting
    {
        /// <summary>
        /// description string
        /// </summary>
        [JsonPropertyName("description")]
        public required string Description {  get; set; }

        /// <summary>
        /// items array
        /// </summary>
        [JsonPropertyName("items")]
        public required List<FittingItem> Items { get; set; }

        /// <summary>
        /// name string
        /// </summary>
        [JsonPropertyName("name")]
        public required string Name { get; set; }

        /// <summary>
        /// ship_type_id integer
        /// </summary>
        [JsonPropertyName("ship_type_id")]
        public required int ShipTypeId { get; set; }

        public class FittingItem
        {
            /// <summary>
            /// type_id integer
            /// </summary>
            [JsonPropertyName("type_id")]
            public required int TypeId { get; init; }

            /// <summary>
            /// Fitting location for the item.Entries placed in ‘Invalid’ will be discarded.If this leaves the fitting with nothing, it will cause an error.
            /// </summary>
            [JsonIgnore]
            public required FittingFlag Flag { get; init; }

            [JsonPropertyName("flag")]
            [JsonInclude]
            private string FlagName => Flag.ToEsiString();

            /// <summary>
            /// quantity integer
            /// </summary>
            [JsonPropertyName("quantity")]
            public required int Quantity { get; init; }
        }
    }
}
