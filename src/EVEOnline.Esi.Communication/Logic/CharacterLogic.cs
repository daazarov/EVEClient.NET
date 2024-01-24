using EVEOnline.Esi.Communication.DataContract;
using EVEOnline.Esi.Communication.DataContract.Requests.Internal;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVEOnline.Esi.Communication.Logic
{
    internal class CharacterLogic : ICharacterLogic
    {
        private readonly IEsiHttpClient<ICharacterLogic> _esiClient;

        public CharacterLogic(IEsiHttpClient<ICharacterLogic> esiClient)
        { 
            _esiClient = esiClient;
        }

        public Task<EsiResponse<CharacterPublicInformation>> GetCharacterPulicInformationAsync(int characterId) =>
            _esiClient.GetRequestAsync<CharacterIdRouteRequest, CharacterPublicInformation>(CharacterIdRouteRequest.Create(characterId));

        public Task<EsiResponse<IEnumerable<CharacterStanding>>> GetCharacterStandingsAsync(int characterId) =>
            _esiClient.GetRequestAsync<CharacterIdRouteRequest, IEnumerable<CharacterStanding>>(CharacterIdRouteRequest.Create(characterId));

        public Task<EsiResponse<IEnumerable<CharacterAgentsResearch>>> GetCharacterAgentsResearchAsync(int characterId) =>
            _esiClient.GetRequestAsync<CharacterIdRouteRequest, IEnumerable<CharacterAgentsResearch>>(CharacterIdRouteRequest.Create(characterId));

        public Task<EsiResponsePagination<IEnumerable<CharacterBlueprint>>> GetCharacterBlueprintsAsync(int characterId, int page = 1) =>
            _esiClient.GetPaginationRequestAsync<GetCharacterBlueprintsRequest, IEnumerable<CharacterBlueprint>>(new GetCharacterBlueprintsRequest(new PageBasedCharacterIdModel(characterId, page)));

        public Task<EsiResponse<IEnumerable<CharacterCorporationHistory>>> GetCharacterCorporationHistoryAsync(int characterId) =>
            _esiClient.GetRequestAsync<CharacterIdRouteRequest, IEnumerable<CharacterCorporationHistory>>(CharacterIdRouteRequest.Create(characterId));

        public Task<EsiResponse<long>> PostCharacterCspaAsync(int characterId, int[] characterIds) =>
            _esiClient.PostRequestAsync<PostCharacterCspaRequest, long>(new PostCharacterCspaRequest(new CharacterIdModel(characterId), new CharacterIdsBodyModel(characterIds)));

        public Task<EsiResponse<CharacterFatigue>> GetCharacterFatigueAsync(int characterId) =>
            _esiClient.GetRequestAsync<CharacterIdRouteRequest, CharacterFatigue>(CharacterIdRouteRequest.Create(characterId));

        public Task<EsiResponse<IEnumerable<CharacterMedal>>> GetCharacterMedalsAsync(int characterId) =>
            _esiClient.GetRequestAsync<CharacterIdRouteRequest, IEnumerable<CharacterMedal>>(CharacterIdRouteRequest.Create(characterId));

        public Task<EsiResponse<IEnumerable<CharacterNotification>>> GetCharacterNotificationsAsync(int characterId) =>
            _esiClient.GetRequestAsync<CharacterIdRouteRequest, IEnumerable<CharacterNotification>>(CharacterIdRouteRequest.Create(characterId));

        public Task<EsiResponse<IEnumerable<CharacterContactNotification>>> GetCharacterContactNotificationsAsync(int characterId) =>
            _esiClient.GetRequestAsync<CharacterIdRouteRequest, IEnumerable<CharacterContactNotification>>(CharacterIdRouteRequest.Create(characterId));

        public Task<EsiResponse<CharacterPortrait>> GetCharacterPortraitAsync(int characterId) =>
            _esiClient.GetRequestAsync<CharacterIdRouteRequest, CharacterPortrait>(CharacterIdRouteRequest.Create(characterId));

        public Task<EsiResponse<CharacterRoles>> GetCharacterRolesAsync(int characterId) =>
            _esiClient.GetRequestAsync<CharacterIdRouteRequest, CharacterRoles>(CharacterIdRouteRequest.Create(characterId));

        public Task<EsiResponse<IEnumerable<CharacterTitle>>> GetCharacterTitlesAsync(int characterId) =>
            _esiClient.GetRequestAsync<CharacterIdRouteRequest, IEnumerable<CharacterTitle>>(CharacterIdRouteRequest.Create(characterId));

        public Task<EsiResponse<IEnumerable<CharacterAffilation>>> PostCharacterAffilationAsync(int[] characterIds) =>
            _esiClient.PostRequestAsync<PostCharacterAffilationRequest, IEnumerable<CharacterAffilation>>(new PostCharacterAffilationRequest(new CharacterIdsBodyModel(characterIds)));
    }
}
