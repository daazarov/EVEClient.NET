using System.Collections.Generic;
using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class Leaderboards<T>
    {
        [JsonProperty("kills")]
        public Summary<T> Kills { get; init; }

        [JsonProperty("victory_points")]
        public Summary<T> VictoryPoints { get; init; }
    }

    public class Summary<T>
    {
        [JsonProperty("yesterday")]
        public List<T> Yesterday { get; init; }

        [JsonProperty("last_week")]
        public List<T> LastWeek { get; init; }

        [JsonProperty("active_total")]
        public List<T> ActiveTotal { get; init; }
    }

    public class FactionTotal
    {
        /// <summary>
        /// faction_id integer
        /// </summary>
        [JsonProperty("faction_id")]
        public int? FactionId { get; init; }

        /// <summary>
        /// Amount of kills
        /// </summary>
        [JsonProperty("amount")]
        public int? Amount { get; init; }
    }

    public class CorporationTotal
    {
        /// <summary>
        /// corporation_id integer
        /// </summary>
        [JsonProperty("corporation_id")]
        public int? CorporationId { get; init; }

        /// <summary>
        /// Amount of kills
        /// </summary>
        [JsonProperty("amount")]
        public int? Amount { get; init; }
    }

    public class CharacterTotal
    {
        /// <summary>
        /// character_id integer
        /// </summary>
        [JsonProperty("character_id")]
        public int? CharacterId { get; init; }

        /// <summary>
        /// Amount of kills
        /// </summary>
        [JsonProperty("amount")]
        public int? Amount { get; init; }
    }
}
