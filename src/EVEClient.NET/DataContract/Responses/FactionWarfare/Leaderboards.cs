using System.Collections.Generic;
using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class Leaderboards<T>
    {
        [JsonProperty("kills")]
        public Summary<T> Kills { get; set; }

        [JsonProperty("victory_points")]
        public Summary<T> VictoryPoints { get; set; }
    }

    public class Summary<T>
    {
        [JsonProperty("yesterday")]
        public List<T> Yesterday { get; set; } = new List<T>();

        [JsonProperty("last_week")]
        public List<T> LastWeek { get; set; } = new List<T>();

        [JsonProperty("active_total")]
        public List<T> ActiveTotal { get; set; } = new List<T>();
    }

    public class FactionTotal
    {
        /// <summary>
        /// faction_id integer
        /// </summary>
        [JsonProperty("faction_id")]
        public int FactionId { get; set; }

        /// <summary>
        /// Amount of kills
        /// </summary>
        [JsonProperty("amount")]
        public int Amount { get; set; }
    }

    public class CorporationTotal
    {
        /// <summary>
        /// corporation_id integer
        /// </summary>
        [JsonProperty("corporation_id")]
        public int CorporationId { get; set; }

        /// <summary>
        /// Amount of kills
        /// </summary>
        [JsonProperty("amount")]
        public int Amount { get; set; }
    }

    public class CharacterTotal
    {
        /// <summary>
        /// character_id integer
        /// </summary>
        [JsonProperty("character_id")]
        public int CharacterId { get; set; }

        /// <summary>
        /// Amount of kills
        /// </summary>
        [JsonProperty("amount")]
        public int Amount { get; set; }
    }
}
