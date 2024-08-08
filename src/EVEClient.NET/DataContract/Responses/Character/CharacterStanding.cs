using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class CharacterStanding
    {
        /// <summary>
        /// from_id integer
        /// </summary>
        [JsonProperty("from_id")]
        public int FromId { get; init; }

        /// <summary>
        /// from_type string
        /// </summary>
        [JsonProperty("from_type")]
        public StandingType StandingType { get; init; }

        /// <summary>
        /// standing number
        /// </summary>
        [JsonProperty("standing")]
        public float Standing { get; init; }
    }
}
