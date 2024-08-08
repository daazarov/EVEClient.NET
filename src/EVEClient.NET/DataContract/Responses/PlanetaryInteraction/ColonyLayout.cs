using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class ColonyLayout
    {
        /// <summary>
        /// links array
        /// </summary>
        [JsonProperty("links")]
        public List<Link> Links { get; init; }

        /// <summary>
        /// pins array
        /// </summary>
        [JsonProperty("pins")]
        public List<Pin> Pins { get; init; }

        /// <summary>
        /// routes array
        /// </summary>
        [JsonProperty("routes")]
        public List<Route> Routes { get; init; }

        public class Link
        {
            /// <summary>
            /// destination_pin_id integer
            /// </summary>
            [JsonProperty("destination_pin_id")]
            public long DestinationPinId { get; init; }

            /// <summary>
            /// link_level integer
            /// </summary>
            [JsonProperty("link_level")]
            public int LinkLevel { get; init; }

            /// <summary>
            /// source_pin_id integer
            /// </summary>
            [JsonProperty("source_pin_id")]
            public long SourcePinId { get; init; }
        }

        public class Pin
        {
            /// <summary>
            /// contents array
            /// </summary>
            [JsonProperty("contents")]
            public List<Content>? Contents { get; init; }

            /// <summary>
            /// expiry_time string
            /// </summary>
            [JsonProperty("expiry_time")]
            public DateTime? ExpirationTime { get; init; }

            /// <summary>
            /// extractor object
            /// </summary>
            [JsonProperty("extractor_details")]
            public Extractor? ExtractorDetails { get; init; }

            /// <summary>
            /// factory object
            /// </summary>
            [JsonProperty("factory_details")]
            public Factory? FactoryDetails { get; init; }

            /// <summary>
            /// install_time string
            /// </summary>
            [JsonProperty("install_time")]
            public DateTime? InstallTime { get; init; }

            /// <summary>
            /// last_cycle_start string
            /// </summary>
            [JsonProperty("last_cycle_start")]
            public DateTime? LastCycleStart { get; init; }

            /// <summary>
            /// latitude number
            /// </summary>
            [JsonProperty("latitude")]
            public float Latitude { get; init; }

            /// <summary>
            /// longitude number
            /// </summary>
            [JsonProperty("longitude")]
            public float Longitude { get; init; }

            /// <summary>
            /// pin_id integer
            /// </summary>
            [JsonProperty("pin_id")]
            public long PinId { get; init; }

            /// <summary>
            /// schematic_id integer
            /// </summary>
            [JsonProperty("schematic_id")]
            public int? SchematicId { get; init; }

            /// <summary>
            /// type_id integer
            /// </summary>
            [JsonProperty("type_id")]
            public int TypeId { get; init; }

            public class Content
            {
                /// <summary>
                /// amount integer
                /// </summary>
                [JsonProperty("amount")]
                public long Amount { get; init; }

                /// <summary>
                /// type_id integer
                /// </summary>
                [JsonProperty("type_id")]
                public int TypeId { get; init; }
            }

            public class Extractor
            {
                /// <summary>
                /// in seconds
                /// </summary>
                [JsonProperty("cycle_time")]
                public int? CycleTime { get; init; }

                /// <summary>
                /// head_radius number
                /// </summary>
                [JsonProperty("head_radius")]
                public float? HeadRadius { get; init; }

                /// <summary>
                /// heads array
                /// </summary>
                [JsonProperty("heads")]
                public List<Head> Heads { get; init; }

                /// <summary>
                /// product_type_id integer
                /// </summary>
                [JsonProperty("product_type_id")]
                public int? ProductTypeId { get; init; }

                /// <summary>
                /// qty_per_cycle integer
                /// </summary>
                [JsonProperty("qty_per_cycle")]
                public int? QuantityPerCycle { get; init; }

                public class Head
                {
                    /// <summary>
                    /// head_id integer
                    /// </summary>
                    [JsonProperty("head_id")]
                    public int HeadId { get; init; }

                    /// <summary>
                    /// latitude number
                    /// </summary>
                    [JsonProperty("latitude")]
                    public float Latitude { get; init; }

                    /// <summary>
                    /// longitude number
                    /// </summary>
                    [JsonProperty("longitude")]
                    public float Longitude { get; init; }
                }
            }

            public class Factory
            {
                /// <summary>
                /// schematic_id integer
                /// </summary>
                [JsonProperty("schematic_id")]
                public int SchematicId { get; init; }
            }
        }

        public class Route
        {
            /// <summary>
            /// content_type_id integer
            /// </summary>
            [JsonProperty("content_type_id")]
            public int ContentTypeId { get; init; }

            /// <summary>
            /// destination_pin_id integer
            /// </summary>
            [JsonProperty("destination_pin_id")]
            public long DestinationPinId { get; init; }

            /// <summary>
            /// quantity number
            /// </summary>
            [JsonProperty("quantity")]
            public float Quantity { get; init; }

            /// <summary>
            /// route_id integer
            /// </summary>
            [JsonProperty("route_id")]
            public long RouteId { get; init; }

            /// <summary>
            /// source_pin_id integer
            /// </summary>
            [JsonProperty("source_pin_id")]
            public long SourcePinId { get; init; }

            /// <summary>
            /// list of pin ID waypoints
            /// </summary>
            [JsonProperty("waypoints")]
            public long[]? Waypoints { get; init; }
        }
    }
}
