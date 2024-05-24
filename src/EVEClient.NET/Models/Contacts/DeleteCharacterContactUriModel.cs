using EVEClient.NET.Attributes;

namespace EVEClient.NET.Models
{
    internal class DeleteCharacterContactUriModel : CharacterIdModel
    {
        public DeleteCharacterContactUriModel(int characterId, int[] contactIds) : base(characterId)
        {
            ContactIds = contactIds;
        }

        [QueryParameter("contact_ids")]
        public int[] ContactIds { get; set; }
    }
}
