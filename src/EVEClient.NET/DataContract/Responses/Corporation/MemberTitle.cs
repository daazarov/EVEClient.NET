using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class MemberTitle
    {
        /// <summary>
        /// character_id integer
        /// </summary>
        [JsonPropertyName("character_id")]
        public required int CharacterId { get; init; }

        /// <summary>
        /// A list of title_id
        /// </summary>
        [JsonPropertyName("titles")]
        public required int[] Titles { get; init; }
    }
}
