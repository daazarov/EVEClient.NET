using Newtonsoft.Json;

namespace EVEOnline.ESI.Communication.Models
{
    internal class InviteFleetMemberBodyModel
    {
        public InviteFleetMemberBodyModel(int characterId, string role, long? squadId = null, long? wingId = null)
        {
            CharacterId = characterId;
            Role = role;
            SquadId = squadId;
            WingId = wingId;
        }

        [JsonProperty("character_id")]
        public int CharacterId { get; set; }

        [JsonProperty("role")]
        public string Role {  get; set; }

        [JsonProperty("squad_id")]
        public long? SquadId { get; set; }

        [JsonProperty("wing_id")]
        public long? WingId { get; set; }
    }
}
