using EVEOnline.ESI.Communication.Attributes;

namespace EVEOnline.ESI.Communication.Models
{
    internal class CharacterIdModel
    {
        public CharacterIdModel(int characterId)
        {
            CharacterId = characterId;
        }

        [PathParameter("character_id")]
        public int CharacterId { get; set; }
    }
}
