using System;
using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class CharacterFatigue
    {
        /// <summary>
        /// Character’s jump fatigue expiry
        /// </summary>
        [JsonPropertyName("jump_fatigue_expire_date")]
        public DateTime? JumpFatigueExpireDate { get; init; }

        /// <summary>
        /// Character’s last jump activation
        /// </summary>
        [JsonPropertyName("last_jump_date")]
        public DateTime? LastJumpDate { get; init; }

        /// <summary>
        /// Character’s last jump update
        /// </summary>
        [JsonPropertyName("last_update_date")]
        public DateTime? LastUpdateDate { get; init; }
    }
}
