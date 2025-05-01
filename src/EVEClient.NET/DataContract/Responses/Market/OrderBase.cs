using System;
using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    /// <summary>
    /// Returns the base view of the order with all properties.
    /// </summary>
    /// <remarks>
    /// To convert to a more specific object, use the conversions if needed:
    /// <see cref="ToCharacterOrderView"/>, <see cref="ToCorporationOrderView"/>, <see cref="ToRegionOrderView"/>, <see cref="ToStructureOrderView"/>
    /// depending on the method being called.
    /// </remarks>
    public class OrderBase
    {
        /// <summary>
        /// Number of days for which order is/was valid (starting from the issued date). An order expires at time issued + duration
        /// </summary>
        [JsonPropertyName("duration")]
        public required int Duration { get; init; }

        /// <summary>
        /// For buy orders, the amount of ISK in escrow
        /// </summary>
        [JsonPropertyName("escrow")]
        public double? Escrow { get; init; }

        /// <summary>
        /// True if the order is a bid (buy) order
        /// </summary>
        [JsonPropertyName("is_buy_order")]
        public bool? IsBuyOrder { get; init; }

        /// <summary>
        /// Signifies whether the buy/sell order was placed on behalf of a corporation.
        /// </summary>
        [JsonPropertyName("is_corporation")]
        public bool? IsCorporation { get; init; }

        /// <summary>
        /// Date and time when this order was issued
        /// </summary>
        [JsonPropertyName("issued")]
        public required DateTime Issued { get; init; }

        /// <summary>
        /// The character who issued this order
        /// </summary>
        [JsonPropertyName("issued_by")]
        public int? IssuedBy { get; init; }

        /// <summary>
        /// ID of the location where order was placed
        /// </summary>
        [JsonPropertyName("location_id")]
        public required long LocationId { get; init; }

        /// <summary>
        /// For buy orders, the minimum quantity that will be accepted in a matching sell order
        /// </summary>
        [JsonPropertyName("min_volume")]
        public int? MinVolume { get; init; }

        /// <summary>
        /// Unique order ID
        /// </summary>
        [JsonPropertyName("order_id")]
        public required long OrderId { get; init; }

        /// <summary>
        /// Cost per unit for this order
        /// </summary>
        [JsonPropertyName("price")]
        public required double Price { get; init; }

        /// <summary>
        /// Valid order range, numbers are ranges in jumps
        /// </summary>
        [JsonPropertyName("range")]
        public required OrderRange Range { get; init; }

        /// <summary>
        /// The solar system this order was placed
        /// </summary>
        [JsonPropertyName("system_id")]
        public int? SystemId { get; init; }

        /// <summary>
        /// ID of the region where order was placed
        /// </summary>
        [JsonPropertyName("region_id")]
        public int? RegionId { get; init; }

        /// <summary>
        /// Current order state
        /// </summary>
        [JsonPropertyName("state")]
        public OrderState? State { get; init; }

        /// <summary>
        /// The type ID of the item transacted in this order
        /// </summary>
        [JsonPropertyName("type_id")]
        public required int TypeId { get; init; }

        /// <summary>
        /// Quantity of items still required or offered
        /// </summary>
        [JsonPropertyName("volume_remain")]
        public required int VolumeRemain { get; init; }

        /// <summary>
        /// Quantity of items required or offered at time order was placed
        /// </summary>
        [JsonPropertyName("volume_total")]
        public required int VolumeTotal { get; init; }

        /// <summary>
        /// The corporation wallet division used for this order.
        /// </summary>
        [JsonPropertyName("wallet_division")]
        public int? WalletDivision { get; init; }

        public CharacterOrder ToCharacterOrderView()
        {
            return new CharacterOrder
            { 
                Duration = this.Duration,
                Escrow = this.Escrow,
                IsBuyOrder = this.IsBuyOrder,
                IsCorporation = this.IsCorporation!.Value,
                Issued = this.Issued,
                LocationId = this.LocationId,
                MinVolume = this.MinVolume,
                OrderId = this.OrderId,
                Price = this.Price,
                Range = this.Range,
                RegionId = this.RegionId!.Value,
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
                IssuedBy = this.IssuedBy!.Value,
                LocationId = this.LocationId,
                MinVolume = this.MinVolume,
                OrderId = this.OrderId,
                Price = this.Price,
                Range = this.Range,
                RegionId = this.RegionId!.Value,
                State = this.State!.Value,
                TypeId = this.TypeId,
                VolumeRemain = this.VolumeRemain,
                VolumeTotal = this.VolumeTotal,
                WalletDivision = this.WalletDivision!.Value
            };
        }

        public RegionOrder ToRegionOrderView()
        {
            return new RegionOrder
            {
                Duration = this.Duration,
                IsBuyOrder = this.IsBuyOrder!.Value,
                Issued = this.Issued,
                LocationId = this.LocationId,
                MinVolume = this.MinVolume!.Value,
                OrderId = this.OrderId,
                Price = this.Price,
                Range = this.Range,
                SystemId = this.SystemId!.Value,
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
                IsBuyOrder = this.IsBuyOrder!.Value,
                Issued = this.Issued,
                LocationId = this.LocationId,
                MinVolume = this.MinVolume!.Value,
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
