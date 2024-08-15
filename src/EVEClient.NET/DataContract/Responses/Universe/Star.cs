using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class Star
    {
        /// <summary>
        /// Age of star in years
        /// </summary>
        [JsonProperty("age")]
        public required long Age { get; init; }

        /// <summary>
        /// luminosity number
        /// </summary>
        [JsonProperty("luminosity")]
        public required float Luminosity { get; init; }

        /// <summary>
        /// name string
        /// </summary>
        [JsonProperty("name")]
        public required string Name { get; init; }

        /// <summary>
        /// radius integer
        /// </summary>
        [JsonProperty("radius")]
        public required long Radius { get; init; }

        /// <summary>
        /// solar_system_id integer
        /// </summary>
        [JsonProperty("solar_system_id")]
        public required int SolarSystemId { get; init; }

        /// <summary>
        /// spectral_class string
        /// </summary>
        [JsonProperty("spectral_class")]
        public required string SpectralClass { get; init; }

        /// <summary>
        /// temperature integer
        /// </summary>
        [JsonProperty("temperature")]
        public required int Temperature { get; init; }

        /// <summary>
        /// type_id integer
        /// </summary>
        [JsonProperty("type_id")]
        public required int TypeId { get; init; }
    }
}
