﻿using System.Collections.Generic;
using System.Threading.Tasks;

using EVEOnline.Esi.Communication.Attributes;
using EVEOnline.Esi.Communication.DataContract;

namespace EVEOnline.Esi.Communication.Logic.Interfaces
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
        [ProtectedEndpoint(RequiredScope = "esi-calendar.read_calendar_events.v1")]
        [Route("/latest/characters/{character_id}/calendar/", Version = EndpointVersion.Latest)]
        [Route("/legacy/characters/{character_id}/calendar/", Version = EndpointVersion.Legacy)]
        [Route("/v1/characters/{character_id}/calendar/", Version = EndpointVersion.V1)]
        [Route("/v2/characters/{character_id}/calendar/", Version = EndpointVersion.V2)]
        [Route("/dev/characters/{character_id}/calendar/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<List<CharacterCalendarItem>>> GetCharacterSummaryCalendarEventsAsync(int characterId, int? fromEventId = null);

        /// <summary>
        /// Get all the information for a specific event
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="eventId">The id of the event requested</param>
        [ProtectedEndpoint(RequiredScope = "esi-calendar.read_calendar_events.v1")]
        [Route("/latest/characters/{character_id}/calendar/{event_id}/", Version = EndpointVersion.Latest)]
        [Route("/legacy/characters/{character_id}/calendar/{event_id}/", Version = EndpointVersion.Legacy)]
        [Route("/v3/characters/{character_id}/calendar/{event_id}/", Version = EndpointVersion.V3)]
        [Route("/v4/characters/{character_id}/calendar/{event_id}/", Version = EndpointVersion.V4)]
        [Route("/dev/characters/{character_id}/calendar/{event_id}/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<CharacterCalendarEvent>> GetCharacterCalendarEventAsync(int characterId, int eventId);

        /// <summary>
        /// Set your response status to an event
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="eventId">The id of the event requested</param>
        /// <param name="eventResponse">The response value to set, overriding current value</param>
        [ProtectedEndpoint(RequiredScope = "esi-calendar.respond_calendar_events.v1")]
        [Route("/latest/characters/{character_id}/calendar/{event_id}/", Version = EndpointVersion.Latest)]
        [Route("/legacy/characters/{character_id}/calendar/{event_id}/", Version = EndpointVersion.Legacy)]
        [Route("/v3/characters/{character_id}/calendar/{event_id}/", Version = EndpointVersion.V3)]
        [Route("/v4/characters/{character_id}/calendar/{event_id}/", Version = EndpointVersion.V4)]
        [Route("/dev/characters/{character_id}/calendar/{event_id}/", Version = EndpointVersion.Dev)]
        Task<EsiResponse> RespondCaracterEventAsync(int characterId, int eventId, EventResponse eventResponse);

        /// <summary>
        /// Get all invited attendees for a given event
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="eventId">The id of the event requested</param>
        [ProtectedEndpoint(RequiredScope = "esi-calendar.read_calendar_events.v1")]
        [Route("/latest/characters/{character_id}/calendar/{event_id}/", Version = EndpointVersion.Latest)]
        [Route("/legacy/characters/{character_id}/calendar/{event_id}/attendees/", Version = EndpointVersion.Legacy)]
        [Route("/v1/characters/{character_id}/calendar/{event_id}/attendees/", Version = EndpointVersion.V1)]
        [Route("/v2/characters/{character_id}/calendar/{event_id}/attendees/", Version = EndpointVersion.V2)]
        [Route("/dev/characters/{character_id}/calendar/{event_id}/attendees/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<List<Attendee>>> GetCalendarEventAttendeesAsync(int characterId, int eventId);
    }
}
