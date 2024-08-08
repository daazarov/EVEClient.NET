using System;
using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class CharacterFatigue
    {
        /// <summary>
        /// Character’s jump fatigue expiry
        /// </summary>
        [JsonProperty("jump_fatigue_expire_date")]
        public DateTime? JumpFatigueExpireDate { get; init; }

        /// <summary>
        /// Character’s last jump activation
        /// </summary>
        [JsonProperty("last_jump_date")]
        public DateTime? LastJumpDate { get; init; }

        /// <summary>
        /// Character’s last jump update
        /// </summary>
        [JsonProperty("last_update_date")]
        public DateTime? LastUpdateDate { get; init; }
    }
}
