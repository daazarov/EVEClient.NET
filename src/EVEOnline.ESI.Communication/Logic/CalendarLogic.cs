using System.Collections.Generic;
using System.Threading.Tasks;

using EVEOnline.ESI.Communication.DataContract;
using EVEOnline.ESI.Communication.Extensions;

using static EVEOnline.ESI.Communication.Models.CalendarRequests;

namespace EVEOnline.ESI.Communication.Logic
{
    internal class CalendarLogic : ICalendarLogic
    {
        private readonly IEsiHttpClient<ICalendarLogic> _esiClient;

        public CalendarLogic(IEsiHttpClient<ICalendarLogic> esiClient)
        {
            _esiClient = esiClient;
        }

        public Task<EsiResponse<List<Attendee>>> EventAttendees(int characterId, int eventId) =>
            _esiClient.GetRequestAsync<CalendarEventAttendeesRequest, List<Attendee>>(CalendarEventAttendeesRequest.Create(characterId, eventId));

        public Task<EsiResponse<CharacterCalendarEvent>> CalendarEvent(int characterId, int eventId) =>
            _esiClient.GetRequestAsync<CalendarEventRequest, CharacterCalendarEvent>(CalendarEventRequest.Create(characterId, eventId));

        public Task<EsiResponse<List<CharacterCalendarItem>>> CalendarItems(int characterId, int? fromEventId = null) =>
            _esiClient.GetRequestAsync<SummaryCalendarEventsRequest, List<CharacterCalendarItem>>(SummaryCalendarEventsRequest.Create(characterId, fromEventId));

        public Task<EsiResponse> RespondeEvent(int characterId, int eventId, EventResponse eventResponse) =>
            _esiClient.PutRequestAsync<CalendarRespondeRequest>(CalendarRespondeRequest.Create(characterId, eventId, eventResponse.ToEsiString()));
    }
}
