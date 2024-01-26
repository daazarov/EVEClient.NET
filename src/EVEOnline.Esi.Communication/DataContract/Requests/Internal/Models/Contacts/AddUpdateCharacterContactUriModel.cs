using EVEOnline.Esi.Communication.Attributes;

namespace EVEOnline.Esi.Communication.DataContract.Requests.Internal
{
    internal class AddUpdateCharacterContactUriModel : CharacterIdModel
    {
        public AddUpdateCharacterContactUriModel(int characterId, float standing, int[] labelIds, bool watched)
            : base(characterId)
        {
            LabelIds = labelIds;
            Standing = standing;
            Watched = watched;
        }

        [QueryParameter("label_ids")]
        public int[] LabelIds { get; set; }

        [QueryParameter("standing")]
        public float Standing {  get; set; }

        [QueryParameter("watched")]
        public bool Watched { get; set; }
    }
}
