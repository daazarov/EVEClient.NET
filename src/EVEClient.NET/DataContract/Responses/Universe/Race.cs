using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class Race
    {
        /// <summary>
        /// The alliance generally associated with this race
        /// </summary>
        [JsonProperty("alliance_id")]
        public required int AllianceId {  get; set; }

        /// <summary>
        /// description string
        /// </summary>
        [JsonProperty("description")]
        public required string Description { get; init; }

        /// <summary>
        /// name string
        /// </summary>
        [JsonProperty("name")]
        public required string Name { get; init; }

        /// <summary>
        /// race_id integer
        /// </summary>
        [JsonProperty("race_id")]
        public required int RaceId { get; init; }
    }
}
