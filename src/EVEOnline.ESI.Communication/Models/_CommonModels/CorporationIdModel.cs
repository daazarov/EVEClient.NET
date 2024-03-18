﻿using EVEOnline.ESI.Communication.Attributes;

namespace EVEOnline.ESI.Communication.Models
{
    internal class CorporationIdModel
    {
        public CorporationIdModel(int corporationId)
        {
            CorporationId = corporationId;
        }

        [PathParameter("corporation_id")]
        public int CorporationId { get; set; }
    }
}