using EVEOnline.ESI.Communication.Attributes;

namespace EVEOnline.ESI.Communication.Models
{
    internal class SearchQueryUriModel
    {
        public SearchQueryUriModel(int characterId, string search, string categories, bool strict)
        {
            CharacterId = characterId;
            Search = search;
            Categories = categories;
            Strict = strict;
        }

        [PathParameter("character_id")]
        public int CharacterId {  get; set; }

        [QueryParameter("search")]
        public string Search { get; set; }

        [QueryParameter("categories")]
        public string Categories { get; set; }

        [QueryParameter("strict")]
        public bool Strict { get; set; }
    }
}
