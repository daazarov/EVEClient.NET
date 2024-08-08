using EVEClient.NET.Attributes;

namespace EVEClient.NET.Models
{
    internal class PageBasedCharacterIdModel
    {
        public PageBasedCharacterIdModel(int characterId, int page)
        {
            CharacterId = characterId;
            Page = page;
        }

        [QueryParameter("page")]
        public int Page { get; set; }

        [PathParameter("character_id")]
        public int CharacterId { get; set; }
    }
}
