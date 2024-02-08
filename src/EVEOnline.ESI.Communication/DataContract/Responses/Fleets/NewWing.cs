using Newtonsoft.Json;

namespace EVEOnline.ESI.Communication.DataContract
{
    public class NewWing
    {
        /// <summary>
        /// The wing_id of the newly created wing
        /// </summary>
        [JsonProperty("wing_id")]
        public long WingId { get; set; }
    }
}
