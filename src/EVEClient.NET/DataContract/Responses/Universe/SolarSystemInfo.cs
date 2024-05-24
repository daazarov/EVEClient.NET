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
        public int ConstellationId {  get; set; }

        /// <summary>
        /// name string
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// planets array
        /// </summary>
        [JsonProperty("planets")]
        public List<IncludedObject> Planets { get; set; }

        /// <summary>
        /// position object
        /// </summary>
        [JsonProperty("position")]
        public Position Position { get; set; }

        /// <summary>
        /// security_class string
        /// </summary>
        [JsonProperty("security_class")]
        public string SecurityClass { get; set; }

        /// <summary>
        /// security_status number
        /// </summary>
        [JsonProperty("security_status")]
        public float SecurityStatus { get; set; }

        /// <summary>
        /// star_id integer
        /// </summary>
        [JsonProperty("star_id")]
        public int? StarId { get; set; }

        /// <summary>
        /// stargates array
        /// </summary>
        [JsonProperty("stargates")]
        public int[] Stargates { get; set; }

        /// <summary>
        /// stations array
        /// </summary>
        [JsonProperty("stations")]
        public int[] Stations { get; set; }

        /// <summary>
        /// system_id integer
        /// </summary>
        [JsonProperty("system_id")]
        public int SystemId { get; set; }


        public class IncludedObject
        {
            /// <summary>
            /// asteroid_belts array
            /// </summary>
            [JsonProperty("asteroid_belts")]
            public int[] AsteroidBelts { get; set; }

            /// <summary>
            /// moons array
            /// </summary>
            [JsonProperty("moons")]
            public int[] Moons { get; set; }

            /// <summary>
            /// planet_id integer
            /// </summary>
            [JsonProperty("planet_id")]
            public int PlanetId { get; set; }
        }
    }
}
