using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class FleetSettings
    {
        /// <summary>
        /// Is free-move enabled
        /// </summary>
        [JsonProperty("is_free_move")]
        public bool IsFreeMove {  get; set; }

        /// <summary>
        /// Does the fleet have an active fleet advertisement
        /// </summary>
        [JsonProperty("is_registered")]
        public bool IsRegistered { get; set; }

        /// <summary>
        /// Is EVE Voice enabled
        /// </summary>
        [JsonProperty("is_voice_enabled")]
        public bool IsVoiceEnabled { get; set; }

        /// <summary>
        /// Fleet MOTD in CCP flavoured HTML
        /// </summary>
        [JsonProperty("motd")]
        public string Motd {  get; set; }
    }
}
