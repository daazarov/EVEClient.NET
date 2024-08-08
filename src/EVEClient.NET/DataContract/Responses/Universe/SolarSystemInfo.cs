using System.Collections.Generic;
using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class SolarSystemInfo
    {
        /// <summary>
        /// The constellation this solar system is in
        /// </summary>
        [JsonProperty("constellation_id")]
        public required int ConstellationId {  get; set; }

        /// <summary>
        /// name string
        /// </summary>
        [JsonProperty("name")]
        public required string Name { get; init; }

        /// <summary>
        /// planets array
        /// </summary>
        [JsonProperty("planets")]
        public List<IncludedObject>? Planets { get; init; }

        /// <summary>
        /// position object
        /// </summary>
        [JsonProperty("position")]
        public required Position Position { get; init; }

        /// <summary>
        /// security_class string
        /// </summary>
        [JsonProperty("security_class")]
        public string? SecurityClass { get; init; }

        /// <summary>
        /// security_status number
        /// </summary>
        [JsonProperty("security_status")]
        public required float SecurityStatus { get; init; }

        /// <summary>
        /// star_id integer
        /// </summary>
        [JsonProperty("star_id")]
        public int? StarId { get; init; }

        /// <summary>
        /// stargates array
        /// </summary>
        [JsonProperty("stargates")]
        public int[]? Stargates { get; init; }

        /// <summary>
        /// stations array
        /// </summary>
        [JsonProperty("stations")]
        public int[]? Stations { get; init; }

        /// <summary>
        /// system_id integer
        /// </summary>
        [JsonProperty("system_id")]
        public required int SystemId { get; init; }


        public class IncludedObject
        {
            /// <summary>
            /// asteroid_belts array
            /// </summary>
            [JsonProperty("asteroid_belts")]
            public int[]? AsteroidBelts { get; init; }

            /// <summary>
            /// moons array
            /// </summary>
            [JsonProperty("moons")]
            public int[]? Moons { get; init; }

            /// <summary>
            /// planet_id integer
            /// </summary>
            [JsonProperty("planet_id")]
            public required int PlanetId { get; init; }
        }
    }
}
