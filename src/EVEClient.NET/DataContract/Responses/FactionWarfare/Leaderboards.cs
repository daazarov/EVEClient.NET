using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class Leaderboards<T>
    {
        [JsonPropertyName("kills")]
        public required Summary<T> Kills { get; init; }

        [JsonPropertyName("victory_points")]
        public required Summary<T> VictoryPoints { get; init; }
    }

    public class Summary<T>
    {
        [JsonPropertyName("yesterday")]
        public required List<T> Yesterday { get; init; }

        [JsonPropertyName("last_week")]
        public required List<T> LastWeek { get; init; }

        [JsonPropertyName("active_total")]
        public required List<T> ActiveTotal { get; init; }
    }

    public class FactionTotal
    {
        /// <summary>
        /// faction_id integer
        /// </summary>
        [JsonPropertyName("faction_id")]
        public int? FactionId { get; init; }

        /// <summary>
        /// Amount of kills
        /// </summary>
        [JsonPropertyName("amount")]
        public int? Amount { get; init; }
    }

    public class CorporationTotal
    {
        /// <summary>
        /// corporation_id integer
        /// </summary>
        [JsonPropertyName("corporation_id")]
        public int? CorporationId { get; init; }

        /// <summary>
        /// Amount of kills
        /// </summary>
        [JsonPropertyName("amount")]
        public int? Amount { get; init; }
    }

    public class CharacterTotal
    {
        /// <summary>
        /// character_id integer
        /// </summary>
        [JsonPropertyName("character_id")]
        public int? CharacterId { get; init; }

        /// <summary>
        /// Amount of kills
        /// </summary>
        [JsonPropertyName("amount")]
        public int? Amount { get; init; }
    }
}
