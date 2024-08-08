using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class FleetSettings
    {
        /// <summary>
        /// Is free-move enabled
        /// </summary>
        [JsonProperty("is_free_move")]
        public required bool IsFreeMove {  get; set; }

        /// <summary>
        /// Does the fleet have an active fleet advertisement
        /// </summary>
        [JsonProperty("is_registered")]
        public required bool IsRegistered { get; init; }

        /// <summary>
        /// Is EVE Voice enabled
        /// </summary>
        [JsonProperty("is_voice_enabled")]
        public required bool IsVoiceEnabled { get; init; }

        /// <summary>
        /// Fleet MOTD in CCP flavoured HTML
        /// </summary>
        [JsonProperty("motd")]
        public required string Motd {  get; set; }
    }
}
