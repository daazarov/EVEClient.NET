using EVEOnline.Esi.Communication.Attributes;

namespace EVEOnline.Esi.Communication.DataContract.Requests.Internal
{
    internal class SummaryCalendarEventsUriModel : CharacterIdModel
    {
        public SummaryCalendarEventsUriModel(int characterId, int? eventId) : base(characterId)
        {
            FromEventId = eventId;
        }

        [QueryParameter("from_event")]
        public int? FromEventId { get; set; }
    }
}
