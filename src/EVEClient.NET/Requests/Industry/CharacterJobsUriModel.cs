using EVEClient.NET.Attributes;

namespace EVEClient.NET.Models
{
    internal class CharacterJobsUriModel
    {
        public CharacterJobsUriModel(int characterId, bool includeCompleted)
        {
            CharacterId = characterId;
            IncludeCompleted = includeCompleted;
        }

        [PathParameter("character_id")]
        public int CharacterId { get; set; }

        [QueryParameter("include_completed")]
        public bool IncludeCompleted { get; set; }
    }
}
