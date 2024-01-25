using EVEOnline.Esi.Communication.Attributes;

namespace EVEOnline.Esi.Communication.DataContract.Requests.Internal
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
