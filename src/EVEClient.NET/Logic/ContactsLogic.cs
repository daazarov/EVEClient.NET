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

        public Task<EsiResponse<List<int>>> AddCharacterContacts(int characterId, int[] contactIds, float standing, int[] labelIds = null, bool watched = false) =>
            _esiClient.PostRequestAsync<AddUpdateCharacterContactRequest, List<int>>(AddUpdateCharacterContactRequest.Create(characterId, contactIds, standing, labelIds, watched));

        public Task<EsiResponse> UpdateCharacterContacts(int characterId, int[] contactIds, float standing, int[] labelIds = null, bool watched = false) =>
            _esiClient.PutRequestAsync<AddUpdateCharacterContactRequest>(AddUpdateCharacterContactRequest.Create(characterId, contactIds, standing, labelIds, watched));

        public Task<EsiResponse> DeleteCharacterContacts(int characterId, int[] contactIds) =>
            _esiClient.DeleteRequestAsync<DeleteCharacterContactsRequest>(DeleteCharacterContactsRequest.Create(characterId, contactIds));

        public Task<EsiResponse<List<ContactLabel>>> AllianceContactLabels(int allianceId) =>
            _esiClient.GetRequestAsync<AllianceIdRouteRequest, List<ContactLabel>>(AllianceIdRouteRequest.Create(allianceId));

        public Task<EsiResponsePagination<List<AlianceContact>>> AllianceContacts(int allianceId, int page = 1) =>
            _esiClient.GetPaginationRequestAsync<PageBasedAllianceIdRouteRequest, List<AlianceContact>>(PageBasedAllianceIdRouteRequest.Create(allianceId, page));

        public Task<EsiResponse<List<ContactLabel>>> CharacterContactLabels(int characterId) =>
            _esiClient.GetRequestAsync<CharacterIdRouteRequest, List<ContactLabel>>(CharacterIdRouteRequest.Create(characterId));

        public Task<EsiResponsePagination<List<CharacterContact>>> CharacterContacts(int characterId, int page = 1) =>
            _esiClient.GetPaginationRequestAsync<PageBasedCharacterIdRouteRequest, List<CharacterContact>>(PageBasedCharacterIdRouteRequest.Create(characterId, page));

        public Task<EsiResponse<List<ContactLabel>>> CorporationContactLabels(int corporationId) =>
            _esiClient.GetRequestAsync<CorporationIdRouteRequest, List<ContactLabel>>(CorporationIdRouteRequest.Create(corporationId));

        public Task<EsiResponsePagination<List<CorporationContact>>> CorporationContacts(int corporationId, int page = 1) =>
            _esiClient.GetPaginationRequestAsync<PageBasedCorporationIdRouteRequest, List<CorporationContact>>(PageBasedCorporationIdRouteRequest.Create(corporationId, page));
    }
}
