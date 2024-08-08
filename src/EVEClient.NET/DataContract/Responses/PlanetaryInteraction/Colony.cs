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
        public required DateTime LastUpdate { get; init; }

        /// <summary>
        /// num_pins integer
        /// </summary>
        [JsonProperty("num_pins")]
        public required int NumberOfPins { get; init; }

        /// <summary>
        /// owner_id integer
        /// </summary>
        [JsonProperty("owner_id")]
        public required int OwnerId { get; init; }

        /// <summary>
        /// planet_id integer
        /// </summary>
        [JsonProperty("planet_id")]
        public required int PlanetId { get; init; }

        /// <summary>
        /// planet_type string
        /// </summary>
        [JsonProperty("planet_type")]
        public required PlanetType PlanetType { get; init; }

        /// <summary>
        /// solar_system_id integer
        /// </summary>
        [JsonProperty("solar_system_id")]
        public required int SolarSystemId { get; init; }

        /// <summary>
        /// upgrade_level integer
        /// </summary>
        [JsonProperty("upgrade_level")]
        public required int UpgradeLevel { get; init; }
    }
}
