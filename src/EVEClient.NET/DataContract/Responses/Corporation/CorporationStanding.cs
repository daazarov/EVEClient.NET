using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class CorporationStanding
    {
        /// <summary>
        /// from_id integer
        /// </summary>
        [JsonProperty("from_id")]
        public int FromId { get; set; }

        /// <summary>
        /// from_type string
        /// </summary>
        [JsonProperty("from_type")]
        public StandingType StandingType { get; set; }

        /// <summary>
        /// standing number
        /// </summary>
        [JsonProperty("standing")]
        public float Standing { get; set; }
    }
}
