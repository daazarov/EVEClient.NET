using EVEOnline.Esi.Communication.Attributes;

namespace EVEOnline.Esi.Communication.DataContract.Requests.Internal
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
