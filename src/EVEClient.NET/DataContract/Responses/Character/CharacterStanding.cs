using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class CharacterStanding
    {
        /// <summary>
        /// from_id integer
        /// </summary>
        [JsonProperty("from_id")]
        public required int FromId { get; init; }

        /// <summary>
        /// from_type string
        /// </summary>
        [JsonProperty("from_type")]
        public required StandingType StandingType { get; init; }

        /// <summary>
        /// standing number
        /// </summary>
        [JsonProperty("standing")]
        public required float Standing { get; init; }
    }
}
