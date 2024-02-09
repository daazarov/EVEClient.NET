using EVEOnline.ESI.Communication.DataContract;
using EVEOnline.ESI.Communication.Extensions;
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

        // If a character is invited with the fleet_commander role, neither wing_id or squad_id should be specified.
        // If a character is invited with the wing_commander role, only wing_id should be specified.
        // If a character is invited with the squad_commander role, both wing_id and squad_id should be specified.
        // If a character is invited with the squad_member role, wing_id and squad_id should either both be specified or not specified at all.
        // If they aren’t specified, the invited character will join any squad with available positions.
        public bool ShouldSerializeSquadId() // todo - make a test
        {
            if (Role.Equals(FleetRole.FleetCommander.ToEsiString(), System.StringComparison.OrdinalIgnoreCase))
            {
                return false;
            }
            if (Role.Equals(FleetRole.WingCommander.ToEsiString(), System.StringComparison.OrdinalIgnoreCase))
            {
                return false;
            }
            if (Role.Equals(FleetRole.SquadCommander.ToEsiString(), System.StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
            if (Role.Equals(FleetRole.SquadMember.ToEsiString(), System.StringComparison.OrdinalIgnoreCase) && SquadId.HasValue && WingId.HasValue)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ShouldSerializeWingId()
        {
            if (Role.Equals(FleetRole.FleetCommander.ToEsiString(), System.StringComparison.OrdinalIgnoreCase))
            {
                return false;
            }
            if (Role.Equals(FleetRole.WingCommander.ToEsiString(), System.StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
            if (Role.Equals(FleetRole.SquadCommander.ToEsiString(), System.StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
            if (Role.Equals(FleetRole.SquadMember.ToEsiString(), System.StringComparison.OrdinalIgnoreCase) && SquadId.HasValue && WingId.HasValue)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
