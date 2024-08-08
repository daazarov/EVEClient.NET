using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class FactionWar
    {
        /// <summary>
        /// The faction ID of the enemy faction.
        /// </summary>
        [JsonProperty("faction_id")]
        public required int FactionId { get; init; }

        /// <summary>
        /// faction_id integer
        /// </summary>
        [JsonProperty("against_id")]
        public required int AgainstId { get; init; }
    }
}
