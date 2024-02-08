﻿using EVEOnline.ESI.Communication.Attributes;

namespace EVEOnline.ESI.Communication.Models
{
    internal class FleetIdModel
    {
        public FleetIdModel(long fleetId)
        {
            FleetId = fleetId;
        }

        [RouteParameter("fleet_id")]
        public long FleetId { get; set; }
    }
}
