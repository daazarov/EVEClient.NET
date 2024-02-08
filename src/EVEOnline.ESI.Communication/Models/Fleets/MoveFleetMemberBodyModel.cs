using Newtonsoft.Json;

namespace EVEOnline.ESI.Communication.Models
{
    internal class MoveFleetMemberBodyModel
    {
        public MoveFleetMemberBodyModel(string role, long? squadId = null, long? wingId = null)
        {
            Role = role;
            SquadId = squadId;
            WingId = wingId;
        }

        [JsonProperty("role")]
        public string Role {  get; set; }

        [JsonProperty("squad_id")]
        public long? SquadId { get; set; }

        [JsonProperty("wing_id")]
        public long? WingId { get; set; }
    }
}
