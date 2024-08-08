using System.Collections.Generic;

namespace EVEClient.NET.DataContract
{
    public class NewFitting
    {
        /// <summary>
        /// description string
        /// </summary>
        public required string Description {  get; set; }

        /// <summary>
        /// items array
        /// </summary>
        public required List<FittingItem> Items { get; set; }

        /// <summary>
        /// name string
        /// </summary>
        public required string Name { get; set; }

        /// <summary>
        /// ship_type_id integer
        /// </summary>
        public required int ShipTypeId { get; set; }

        public class FittingItem
        {
            /// <summary>
            /// type_id integer
            /// </summary>
            public required int TypeId { get; init; }

            /// <summary>
            /// Fitting location for the item.Entries placed in ‘Invalid’ will be discarded.If this leaves the fitting with nothing, it will cause an error.
            /// </summary>
            public required FittingFlag Flag { get; init; }

            /// <summary>
            /// quantity integer
            /// </summary>
            public required int Quantity { get; init; }
        }
    }
}
