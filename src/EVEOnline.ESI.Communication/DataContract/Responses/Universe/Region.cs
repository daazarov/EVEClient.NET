using Newtonsoft.Json;

namespace EVEOnline.ESI.Communication.DataContract
{
    public class Region
    {
        /// <summary>
        /// constellations array
        /// </summary>
        [JsonProperty("constellations")]
        public int[] constellations {  get; set; }

        /// <summary>
        /// description string
        /// </summary>
        [JsonProperty("description")]
        public string description { get; set; }

        /// <summary>
        /// name string
        /// </summary>
        [JsonProperty("name")]
        public string name { get; set; }

        /// <summary>
        /// region_id integer
        /// </summary>
        [JsonProperty("region_id")]
        public int region_id { get; set; }
    }
}
