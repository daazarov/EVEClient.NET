using Newtonsoft.Json;

namespace EVEOnline.ESI.Communication.DataContract
{
    public class Star
    {
        /// <summary>
        /// Age of star in years
        /// </summary>
        [JsonProperty("age")]
        public long Age {  get; set; }

        /// <summary>
        /// luminosity number
        /// </summary>
        [JsonProperty("luminosity")]
        public float Luminosity { get; set; }

        /// <summary>
        /// name string
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// radius integer
        /// </summary>
        [JsonProperty("radius")]
        public long Radius { get; set; }

        /// <summary>
        /// solar_system_id integer
        /// </summary>
        [JsonProperty("solar_system_id")]
        public int SolarSystemId { get; set; }

        /// <summary>
        /// spectral_class string
        /// </summary>
        [JsonProperty("spectral_class")]
        public string SpectralClass {  get; set; }

        /// <summary>
        /// temperature integer
        /// </summary>
        [JsonProperty("temperature")]
        public int Temperature { get; set; }

        /// <summary>
        /// type_id integer
        /// </summary>
        [JsonProperty("type_id")]
        public int TypeId { get; set; }
    }
}
