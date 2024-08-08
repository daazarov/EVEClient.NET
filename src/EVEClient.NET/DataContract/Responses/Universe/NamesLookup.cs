using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class NamesLookup
    {
        /// <summary>
        /// id integer
        /// </summary>
        [JsonProperty("id")]
        public int ID { get; init; }

        /// <summary>
        /// name string
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; init; }

        /// <summary>
        /// category string
        /// </summary>
        [JsonProperty("category")]
        public NameCategory Category { get; init; }
    }
}
