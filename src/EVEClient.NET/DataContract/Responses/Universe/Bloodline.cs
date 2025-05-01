using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class Bloodline
    {
        /// <summary>
        /// bloodline_id integer
        /// </summary>
        [JsonPropertyName("bloodline_id")]
        public required int BloodlineId { get; init; }

        /// <summary>
        /// charisma integer
        /// </summary>
        [JsonPropertyName("charisma")]
        public required int Charisma { get; init; }

        /// <summary>
        /// corporation_id integer
        /// </summary>
        [JsonPropertyName("corporation_id")]
        public required int CorporationId { get; init; }

        /// <summary>
        /// description string
        /// </summary>
        [JsonPropertyName("description")]
        public required string Description { get; init; }

        /// <summary>
        /// intelligence integer
        /// </summary>
        [JsonPropertyName("intelligence")]
        public required int Intelligence { get; init; }

        /// <summary>
        /// memory integer
        /// </summary>
        [JsonPropertyName("memory")]
        public required int Memory { get; init; }

        /// <summary>
        /// name string
        /// </summary>
        [JsonPropertyName("name")]
        public required string Name { get; init; }

        /// <summary>
        /// perception integer
        /// </summary>
        [JsonPropertyName("perception")]
        public required int Perception { get; init; }

        /// <summary>
        /// race_id integer
        /// </summary>
        [JsonPropertyName("race_id")]
        public required int RaceId { get; init; }

        /// <summary>
        /// ship_type_id integer
        /// </summary>
        [JsonPropertyName("ship_type_id")]
        public required int ShipTypeId { get; init; }

        /// <summary>
        /// willpower integer
        /// </summary>
        [JsonPropertyName("willpower")]
        public required int Willpower { get; init; }
    }
}
