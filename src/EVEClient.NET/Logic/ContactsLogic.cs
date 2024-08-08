using System.Collections.Generic;
using System.Threading.Tasks;

using EVEClient.NET.DataContract;

using static EVEClient.NET.Models.CommonRequests;
using static EVEClient.NET.Models.ContactRequests;

namespace EVEClient.NET.Logic
{
    internal class ContactsLogic : IContactsLogic
    {
        private readonly IEsiHttpClient<IContactsLogic> _esiClient;

        public ContactsLogic(IEsiHttpClient<IContactsLogic> esiClient)
        {
            _esiClient = esiClient;
        }

        public Task<EsiResponse<List<int>>> AddCharacterContacts(int characterId, int[] contactIds, float standing, int[]? labelIds = null, bool watched = false, string? token = null) =>
            _esiClient.PostRequestAsync<AddUpdateCharacterContactRequest, List<int>>(AddUpdateCharacterContactRequest.Create(characterId, contactIds, standing, labelIds, watched), token);

        public Task<EsiResponse> UpdateCharacterContacts(int characterId, int[] contactIds, float standing, int[]? labelIds = null, bool watched = false, string? token = null) =>
            _esiClient.PutRequestAsync<AddUpdateCharacterContactRequest>(AddUpdateCharacterContactRequest.Create(characterId, contactIds, standing, labelIds, watched), token);

        public Task<EsiResponse> DeleteCharacterContacts(int characterId, int[] contactIds, string? token = null) =>
            _esiClient.DeleteRequestAsync<DeleteCharacterContactsRequest>(DeleteCharacterContactsRequest.Create(characterId, contactIds), token);

        public Task<EsiResponse<List<ContactLabel>>> AllianceContactLabels(int allianceId, string? token = null) =>
            _esiClient.GetRequestAsync<AllianceIdRouteRequest, List<ContactLabel>>(AllianceIdRouteRequest.Create(allianceId), token);

        public Task<EsiResponsePagination<List<AlianceContact>>> AllianceContacts(int allianceId, int page = 1, string? token = null) =>
            _esiClient.GetPaginationRequestAsync<PageBasedAllianceIdRouteRequest, List<AlianceContact>>(PageBasedAllianceIdRouteRequest.Create(allianceId, page), token);

        public Task<EsiResponse<List<ContactLabel>>> CharacterContactLabels(int characterId, string? token = null) =>
            _esiClient.GetRequestAsync<CharacterIdRouteRequest, List<ContactLabel>>(CharacterIdRouteRequest.Create(characterId), token);

        public Task<EsiResponsePagination<List<CharacterContact>>> CharacterContacts(int characterId, int page = 1, string? token = null) =>
            _esiClient.GetPaginationRequestAsync<PageBasedCharacterIdRouteRequest, List<CharacterContact>>(PageBasedCharacterIdRouteRequest.Create(characterId, page), token);

        public Task<EsiResponse<List<ContactLabel>>> CorporationContactLabels(int corporationId, string? token = null) =>
            _esiClient.GetRequestAsync<CorporationIdRouteRequest, List<ContactLabel>>(CorporationIdRouteRequest.Create(corporationId), token);

        public Task<EsiResponsePagination<List<CorporationContact>>> CorporationContacts(int corporationId, int page = 1, string? token = null) =>
            _esiClient.GetPaginationRequestAsync<PageBasedCorporationIdRouteRequest, List<CorporationContact>>(PageBasedCorporationIdRouteRequest.Create(corporationId, page), token);
    }
}
