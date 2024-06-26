﻿using EVEClient.NET.Attributes;

namespace EVEClient.NET.Models
{
    internal class AllianceIdModel
    {
        public AllianceIdModel(int allianceId)
        {
            AllianceId = allianceId;
        }

        [PathParameter("alliance_id")]
        public int AllianceId { get; set; }
    }
}
