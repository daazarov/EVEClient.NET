using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class Race
    {
        /// <summary>
        /// The alliance generally associated with this race
        /// </summary>
        [JsonPropertyName("alliance_id")]
        public required int AllianceId { get; init; }

        /// <summary>
        /// description string
        /// </summary>
        [JsonPropertyName("description")]
        public required string Description { get; init; }

        /// <summary>
        /// name string
        /// </summary>
        [JsonPropertyName("name")]
        public required string Name { get; init; }

        /// <summary>
        /// race_id integer
        /// </summary>
        [JsonPropertyName("race_id")]
        public required int RaceId { get; init; }
    }
}
