﻿using EVEOnline.ESI.Communication.Attributes;

namespace EVEOnline.ESI.Communication.Models
{
    internal class PageBasedCharacterIdModel : CharacterIdModel
    {
        public PageBasedCharacterIdModel(int characterId, int page) : base(characterId)
        {
            Page = page;
        }

        [QueryParameter("page")]
        public int Page { get; set; }
    }
}