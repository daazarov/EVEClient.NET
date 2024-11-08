using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

using EVEClient.NET.DataContract;
using EVEClient.NET.Extensions;
using EVEClient.NET.Requests;

namespace EVEClient.NET.Logic
{
    internal class ContactsLogic : IContactsLogic
    {
        private readonly IEsiHttpClient _client;
        private readonly IEsiRequestFactory _esiRequestFactory;

        public ContactsLogic(IEsiHttpClient client, IEsiRequestFactory esiRequestFactory)
        {
            _client = client;
            _esiRequestFactory = esiRequestFactory;
        }

        public async Task<EsiResponse<List<int>>> AddCharacterContacts(int characterId, int[] contactIds, float standing, int[]? labelIds = null, bool watched = false, string? token = null, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.CharacterId] = characterId.ToString();
                    parameters.Query[ESI.Parameters.Query.Standing] = standing.ToString();
                    parameters.Query[ESI.Parameters.Query.Watched] = watched.ToString();
                    parameters.Query[ESI.Parameters.Query.LableIds] = string.Join(",", labelIds ?? Enumerable.Empty<int>());
                    parameters.Body = contactIds;
                },
                token: token);

            var response = await _client.Request(ESI.Endpoints.Contacts.AddCharacterContacts, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<List<int>>();
        }

        public async Task<EsiResponse> UpdateCharacterContacts(int characterId, int[] contactIds, float standing, int[]? labelIds = null, bool watched = false, string? token = null, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.CharacterId] = characterId.ToString();
                    parameters.Query[ESI.Parameters.Query.Standing] = standing.ToString();
                    parameters.Query[ESI.Parameters.Query.Watched] = watched.ToString();
                    parameters.Query[ESI.Parameters.Query.LableIds] = string.Join(",", labelIds ?? Enumerable.Empty<int>());
                    parameters.Body = contactIds;
                },
                token: token);

            var response = await _client.Request(ESI.Endpoints.Contacts.UpdateCharacterContacts, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse();
        }

        public async Task<EsiResponse> DeleteCharacterContacts(int characterId, int[] contactIds, string? token = null, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.CharacterId] = characterId.ToString();
                    parameters.Query[ESI.Parameters.Query.ContactIds] = string.Join(",", contactIds);
                },
                token: token);

            var response = await _client.Request(ESI.Endpoints.Contacts.DeleteCharacterContacts, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse();
        }

        public async Task<EsiResponse<List<ContactLabel>>> AllianceContactLabels(int allianceId, string? token = null, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.AllianceId] = allianceId.ToString();
                },
                token: token);

            var response = await _client.Request(ESI.Endpoints.Contacts.AllianceContactLabels, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<List<ContactLabel>>();
        }

        public async Task<EsiResponsePagination<List<AlianceContact>>> AllianceContacts(int allianceId, int page = 1, string? token = null, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.AllianceId] = allianceId.ToString();
                    parameters.Query[ESI.Parameters.Query.Page] = page.ToString();
                },
                token: token);

            var response = await _client.Request(ESI.Endpoints.Contacts.AllianceContacts, request, cancellationToken: cancellationToken);

            return await response.ReadPaginatedEsiResponse<List<AlianceContact>>();
        }

        public async Task<EsiResponse<List<ContactLabel>>> CharacterContactLabels(int characterId, string? token = null, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.CharacterId] = characterId.ToString();
                },
                token: token);

            var response = await _client.Request(ESI.Endpoints.Contacts.CharacterContactLabels, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<List<ContactLabel>>();
        }

        public async Task<EsiResponsePagination<List<CharacterContact>>> CharacterContacts(int characterId, int page = 1, string? token = null, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.CharacterId] = characterId.ToString();
                    parameters.Query[ESI.Parameters.Query.Page] = page.ToString();
                },
                token: token);

            var response = await _client.Request(ESI.Endpoints.Contacts.CharacterContacts, request, cancellationToken: cancellationToken);

            return await response.ReadPaginatedEsiResponse<List<CharacterContact>>();
        }

        public async Task<EsiResponse<List<ContactLabel>>> CorporationContactLabels(int corporationId, string? token = null, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.CorporationId] = corporationId.ToString();
                },
                token: token);

            var response = await _client.Request(ESI.Endpoints.Contacts.CorporationContactLabels, request, cancellationToken: cancellationToken);

            return await response.ReadEsiResponse<List<ContactLabel>>();
        }

        public async Task<EsiResponsePagination<List<CorporationContact>>> CorporationContacts(int corporationId, int page = 1, string? token = null, CancellationToken cancellationToken = default)
        {
            var request = await _esiRequestFactory.CreateRequest(
                configure: parameters =>
                {
                    parameters.Route[ESI.Parameters.Route.CorporationId] = corporationId.ToString();
                    parameters.Query[ESI.Parameters.Query.Page] = page.ToString();
                },
                token: token);

            var response = await _client.Request(ESI.Endpoints.Contacts.CorporationContacts, request, cancellationToken: cancellationToken);

            return await response.ReadPaginatedEsiResponse<List<CorporationContact>>();
        }
    }
}
