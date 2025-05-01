using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class NamesLookup
    {
        /// <summary>
        /// id integer
        /// </summary>
        [JsonPropertyName("id")]
        public required int ID { get; init; }

        /// <summary>
        /// name string
        /// </summary>
        [JsonPropertyName("name")]
        public required string Name { get; init; }

        /// <summary>
        /// category string
        /// </summary>
        [JsonPropertyName("category")]
        public required NameCategory Category { get; init; }
    }
}
