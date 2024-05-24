using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class NamesLookup
    {
        /// <summary>
        /// id integer
        /// </summary>
        [JsonProperty("id")]
        public int ID { get; set; }

        /// <summary>
        /// name string
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// category string
        /// </summary>
        [JsonProperty("category")]
        public NameCategory Category { get; set; }
    }
}
