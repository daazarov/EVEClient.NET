using EVEOnline.Esi.Communication.Attributes;

namespace EVEOnline.Esi.Communication.DataContract.Requests.Internal
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
