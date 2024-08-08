using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class ContactLabel
    {
        /// <summary>
        /// label_id integer
        /// </summary>
        [JsonProperty("label_id")]
        public required long LabelId { get; init; }

        /// <summary>
        /// label_name string
        /// </summary>
        [JsonProperty("label_name")]
        public required string LabelName { get; init; }
    }
}
