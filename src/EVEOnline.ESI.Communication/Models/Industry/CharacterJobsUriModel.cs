using EVEOnline.ESI.Communication.Attributes;

namespace EVEOnline.ESI.Communication.Models
{
    internal class CharacterJobsUriModel
    {
        public CharacterJobsUriModel(int characterId, bool includeCompleted)
        {
            CharacterId = characterId;
            IncludeCompleted = includeCompleted;
        }

        [RouteParameter("character_id")]
        public int CharacterId { get; set; }

        [QueryParameter("include_completed")]
        public bool IncludeCompleted { get; set; }
    }
}
