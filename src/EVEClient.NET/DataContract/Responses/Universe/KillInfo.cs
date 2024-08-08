using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class KillInfo
    {
        /// <summary>
        /// Number of NPC ships killed in this system
        /// </summary>
        [JsonProperty("npc_kills")]
        public int NpcKills { get; init; }

        /// <summary>
        /// Number of pods killed in this system
        /// </summary>
        [JsonProperty("pod_kills")]
        public int PodKills { get; init; }

        /// <summary>
        /// Number of player ships killed in this system
        /// </summary>
        [JsonProperty("ship_kills")]
        public int ShipKills { get; init; }

        /// <summary>
        /// system_id integer
        /// </summary>
        [JsonProperty("system_id")]
        public int SystemId { get; init; }
    }
}
