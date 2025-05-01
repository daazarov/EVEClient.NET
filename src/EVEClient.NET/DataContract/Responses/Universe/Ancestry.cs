using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class Ancestry
    {
        /// <summary>
        /// The bloodline associated with this ancestry
        /// </summary>
        [JsonPropertyName("bloodline_id")]
        public required int BloodlineId { get; init; }

        /// <summary>
        /// description string
        /// </summary>
        [JsonPropertyName("description")]
        public required string Description { get; init; }

        /// <summary>
        /// icon_id integer
        /// </summary>
        [JsonPropertyName("icon_id")]
        public int? IconId { get; init; }

        /// <summary>
        /// id integer
        /// </summary>
        [JsonPropertyName("id")]
        public required int Id { get; init; }

        /// <summary>
        /// name string
        /// </summary>
        [JsonPropertyName("name")]
        public required string Name { get; init; }

        /// <summary>
        /// short_description string
        /// </summary>
        [JsonPropertyName("short_description")]
        public string? ShortDescription { get; init; }
    }
}
