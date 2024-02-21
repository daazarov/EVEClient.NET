﻿using EVEOnline.ESI.Communication.Attributes;

namespace EVEOnline.ESI.Communication.Models
{
    internal class DeleteLabelUriModel
    {
        public DeleteLabelUriModel(int characterId, int labelId)
        {
            CharacterId = characterId;
            LabelId = labelId;
        }

        [PathParameter("character_id")]
        public int CharacterId { get; private set; }

        [QueryParameter("label_id")]
        public int LabelId { get; private set; }
    }
}
