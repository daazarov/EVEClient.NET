using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

using EVEClient.NET.DataContract;

namespace EVEClient.NET
{
    public interface ICalendarLogic
    {
        /// <summary>
        /// Get 50 event summaries from the calendar.
        /// If no from_event ID is given, the resource will return the next 50 chronological event summaries from now.
        /// If a from_event ID is specified, it will return the next 50 chronological event summaries from after that event.
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="fromEventId">The event ID to retrieve events from</param>
        Task<EsiResponse<List<CharacterCalendarItem>>> CalendarItems(int characterId, int? fromEventId = null, string? token = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get all the information for a specific event
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="eventId">The id of the event requested</param>
        Task<EsiResponse<CharacterCalendarEvent>> CalendarEvent(int characterId, int eventId, string? token = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Set your response status to an event
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="eventId">The id of the event requested</param>
        /// <param name="eventResponse">The response value to set, overriding current value</param>
        Task<EsiResponse> RespondeEvent(int characterId, int eventId, EventResponse eventResponse, string? token = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get all invited attendees for a given event
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="eventId">The id of the event requested</param>
        Task<EsiResponse<List<Attendee>>> EventAttendees(int characterId, int eventId, string? token = null, CancellationToken cancellationToken = default);
    }
}
