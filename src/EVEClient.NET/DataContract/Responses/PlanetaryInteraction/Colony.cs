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
        public DateTime LastUpdate { get; set; }

        /// <summary>
        /// num_pins integer
        /// </summary>
        [JsonProperty("num_pins")]
        public int NumberOfPins { get; set; }

        /// <summary>
        /// owner_id integer
        /// </summary>
        [JsonProperty("owner_id")]
        public int OwnerId { get; set; }

        /// <summary>
        /// planet_id integer
        /// </summary>
        [JsonProperty("planet_id")]
        public int PlanetId { get; set; }

        /// <summary>
        /// planet_type string
        /// </summary>
        [JsonProperty("planet_type")]
        public PlanetType PlanetType { get; set; }

        /// <summary>
        /// solar_system_id integer
        /// </summary>
        [JsonProperty("solar_system_id")]
        public int SolarSystemId { get; set; }

        /// <summary>
        /// upgrade_level integer
        /// </summary>
        [JsonProperty("upgrade_level")]
        public int UpgradeLevel { get; set; }
    }
}
