using System;
using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    /// <summary>
    /// Returns the base view of the order with all properties.
    /// To convert to a more specific object, use the conversions if needed:
    /// <see cref="ToCharacterOrderView"/>, <see cref="ToCorporationOrderView"/>, <see cref="ToRegionOrderView"/>, <see cref="ToStructureOrderView"/>
    /// depending on the method being called.
    /// </summary>
    public class OrderBase
    {
        /// <summary>
        /// Number of days for which order is/was valid (starting from the issued date). An order expires at time issued + duration
        /// </summary>
        [JsonProperty("duration")]
        public int Duration { get; set; }

        /// <summary>
        /// For buy orders, the amount of ISK in escrow
        /// </summary>
        [JsonProperty("escrow")]
        public double? Escrow { get; set; }

        /// <summary>
        /// True if the order is a bid (buy) order
        /// </summary>
        [JsonProperty("is_buy_order")]
        public bool? IsBuyOrder { get; set; }

        /// <summary>
        /// Signifies whether the buy/sell order was placed on behalf of a corporation.
        /// </summary>
        [JsonProperty("is_corporation")]
        public bool? IsCorporation { get; set; }

        /// <summary>
        /// Date and time when this order was issued
        /// </summary>
        [JsonProperty("issued")]
        public DateTime Issued { get; set; }

        /// <summary>
        /// The character who issued this order
        /// </summary>
        [JsonProperty("issued_by")]
        public int? IssuedBy { get; set; }

        /// <summary>
        /// ID of the location where order was placed
        /// </summary>
        [JsonProperty("location_id")]
        public long LocationId { get; set; }

        /// <summary>
        /// For buy orders, the minimum quantity that will be accepted in a matching sell order
        /// </summary>
        [JsonProperty("min_volume")]
        public int? MinVolume { get; set; }

        /// <summary>
        /// Unique order ID
        /// </summary>
        [JsonProperty("order_id")]
        public long OrderId { get; set; }

        /// <summary>
        /// Cost per unit for this order
        /// </summary>
        [JsonProperty("price")]
        public double Price { get; set; }

        /// <summary>
        /// Valid order range, numbers are ranges in jumps
        /// </summary>
        [JsonProperty("range")]
        public OrderRange Range { get; set; }

        /// <summary>
        /// The solar system this order was placed
        /// </summary>
        [JsonProperty("system_id")]
        public int? SystemId { get; set; }

        /// <summary>
        /// ID of the region where order was placed
        /// </summary>
        [JsonProperty("region_id")]
        public int? RegionId { get; set; }

        /// <summary>
        /// Current order state
        /// </summary>
        [JsonProperty("state")]
        public OrderState State { get; set; } = OrderState.Active;

        /// <summary>
        /// The type ID of the item transacted in this order
        /// </summary>
        [JsonProperty("type_id")]
        public int TypeId { get; set; }

        /// <summary>
        /// Quantity of items still required or offered
        /// </summary>
        [JsonProperty("volume_remain")]
        public int VolumeRemain { get; set; }

        /// <summary>
        /// Quantity of items required or offered at time order was placed
        /// </summary>
        [JsonProperty("volume_total")]
        public int VolumeTotal { get; set; }

        /// <summary>
        /// The corporation wallet division used for this order.
        /// </summary>
        [JsonProperty("wallet_division")]
        public int? WalletDivision { get; set; }

        public CharacterOrder ToCharacterOrderView()
        {
            return new CharacterOrder
            { 
                Duration = this.Duration,
                Escrow = this.Escrow,
                IsBuyOrder = this.IsBuyOrder,
                IsCorporation = this.IsCorporation.Value,
                Issued = this.Issued,
                LocationId = this.LocationId,
                MinVolume = this.MinVolume,
                OrderId = this.OrderId,
                Price = this.Price,
                Range = this.Range,
                RegionId = this.RegionId.Value,
                State = this.State,
                TypeId = this.TypeId,
                VolumeRemain = this.VolumeRemain,
                VolumeTotal = this.VolumeTotal
            };
        }

        public CorporationOrder ToCorporationOrderView()
        {
            return new CorporationOrder
            { 
                Duration = this.Duration,
                Escrow = this.Escrow,
                IsBuyOrder = this.IsBuyOrder,
                Issued = this.Issued,
                IssuedBy = this.IssuedBy.Value,
                LocationId = this.LocationId,
                MinVolume = this.MinVolume,
                OrderId = this.OrderId,
                Price = this.Price,
                Range = this.Range,
                RegionId = this.RegionId.Value,
                State = this.State,
                TypeId = this.TypeId,
                VolumeRemain = this.VolumeRemain,
                VolumeTotal = this.VolumeTotal,
                WalletDivision = this.WalletDivision.Value
            };
        }

        public RegionOrder ToRegionOrderView()
        {
            return new RegionOrder
            {
                Duration = this.Duration,
                IsBuyOrder = this.IsBuyOrder.Value,
                Issued = this.Issued,
                LocationId = this.LocationId,
                MinVolume = this.MinVolume.Value,
                OrderId = this.OrderId,
                Price = this.Price,
                Range = this.Range,
                SystemId = this.SystemId.Value,
                TypeId = this.TypeId,
                VolumeRemain = this.VolumeRemain,
                VolumeTotal = this.VolumeTotal
            };
        }

        public StructureOrder ToStructureOrderView()
        {
            return new StructureOrder
            {
                Duration = this.Duration,
                IsBuyOrder = this.IsBuyOrder.Value,
                Issued = this.Issued,
                LocationId = this.LocationId,
                MinVolume = this.MinVolume.Value,
                OrderId = this.OrderId,
                Price = this.Price,
                Range = this.Range,
                TypeId = this.TypeId,
                VolumeRemain = this.VolumeRemain,
                VolumeTotal = this.VolumeTotal
            };
        }
    }
}
