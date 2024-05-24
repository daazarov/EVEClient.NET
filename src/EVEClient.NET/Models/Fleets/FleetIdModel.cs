using EVEClient.NET.Attributes;

namespace EVEClient.NET.Models
{
    internal class FleetIdModel
    {
        public FleetIdModel(long fleetId)
        {
            FleetId = fleetId;
        }

        [PathParameter("fleet_id")]
        public long FleetId { get; set; }
    }
}
