﻿using EVEOnline.ESI.Communication.Attributes;

namespace EVEOnline.ESI.Communication.Models
{
    internal class StarbaseInfoUriModel
    {
        public StarbaseInfoUriModel(int corporationId, long starbaseId, int systemId)
        { 
            CorporationId = corporationId;
            StarbaseId = starbaseId;
            SystemId = systemId;
        }

        [RouteParameter("corporation_id")]
        public int CorporationId { get; set; }

        [RouteParameter("starbase_id ")]
        public long StarbaseId { get; set; }

        [QueryParameter("system_id ")]
        public int SystemId { get; set; }
    }
}