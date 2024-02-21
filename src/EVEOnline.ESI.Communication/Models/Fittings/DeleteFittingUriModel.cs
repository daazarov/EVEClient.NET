﻿using EVEOnline.ESI.Communication.Attributes;

namespace EVEOnline.ESI.Communication.Models
{
    internal class DeleteFittingUriModel
    {
        public DeleteFittingUriModel(int characterId, int fittingId)
        {
            CharacterId = characterId;
            FittingId = fittingId;
        }

        [PathParameter("character_id")]
        public int CharacterId { get; set; }

        [PathParameter("fitting_id")]
        public int FittingId { get; set;}
    }
}
