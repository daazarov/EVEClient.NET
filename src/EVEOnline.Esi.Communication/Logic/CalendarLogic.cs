using System.Collections.Generic;
using System.Threading.Tasks;

using EVEOnline.Esi.Communication.DataContract;
using EVEOnline.Esi.Communication.Logic.Interfaces;

using static EVEOnline.Esi.Communication.DataContract.Requests.Internal.CalendarRequests;

namespace EVEOnline.Esi.Communication.Logic
{
    internal class CalendarLogic : ICalendarLogic
    {
        private readonly IEsiHttpClient<ICalendarLogic> _esiClient;

        public CalendarLogic(IEsiHttpClient<ICalendarLogic> esiClient)
        {
            _esiClient = esiClient;
        }

        public Task<EsiResponse<List<Attendee>>> GetCalendarEventAttendeesAsync(int characterId, int eventId) =>
            _esiClient.GetRequestAsync<CalendarRouteRequest, List<Attendee>>(CalendarRouteRequest.Create(characterId, eventId));

        public Task<EsiResponse<CharacterCalendarEvent>> GetCharacterCalendarEventAsync(int characterId, int eventId) =>
            _esiClient.GetRequestAsync<CalendarRouteRequest, CharacterCalendarEvent>(CalendarRouteRequest.Create(characterId, eventId));

        public Task<EsiResponse<List<CharacterCalendarItem>>> GetCharacterSummaryCalendarEventsAsync(int characterId, int? fromEventId = null) =>
            _esiClient.GetRequestAsync<CalendarRouteFromEventQueryRequest, List<CharacterCalendarItem>>(CalendarRouteFromEventQueryRequest.Create(characterId, fromEventId));

        public Task<EsiResponse> RespondCaracterEventAsync(int characterId, int eventId, EventResponse eventResponse) =>
            _esiClient.PutNoContentRequestAsync<CalendarRespondeRequest>(CalendarRespondeRequest.Create(characterId, eventId, eventResponse));
    }
}
