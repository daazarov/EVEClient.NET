using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class JumpInfo
    {
        /// <summary>
        /// ship_jumps integer
        /// </summary>
        [JsonProperty("ship_jumps")]
        public int ShipJumps { get; init; }

        /// <summary>
        /// system_id integer
        /// </summary>
        [JsonProperty("system_id")]
        public int SystemId { get; init; }
    }
}
