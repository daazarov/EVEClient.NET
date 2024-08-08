using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class CharacterTitle
    {
        /// <summary>
        /// name string
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; init; }

        /// <summary>
        /// title_id intege
        /// </summary>
        [JsonProperty("title_id")]
        public int? TitleId { get; init; }
    }
}
