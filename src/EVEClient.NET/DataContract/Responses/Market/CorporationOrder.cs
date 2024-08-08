using System;

namespace EVEClient.NET.DataContract
{
    public class CorporationOrder
    {
        /// <summary>
        /// Number of days for which order is/was valid (starting from the issued date). An order expires at time issued + duration
        /// </summary>
        public int Duration { get; init; }

        /// <summary>
        /// For buy orders, the amount of ISK in escrow
        /// </summary>
        public double? Escrow { get; init; }

        /// <summary>
        /// True if the order is a bid (buy) order
        /// </summary>
        public bool? IsBuyOrder { get; init; }

        /// <summary>
        /// Date and time when this order was issued
        /// </summary>
        public DateTime Issued { get; init; }

        /// <summary>
        /// The character who issued this order
        /// </summary>
        public int IssuedBy { get; init; }

        /// <summary>
        /// ID of the location where order was placed
        /// </summary>
        public long LocationId { get; init; }

        /// <summary>
        /// For buy orders, the minimum quantity that will be accepted in a matching sell order
        /// </summary>
        public int? MinVolume { get; init; }

        /// <summary>
        /// Unique order ID
        /// </summary>
        public long OrderId { get; init; }

        /// <summary>
        /// Cost per unit for this order
        /// </summary>
        public double Price { get; init; }

        /// <summary>
        /// Valid order range, numbers are ranges in jumps
        /// </summary>
        public OrderRange Range { get; init; }

        /// <summary>
        /// ID of the region where order was placed
        /// </summary>
        public int RegionId { get; init; }

        /// <summary>
        /// Current order state
        /// </summary>
        public OrderState State { get; init; } = OrderState.Active;

        /// <summary>
        /// The type ID of the item transacted in this order
        /// </summary>
        public int TypeId { get; init; }

        /// <summary>
        /// Quantity of items still required or offered
        /// </summary>
        public int VolumeRemain { get; init; }

        /// <summary>
        /// Quantity of items required or offered at time order was placed
        /// </summary>
        public int VolumeTotal { get; init; }

        /// <summary>
        /// The corporation wallet division used for this order.
        /// </summary>
        public int WalletDivision {  get; set; }
    }
}
