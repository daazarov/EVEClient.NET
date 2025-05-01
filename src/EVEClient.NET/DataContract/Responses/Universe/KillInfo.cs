using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class KillInfo
    {
        /// <summary>
        /// Number of NPC ships killed in this system
        /// </summary>
        [JsonPropertyName("npc_kills")]
        public required int NpcKills { get; init; }

        /// <summary>
        /// Number of pods killed in this system
        /// </summary>
        [JsonPropertyName("pod_kills")]
        public required int PodKills { get; init; }

        /// <summary>
        /// Number of player ships killed in this system
        /// </summary>
        [JsonPropertyName("ship_kills")]
        public required int ShipKills { get; init; }

        /// <summary>
        /// system_id integer
        /// </summary>
        [JsonPropertyName("system_id")]
        public required int SystemId { get; init; }
    }
}
