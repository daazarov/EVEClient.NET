using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class FactionWar
    {
        /// <summary>
        /// The faction ID of the enemy faction.
        /// </summary>
        [JsonPropertyName("faction_id")]
        public required int FactionId { get; init; }

        /// <summary>
        /// faction_id integer
        /// </summary>
        [JsonPropertyName("against_id")]
        public required int AgainstId { get; init; }
    }
}
