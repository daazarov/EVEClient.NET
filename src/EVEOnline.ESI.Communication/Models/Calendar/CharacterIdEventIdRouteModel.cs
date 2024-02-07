using EVEOnline.ESI.Communication.Attributes;

namespace EVEOnline.ESI.Communication.Models
{
    internal class CharacterIdEventIdRouteModel : CharacterIdModel
    {
        public CharacterIdEventIdRouteModel(int characterId, int eventId) : base(characterId)
        { 
            EventId = eventId;
        }

        [RouteParameter("event_id")]
        public int EventId { get; set; }
    }
}
