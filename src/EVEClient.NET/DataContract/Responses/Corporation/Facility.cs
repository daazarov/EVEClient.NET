using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class Facility
    {
        /// <summary>
        /// facility_id integer
        /// </summary>
        [JsonProperty("facility_id")]
        public long facility_id { get; set; }

        /// <summary>
        /// system_id integer
        /// </summary>
        [JsonProperty("system_id")]
        public int system_id { get; set; }

        /// <summary>
        /// type_id integer
        /// </summary>
        [JsonProperty("type_id")]
        public int type_id { get; set; }
    }
}
