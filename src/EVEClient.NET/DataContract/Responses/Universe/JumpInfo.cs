using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class JumpInfo
    {
        /// <summary>
        /// ship_jumps integer
        /// </summary>
        [JsonPropertyName("ship_jumps")]
        public required int ShipJumps { get; init; }

        /// <summary>
        /// system_id integer
        /// </summary>
        [JsonPropertyName("system_id")]
        public required int SystemId { get; init; }
    }
}
