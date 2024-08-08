using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class Star
    {
        /// <summary>
        /// Age of star in years
        /// </summary>
        [JsonProperty("age")]
        public long Age { get; init; }

        /// <summary>
        /// luminosity number
        /// </summary>
        [JsonProperty("luminosity")]
        public float Luminosity { get; init; }

        /// <summary>
        /// name string
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; init; }

        /// <summary>
        /// radius integer
        /// </summary>
        [JsonProperty("radius")]
        public long Radius { get; init; }

        /// <summary>
        /// solar_system_id integer
        /// </summary>
        [JsonProperty("solar_system_id")]
        public int SolarSystemId { get; init; }

        /// <summary>
        /// spectral_class string
        /// </summary>
        [JsonProperty("spectral_class")]
        public string SpectralClass { get; init; }

        /// <summary>
        /// temperature integer
        /// </summary>
        [JsonProperty("temperature")]
        public int Temperature { get; init; }

        /// <summary>
        /// type_id integer
        /// </summary>
        [JsonProperty("type_id")]
        public int TypeId { get; init; }
    }
}
