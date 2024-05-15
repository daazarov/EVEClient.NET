using EVEOnline.ESI.Communication.Attributes;

namespace EVEOnline.ESI.Communication.Models
{
    internal class SetAutopilotWaypointModel
    {
        public SetAutopilotWaypointModel(long destinationId, bool addToBeginning, bool clearOtherWaypoints)
        {
            DestinationId = destinationId;
            AddToBeginning = addToBeginning;
            ClearOtherWaypoints = clearOtherWaypoints;
        }

        [QueryParameter("destination_id")]
        public long DestinationId {  get; set; }

        [QueryParameter("add_to_beginning")]
        public bool AddToBeginning { get; set; }

        [QueryParameter("clear_other_waypoints")]
        public bool ClearOtherWaypoints { get; set; }
    }
}
