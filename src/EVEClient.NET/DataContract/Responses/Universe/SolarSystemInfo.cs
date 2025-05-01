using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class SolarSystemInfo
    {
        /// <summary>
        /// The constellation this solar system is in
        /// </summary>
        [JsonPropertyName("constellation_id")]
        public required int ConstellationId { get; init; }

        /// <summary>
        /// name string
        /// </summary>
        [JsonPropertyName("name")]
        public required string Name { get; init; }

        /// <summary>
        /// planets array
        /// </summary>
        [JsonPropertyName("planets")]
        public List<IncludedObject>? Planets { get; init; }

        /// <summary>
        /// position object
        /// </summary>
        [JsonPropertyName("position")]
        public required Position Position { get; init; }

        /// <summary>
        /// security_class string
        /// </summary>
        [JsonPropertyName("security_class")]
        public string? SecurityClass { get; init; }

        /// <summary>
        /// security_status number
        /// </summary>
        [JsonPropertyName("security_status")]
        public required float SecurityStatus { get; init; }

        /// <summary>
        /// star_id integer
        /// </summary>
        [JsonPropertyName("star_id")]
        public int? StarId { get; init; }

        /// <summary>
        /// stargates array
        /// </summary>
        [JsonPropertyName("stargates")]
        public int[]? Stargates { get; init; }

        /// <summary>
        /// stations array
        /// </summary>
        [JsonPropertyName("stations")]
        public int[]? Stations { get; init; }

        /// <summary>
        /// system_id integer
        /// </summary>
        [JsonPropertyName("system_id")]
        public required int SystemId { get; init; }


        public class IncludedObject
        {
            /// <summary>
            /// asteroid_belts array
            /// </summary>
            [JsonPropertyName("asteroid_belts")]
            public int[]? AsteroidBelts { get; init; }

            /// <summary>
            /// moons array
            /// </summary>
            [JsonPropertyName("moons")]
            public int[]? Moons { get; init; }

            /// <summary>
            /// planet_id integer
            /// </summary>
            [JsonPropertyName("planet_id")]
            public required int PlanetId { get; init; }
        }
    }
}
