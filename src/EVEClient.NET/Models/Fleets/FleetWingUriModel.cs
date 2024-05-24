using EVEClient.NET.Attributes;

namespace EVEClient.NET.Models
{
    internal class FleetWingUriModel
    {
        public FleetWingUriModel(long fleetId, long wingId)
        {
            FleetId = fleetId;
            WingId = wingId;
        }

        [PathParameter("fleet_id")]
        public long FleetId { get; set; }

        [PathParameter("wing_id")]
        public long WingId { get; set; }
    }
}
