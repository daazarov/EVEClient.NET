using System;
using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class Colony
    {
        /// <summary>
        /// last_update string
        /// </summary>
        [JsonProperty("last_update")]
        public DateTime LastUpdate { get; init; }

        /// <summary>
        /// num_pins integer
        /// </summary>
        [JsonProperty("num_pins")]
        public int NumberOfPins { get; init; }

        /// <summary>
        /// owner_id integer
        /// </summary>
        [JsonProperty("owner_id")]
        public int OwnerId { get; init; }

        /// <summary>
        /// planet_id integer
        /// </summary>
        [JsonProperty("planet_id")]
        public int PlanetId { get; init; }

        /// <summary>
        /// planet_type string
        /// </summary>
        [JsonProperty("planet_type")]
        public PlanetType PlanetType { get; init; }

        /// <summary>
        /// solar_system_id integer
        /// </summary>
        [JsonProperty("solar_system_id")]
        public int SolarSystemId { get; init; }

        /// <summary>
        /// upgrade_level integer
        /// </summary>
        [JsonProperty("upgrade_level")]
        public int UpgradeLevel { get; init; }
    }
}
