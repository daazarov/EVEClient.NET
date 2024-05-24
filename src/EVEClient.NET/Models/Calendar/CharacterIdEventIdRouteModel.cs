using EVEClient.NET.Attributes;

namespace EVEClient.NET.Models
{
    internal class CharacterIdEventIdRouteModel : CharacterIdModel
    {
        public CharacterIdEventIdRouteModel(int characterId, int eventId) : base(characterId)
        { 
            EventId = eventId;
        }

        [PathParameter("event_id")]
        public int EventId { get; set; }
    }
}
