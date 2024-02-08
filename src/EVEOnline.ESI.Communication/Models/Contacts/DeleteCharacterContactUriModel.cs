using EVEOnline.ESI.Communication.Attributes;

namespace EVEOnline.ESI.Communication.Models
{
    internal class DeleteCharacterContactUriModel : FleetIdModel
    {
        public DeleteCharacterContactUriModel(int characterId, int[] contactIds) : base(characterId)
        {
            ContactIds = contactIds;
        }

        [QueryParameter("contact_ids")]
        public int[] ContactIds { get; set; }
    }
}
