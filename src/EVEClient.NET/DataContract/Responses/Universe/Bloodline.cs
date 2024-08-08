using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class Bloodline
    {
        /// <summary>
        /// bloodline_id integer
        /// </summary>
        [JsonProperty("bloodline_id")]
        public int BloodlineId { get; init; }

        /// <summary>
        /// charisma integer
        /// </summary>
        [JsonProperty("charisma")]
        public int Charisma { get; init; }

        /// <summary>
        /// corporation_id integer
        /// </summary>
        [JsonProperty("corporation_id")]
        public int CorporationId { get; init; }

        /// <summary>
        /// description string
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; init; }

        /// <summary>
        /// intelligence integer
        /// </summary>
        [JsonProperty("intelligence")]
        public int Intelligence { get; init; }

        /// <summary>
        /// memory integer
        /// </summary>
        [JsonProperty("memory")]
        public int Memory { get; init; }

        /// <summary>
        /// name string
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; init; }

        /// <summary>
        /// perception integer
        /// </summary>
        [JsonProperty("perception")]
        public int Perception { get; init; }

        /// <summary>
        /// race_id integer
        /// </summary>
        [JsonProperty("race_id")]
        public int RaceId { get; init; }

        /// <summary>
        /// ship_type_id integer
        /// </summary>
        [JsonProperty("ship_type_id")]
        public int ShipTypeId { get; init; }

        /// <summary>
        /// willpower integer
        /// </summary>
        [JsonProperty("willpower")]
        public int Willpower { get; init; }
    }
}
