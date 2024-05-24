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
        public List<Link> Links { get; set; }

        /// <summary>
        /// pins array
        /// </summary>
        [JsonProperty("pins")]
        public List<Pin> Pins { get; set; }

        /// <summary>
        /// routes array
        /// </summary>
        [JsonProperty("routes")]
        public List<Route> Routes { get; set; }

        public class Link
        {
            /// <summary>
            /// destination_pin_id integer
            /// </summary>
            [JsonProperty("destination_pin_id")]
            public long DestinationPinId { get; set; }

            /// <summary>
            /// link_level integer
            /// </summary>
            [JsonProperty("link_level")]
            public int LinkLevel { get; set; }

            /// <summary>
            /// source_pin_id integer
            /// </summary>
            [JsonProperty("source_pin_id")]
            public long SourcePinId { get; set; }
        }

        public class Pin
        {
            /// <summary>
            /// contents array
            /// </summary>
            [JsonProperty("contents")]
            public List<Content> Contents { get; set; }

            /// <summary>
            /// expiry_time string
            /// </summary>
            [JsonProperty("expiry_time")]
            public DateTime? ExpirationTime { get; set; }

            /// <summary>
            /// extractor object
            /// </summary>
            [JsonProperty("extractor_details")]
            public Extractor ExtractorDetails { get; set; }

            /// <summary>
            /// factory object
            /// </summary>
            [JsonProperty("factory_details")]
            public Factory FactoryDetails { get; set; }

            /// <summary>
            /// install_time string
            /// </summary>
            [JsonProperty("install_time")]
            public DateTime? InstallTime { get; set; }

            /// <summary>
            /// last_cycle_start string
            /// </summary>
            [JsonProperty("last_cycle_start")]
            public DateTime? LastCycleStart { get; set; }

            /// <summary>
            /// latitude number
            /// </summary>
            [JsonProperty("latitude")]
            public float Latitude { get; set; }

            /// <summary>
            /// longitude number
            /// </summary>
            [JsonProperty("longitude")]
            public float Longitude { get; set; }

            /// <summary>
            /// pin_id integer
            /// </summary>
            [JsonProperty("pin_id")]
            public long PinId { get; set; }

            /// <summary>
            /// schematic_id integer
            /// </summary>
            [JsonProperty("schematic_id")]
            public int? SchematicId { get; set; }

            /// <summary>
            /// type_id integer
            /// </summary>
            [JsonProperty("type_id")]
            public int TypeId { get; set; }

            public class Content
            {
                /// <summary>
                /// amount integer
                /// </summary>
                [JsonProperty("amount")]
                public long Amount { get; set; }

                /// <summary>
                /// type_id integer
                /// </summary>
                [JsonProperty("type_id")]
                public int TypeId { get; set; }
            }

            public class Extractor
            {
                /// <summary>
                /// in seconds
                /// </summary>
                [JsonProperty("cycle_time")]
                public int? CycleTime { get; set; }

                /// <summary>
                /// head_radius number
                /// </summary>
                [JsonProperty("head_radius")]
                public float? HeadRadius { get; set; }

                /// <summary>
                /// heads array
                /// </summary>
                [JsonProperty("heads")]
                public List<Head> Heads { get; set; }

                /// <summary>
                /// product_type_id integer
                /// </summary>
                [JsonProperty("product_type_id")]
                public int? ProductTypeId { get; set; }

                /// <summary>
                /// qty_per_cycle integer
                /// </summary>
                [JsonProperty("qty_per_cycle")]
                public int? QuantityPerCycle { get; set; }

                public class Head
                {
                    /// <summary>
                    /// head_id integer
                    /// </summary>
                    [JsonProperty("head_id")]
                    public int HeadId { get; set; }

                    /// <summary>
                    /// latitude number
                    /// </summary>
                    [JsonProperty("latitude")]
                    public float Latitude { get; set; }

                    /// <summary>
                    /// longitude number
                    /// </summary>
                    [JsonProperty("longitude")]
                    public float Longitude { get; set; }
                }
            }

            public class Factory
            {
                /// <summary>
                /// schematic_id integer
                /// </summary>
                [JsonProperty("schematic_id")]
                public int SchematicId { get; set; }
            }
        }

        public class Route
        {
            /// <summary>
            /// content_type_id integer
            /// </summary>
            [JsonProperty("content_type_id")]
            public int ContentTypeId { get; set; }

            /// <summary>
            /// destination_pin_id integer
            /// </summary>
            [JsonProperty("destination_pin_id")]
            public long DestinationPinId { get; set; }

            /// <summary>
            /// quantity number
            /// </summary>
            [JsonProperty("quantity")]
            public float Quantity { get; set; }

            /// <summary>
            /// route_id integer
            /// </summary>
            [JsonProperty("route_id")]
            public long RouteId { get; set; }

            /// <summary>
            /// source_pin_id integer
            /// </summary>
            [JsonProperty("source_pin_id")]
            public long SourcePinId { get; set; }

            /// <summary>
            /// list of pin ID waypoints
            /// </summary>
            [JsonProperty("waypoints")]
            public long[] Waypoints { get; set; }
        }
    }
}
