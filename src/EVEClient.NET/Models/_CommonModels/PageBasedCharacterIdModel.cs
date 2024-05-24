using EVEClient.NET.Attributes;

namespace EVEClient.NET.Models
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
