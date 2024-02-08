using EVEOnline.ESI.Communication.Attributes;

namespace EVEOnline.ESI.Communication.Models
{
    internal class AddUpdateCharacterContactUriModel : FleetIdModel
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
