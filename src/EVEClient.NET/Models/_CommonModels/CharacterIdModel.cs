using EVEClient.NET.Attributes;

namespace EVEClient.NET.Models
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
