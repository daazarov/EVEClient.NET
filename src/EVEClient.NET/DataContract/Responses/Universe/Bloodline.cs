using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class Bloodline
    {
        /// <summary>
        /// bloodline_id integer
        /// </summary>
        [JsonProperty("bloodline_id")]
        public required int BloodlineId { get; init; }

        /// <summary>
        /// charisma integer
        /// </summary>
        [JsonProperty("charisma")]
        public required int Charisma { get; init; }

        /// <summary>
        /// corporation_id integer
        /// </summary>
        [JsonProperty("corporation_id")]
        public required int CorporationId { get; init; }

        /// <summary>
        /// description string
        /// </summary>
        [JsonProperty("description")]
        public required string Description { get; init; }

        /// <summary>
        /// intelligence integer
        /// </summary>
        [JsonProperty("intelligence")]
        public required int Intelligence { get; init; }

        /// <summary>
        /// memory integer
        /// </summary>
        [JsonProperty("memory")]
        public required int Memory { get; init; }

        /// <summary>
        /// name string
        /// </summary>
        [JsonProperty("name")]
        public required string Name { get; init; }

        /// <summary>
        /// perception integer
        /// </summary>
        [JsonProperty("perception")]
        public required int Perception { get; init; }

        /// <summary>
        /// race_id integer
        /// </summary>
        [JsonProperty("race_id")]
        public required int RaceId { get; init; }

        /// <summary>
        /// ship_type_id integer
        /// </summary>
        [JsonProperty("ship_type_id")]
        public required int ShipTypeId { get; init; }

        /// <summary>
        /// willpower integer
        /// </summary>
        [JsonProperty("willpower")]
        public required int Willpower { get; init; }
    }
}
