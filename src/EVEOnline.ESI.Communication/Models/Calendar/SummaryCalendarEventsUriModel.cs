using EVEOnline.ESI.Communication.Attributes;

namespace EVEOnline.ESI.Communication.Models
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
