using Newtonsoft.Json;

namespace EVEOnline.ESI.Communication.DataContract
{
    public class JumpInfo
    {
        /// <summary>
        /// ship_jumps integer
        /// </summary>
        [JsonProperty("ship_jumps")]
        public int ShipJumps {  get; set; }

        /// <summary>
        /// system_id integer
        /// </summary>
        [JsonProperty("system_id")]
        public int SystemId { get; set; }
    }
}
