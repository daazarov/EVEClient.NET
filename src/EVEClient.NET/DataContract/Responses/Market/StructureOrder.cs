using System;

namespace EVEClient.NET.DataContract
{
    public class StructureOrder
    {
        /// <summary>
        /// Number of days for which order is/was valid (starting from the issued date). An order expires at time issued + duration
        /// </summary>
        public int Duration { get; set; }

        /// <summary>
        /// True if the order is a bid (buy) order
        /// </summary>
        public bool IsBuyOrder { get; set; }

        /// <summary>
        /// Date and time when this order was issued
        /// </summary>
        public DateTime Issued { get; set; }

        /// <summary>
        /// ID of the location where order was placed
        /// </summary>
        public long LocationId { get; set; }

        /// <summary>
        /// For buy orders, the minimum quantity that will be accepted in a matching sell order
        /// </summary>
        public int MinVolume { get; set; }

        /// <summary>
        /// Unique order ID
        /// </summary>
        public long OrderId { get; set; }

        /// <summary>
        /// Cost per unit for this order
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Valid order range, numbers are ranges in jumps
        /// </summary>
        public OrderRange Range { get; set; }

        /// <summary>
        /// The type ID of the item transacted in this order
        /// </summary>
        public int TypeId { get; set; }

        /// <summary>
        /// Quantity of items still required or offered
        /// </summary>
        public int VolumeRemain { get; set; }

        /// <summary>
        /// Quantity of items required or offered at time order was placed
        /// </summary>
        public int VolumeTotal { get; set; }
    }
}
