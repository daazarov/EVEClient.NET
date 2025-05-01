using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

using EVEClient.NET.DataContract;
using EVEClient.NET.Extensions;
using EVEClient.NET.Requests;

namespace EVEClient.NET.Logic
{
    internal class CalendarLogic : ICalendarLogic
    {
        private readonly IEsiHttpClient _client;
        private readonly IEsiRequestFactory _esiRequestFactory;

        public CalendarLogic(IEsiHttpClient client, IEsiRequestFactory esiRequestFactory)
        {
            _client = client;
            _esiRequestFactory = esiRequestFactory;
        }

        public async Task<EsiResponse<List<Attendee>>> EventAttendees(int characterId, int eventId, string? token = null, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.CharacterId] = characterId.ToString();
                    parameters.Route[ESI.Parameters.Route.EventId] = eventId.ToString();
                },
                token: token);

            var response = await _client.Request(ESI.Endpoints.Calendar.EventAttendees, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<List<Attendee>>();
        }

        public async Task<EsiResponse<CharacterCalendarEvent>> CalendarEvent(int characterId, int eventId, string? token = null, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.CharacterId] = characterId.ToString();
                    parameters.Route[ESI.Parameters.Route.EventId] = eventId.ToString();
                },
                token: token);

            var response = await _client.Request(ESI.Endpoints.Calendar.CalendarEvent, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<CharacterCalendarEvent>();
        }

        public async Task<EsiResponse<List<CharacterCalendarItem>>> CalendarItems(int characterId, int? fromEventId = null, string? token = null, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.CharacterId] = characterId.ToString();
                    parameters.Query[ESI.Parameters.Query.FromEvent] = fromEventId.ToString();
                },
                token: token);

            var response = await _client.Request(ESI.Endpoints.Calendar.CalendarEvent, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<List<CharacterCalendarItem>>();
        }

        public async Task<EsiResponse> RespondeEvent(int characterId, int eventId, EventResponse eventResponse, string? token = null, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.CharacterId] = characterId.ToString();
                    parameters.Route[ESI.Parameters.Route.EventId] = eventId.ToString();
                    parameters.Body = new
                    {
                        response = eventResponse.ToEsiString()
                    };
                },
                token: token);

            var response = await _client.Request(ESI.Endpoints.Calendar.RespondeEvent, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<List<CharacterCalendarItem>>();
        }
    }
}
