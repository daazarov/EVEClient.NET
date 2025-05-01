using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class CharacterTitle
    {
        /// <summary>
        /// name string
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; init; }

        /// <summary>
        /// title_id intege
        /// </summary>
        [JsonPropertyName("title_id")]
        public int? TitleId { get; init; }
    }
}
