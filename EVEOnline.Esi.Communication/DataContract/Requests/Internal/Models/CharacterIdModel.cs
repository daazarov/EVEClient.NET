using EVEOnline.Esi.Communication.Attributes;

namespace EVEOnline.Esi.Communication.DataContract
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
