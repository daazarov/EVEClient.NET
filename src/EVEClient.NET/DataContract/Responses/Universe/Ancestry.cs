using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class Ancestry
    {
        /// <summary>
        /// The bloodline associated with this ancestry
        /// </summary>
        [JsonProperty("bloodline_id")]
        public int BloodlineId { get; init; }

        /// <summary>
        /// description string
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; init; }

        /// <summary>
        /// icon_id integer
        /// </summary>
        [JsonProperty("icon_id")]
        public int? IconId { get; init; }

        /// <summary>
        /// id integer
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; init; }

        /// <summary>
        /// name string
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; init; }

        /// <summary>
        /// short_description string
        /// </summary>
        [JsonProperty("short_description")]
        public string? ShortDescription { get; init; }
    }
}
