using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class ColonyLayout
    {
        /// <summary>
        /// links array
        /// </summary>
        [JsonPropertyName("links")]
        public required List<Link> Links { get; init; }

        /// <summary>
        /// pins array
        /// </summary>
        [JsonPropertyName("pins")]
        public required List<Pin> Pins { get; init; }

        /// <summary>
        /// routes array
        /// </summary>
        [JsonPropertyName("routes")]
        public required List<Route> Routes { get; init; }

        public class Link
        {
            /// <summary>
            /// destination_pin_id integer
            /// </summary>
            [JsonPropertyName("destination_pin_id")]
            public required long DestinationPinId { get; init; }

            /// <summary>
            /// link_level integer
            /// </summary>
            [JsonPropertyName("link_level")]
            public required int LinkLevel { get; init; }

            /// <summary>
            /// source_pin_id integer
            /// </summary>
            [JsonPropertyName("source_pin_id")]
            public required long SourcePinId { get; init; }
        }

        public class Pin
        {
            /// <summary>
            /// contents array
            /// </summary>
            [JsonPropertyName("contents")]
            public List<Content>? Contents { get; init; }

            /// <summary>
            /// expiry_time string
            /// </summary>
            [JsonPropertyName("expiry_time")]
            public DateTime? ExpirationTime { get; init; }

            /// <summary>
            /// extractor object
            /// </summary>
            [JsonPropertyName("extractor_details")]
            public Extractor? ExtractorDetails { get; init; }

            /// <summary>
            /// factory object
            /// </summary>
            [JsonPropertyName("factory_details")]
            public Factory? FactoryDetails { get; init; }

            /// <summary>
            /// install_time string
            /// </summary>
            [JsonPropertyName("install_time")]
            public DateTime? InstallTime { get; init; }

            /// <summary>
            /// last_cycle_start string
            /// </summary>
            [JsonPropertyName("last_cycle_start")]
            public DateTime? LastCycleStart { get; init; }

            /// <summary>
            /// latitude number
            /// </summary>
            [JsonPropertyName("latitude")]
            public required float Latitude { get; init; }

            /// <summary>
            /// longitude number
            /// </summary>
            [JsonPropertyName("longitude")]
            public required float Longitude { get; init; }

            /// <summary>
            /// pin_id integer
            /// </summary>
            [JsonPropertyName("pin_id")]
            public required long PinId { get; init; }

            /// <summary>
            /// schematic_id integer
            /// </summary>
            [JsonPropertyName("schematic_id")]
            public int? SchematicId { get; init; }

            /// <summary>
            /// type_id integer
            /// </summary>
            [JsonPropertyName("type_id")]
            public required int TypeId { get; init; }

            public class Content
            {
                /// <summary>
                /// amount integer
                /// </summary>
                [JsonPropertyName("amount")]
                public required long Amount { get; init; }

                /// <summary>
                /// type_id integer
                /// </summary>
                [JsonPropertyName("type_id")]
                public required int TypeId { get; init; }
            }

            public class Extractor
            {
                /// <summary>
                /// in seconds
                /// </summary>
                [JsonPropertyName("cycle_time")]
                public int? CycleTime { get; init; }

                /// <summary>
                /// head_radius number
                /// </summary>
                [JsonPropertyName("head_radius")]
                public float? HeadRadius { get; init; }

                /// <summary>
                /// heads array
                /// </summary>
                [JsonPropertyName("heads")]
                public required List<Head> Heads { get; init; }

                /// <summary>
                /// product_type_id integer
                /// </summary>
                [JsonPropertyName("product_type_id")]
                public int? ProductTypeId { get; init; }

                /// <summary>
                /// qty_per_cycle integer
                /// </summary>
                [JsonPropertyName("qty_per_cycle")]
                public int? QuantityPerCycle { get; init; }

                public class Head
                {
                    /// <summary>
                    /// head_id integer
                    /// </summary>
                    [JsonPropertyName("head_id")]
                    public required int HeadId { get; init; }

                    /// <summary>
                    /// latitude number
                    /// </summary>
                    [JsonPropertyName("latitude")]
                    public required float Latitude { get; init; }

                    /// <summary>
                    /// longitude number
                    /// </summary>
                    [JsonPropertyName("longitude")]
                    public required float Longitude { get; init; }
                }
            }

            public class Factory
            {
                /// <summary>
                /// schematic_id integer
                /// </summary>
                [JsonPropertyName("schematic_id")]
                public required int SchematicId { get; init; }
            }
        }

        public class Route
        {
            /// <summary>
            /// content_type_id integer
            /// </summary>
            [JsonPropertyName("content_type_id")]
            public required int ContentTypeId { get; init; }

            /// <summary>
            /// destination_pin_id integer
            /// </summary>
            [JsonPropertyName("destination_pin_id")]
            public required long DestinationPinId { get; init; }

            /// <summary>
            /// quantity number
            /// </summary>
            [JsonPropertyName("quantity")]
            public required float Quantity { get; init; }

            /// <summary>
            /// route_id integer
            /// </summary>
            [JsonPropertyName("route_id")]
            public required long RouteId { get; init; }

            /// <summary>
            /// source_pin_id integer
            /// </summary>
            [JsonPropertyName("source_pin_id")]
            public required long SourcePinId { get; init; }

            /// <summary>
            /// list of pin ID waypoints
            /// </summary>
            [JsonPropertyName("waypoints")]
            public long[]? Waypoints { get; init; }
        }
    }
}
