using Newtonsoft.Json;

namespace EVEOnline.ESI.Communication.DataContract
{
    public class ContactLabel
    {
        /// <summary>
        /// label_id integer
        /// </summary>
        [JsonProperty("label_id")]
        public long LabelId { get; set; }

        /// <summary>
        /// label_name string
        /// </summary>
        [JsonProperty("label_name")]
        public string LabelName { get; set; }
    }
}
