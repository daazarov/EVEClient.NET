using EVEOnline.ESI.Communication.DataContract;
using EVEOnline.ESI.Communication.Extensions;
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

        //If a character is moved to the fleet_commander role, neither wing_id or squad_id should be specified.
        //If a character is moved to the wing_commander role, only wing_id should be specified.
        //If a character is moved to the squad_commander role, both wing_id and squad_id should be specified.
        //If a character is moved to the squad_member role, both wing_id and squad_id should be specified.

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

            return true;
        }

        public bool ShouldSerializeWingId()
        {
            if (Role.Equals(FleetRole.FleetCommander.ToEsiString(), System.StringComparison.OrdinalIgnoreCase))
            {
                return false;
            }

            return true;
        }
    }
}
