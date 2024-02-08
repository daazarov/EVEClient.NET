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

        [RouteParameter("fleet_id")]
        public long FleetId { get; set; }

        [RouteParameter("squad_id")]
        public long SquadId { get; set; }
    }
}
