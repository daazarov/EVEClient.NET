using EVEOnline.ESI.Communication.Attributes;

namespace EVEOnline.ESI.Communication.Models
{
    internal class FleetMemberUriModel
    {
        public FleetMemberUriModel(long fleetId, int memberId)
        {
            FleetId = fleetId;
            MemberId = memberId;
        }

        [PathParameter("fleet_id")]
        public long FleetId { get; set; }

        [PathParameter("member_id")]
        public int MemberId { get; set; }
    }
}
