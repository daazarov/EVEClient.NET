using EVEOnline.Esi.Communication.Attributes;

namespace EVEOnline.Esi.Communication.DataContract.Requests.Internal
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
