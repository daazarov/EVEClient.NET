using EVEOnline.ESI.Communication.Attributes;

namespace EVEOnline.ESI.Communication.Models
{
    internal class FleetSquadUriModel
    {
        public FleetSquadUriModel(long fleetId, long squadId)
        {
            FleetId = fleetId;
            SquadId = squadId;
        }

        [PathParameter("fleet_id")]
        public long FleetId { get; set; }

        [PathParameter("squad_id")]
        public long SquadId { get; set; }
    }
}
