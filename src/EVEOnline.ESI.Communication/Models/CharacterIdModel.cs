using EVEOnline.ESI.Communication.Attributes;

namespace EVEOnline.ESI.Communication.Models
{
    internal class CharacterIdModel
    {
        public CharacterIdModel(int characterId)
        {
            CharacterId = characterId;
        }

        [RouteParameter("character_id")]
        public int CharacterId { get; set; }
    }
}
