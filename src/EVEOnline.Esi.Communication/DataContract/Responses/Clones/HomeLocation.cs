using Newtonsoft.Json;

namespace EVEOnline.Esi.Communication.DataContract
{
    public class HomeLocation
    {
        /// <summary>
        /// location_id integer
        /// </summary>
        [JsonProperty("location_id")]
        public long? LocationId { get; set; }

        /// <summary>
        /// location_type string
        /// </summary>
        [JsonProperty("location_type")]
        public CloneLocationType LocationType { get; set; }
    }
}
