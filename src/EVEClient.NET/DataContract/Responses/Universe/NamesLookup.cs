using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class NamesLookup
    {
        /// <summary>
        /// id integer
        /// </summary>
        [JsonProperty("id")]
        public required int ID { get; init; }

        /// <summary>
        /// name string
        /// </summary>
        [JsonProperty("name")]
        public required string Name { get; init; }

        /// <summary>
        /// category string
        /// </summary>
        [JsonProperty("category")]
        public required NameCategory Category { get; init; }
    }
}
