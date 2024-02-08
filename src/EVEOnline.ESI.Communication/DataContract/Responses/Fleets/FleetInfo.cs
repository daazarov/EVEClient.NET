using Newtonsoft.Json;

namespace EVEOnline.ESI.Communication.DataContract
{
    public class FleetInfo
    {
        /// <summary>
        /// The character’s current fleet ID
        /// </summary>
        [JsonProperty("fleet_id")]
        public long FleetId { get; set; }

        /// <summary>
        /// Member’s role in fleet
        /// </summary>
        [JsonProperty("role")]
        public FleetRole Role { get; set; }

        /// <summary>
        /// ID of the squad the member is in. If not applicable, will be set to -
        /// </summary>
        [JsonProperty("squad_id")]
        public long SquadId { get; set; }

        /// <summary>
        /// ID of the wing the member is in. If not applicable, will be set to -1
        /// </summary>
        [JsonProperty("wing_id")]
        public long WingId { get; set; }
    }
}
