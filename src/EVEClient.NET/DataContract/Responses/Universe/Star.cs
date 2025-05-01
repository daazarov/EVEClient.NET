using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class Star
    {
        /// <summary>
        /// Age of star in years
        /// </summary>
        [JsonPropertyName("age")]
        public required long Age { get; init; }

        /// <summary>
        /// luminosity number
        /// </summary>
        [JsonPropertyName("luminosity")]
        public required float Luminosity { get; init; }

        /// <summary>
        /// name string
        /// </summary>
        [JsonPropertyName("name")]
        public required string Name { get; init; }

        /// <summary>
        /// radius integer
        /// </summary>
        [JsonPropertyName("radius")]
        public required long Radius { get; init; }

        /// <summary>
        /// solar_system_id integer
        /// </summary>
        [JsonPropertyName("solar_system_id")]
        public required int SolarSystemId { get; init; }

        /// <summary>
        /// spectral_class string
        /// </summary>
        [JsonPropertyName("spectral_class")]
        public required string SpectralClass { get; init; }

        /// <summary>
        /// temperature integer
        /// </summary>
        [JsonPropertyName("temperature")]
        public required int Temperature { get; init; }

        /// <summary>
        /// type_id integer
        /// </summary>
        [JsonPropertyName("type_id")]
        public required int TypeId { get; init; }
    }
}
