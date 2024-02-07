using System.Collections.Generic;
using System.Threading.Tasks;

using EVEOnline.ESI.Communication.DataContract;
using EVEOnline.ESI.Communication.Models;

using static EVEOnline.ESI.Communication.Models.CharactersRequests;

namespace EVEOnline.ESI.Communication.Logic
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

        public Task<EsiResponse<List<CharacterStanding>>> GetCharacterStandingsAsync(int characterId) =>
            _esiClient.GetRequestAsync<CharacterIdRouteRequest, List<CharacterStanding>>(CharacterIdRouteRequest.Create(characterId));

        public Task<EsiResponse<List<CharacterAgentsResearch>>> GetCharacterAgentsResearchAsync(int characterId) =>
            _esiClient.GetRequestAsync<CharacterIdRouteRequest, List<CharacterAgentsResearch>>(CharacterIdRouteRequest.Create(characterId));

        public Task<EsiResponsePagination<List<CharacterBlueprint>>> GetCharacterBlueprintsAsync(int characterId, int page = 1) =>
            _esiClient.GetPaginationRequestAsync<GetCharacterBlueprintsRequest, List<CharacterBlueprint>>(new GetCharacterBlueprintsRequest(new PageBasedCharacterIdModel(characterId, page)));

        public Task<EsiResponse<List<CharacterCorporationHistory>>> GetCharacterCorporationHistoryAsync(int characterId) =>
            _esiClient.GetRequestAsync<CharacterIdRouteRequest, List<CharacterCorporationHistory>>(CharacterIdRouteRequest.Create(characterId));

        public Task<EsiResponse<long>> PostCharacterCspaAsync(int characterId, int[] characterIds) =>
            _esiClient.PostRequestAsync<PostCharacterCspaRequest, long>(new PostCharacterCspaRequest(new CharacterIdModel(characterId), new CharacterIdsBodyModel(characterIds)));

        public Task<EsiResponse<CharacterFatigue>> GetCharacterFatigueAsync(int characterId) =>
            _esiClient.GetRequestAsync<CharacterIdRouteRequest, CharacterFatigue>(CharacterIdRouteRequest.Create(characterId));

        public Task<EsiResponse<List<CharacterMedal>>> GetCharacterMedalsAsync(int characterId) =>
            _esiClient.GetRequestAsync<CharacterIdRouteRequest, List<CharacterMedal>>(CharacterIdRouteRequest.Create(characterId));

        public Task<EsiResponse<List<CharacterNotification>>> GetCharacterNotificationsAsync(int characterId) =>
            _esiClient.GetRequestAsync<CharacterIdRouteRequest, List<CharacterNotification>>(CharacterIdRouteRequest.Create(characterId));

        public Task<EsiResponse<List<CharacterContactNotification>>> GetCharacterContactNotificationsAsync(int characterId) =>
            _esiClient.GetRequestAsync<CharacterIdRouteRequest, List<CharacterContactNotification>>(CharacterIdRouteRequest.Create(characterId));

        public Task<EsiResponse<CharacterPortrait>> GetCharacterPortraitAsync(int characterId) =>
            _esiClient.GetRequestAsync<CharacterIdRouteRequest, CharacterPortrait>(CharacterIdRouteRequest.Create(characterId));

        public Task<EsiResponse<CharacterRoles>> GetCharacterRolesAsync(int characterId) =>
            _esiClient.GetRequestAsync<CharacterIdRouteRequest, CharacterRoles>(CharacterIdRouteRequest.Create(characterId));

        public Task<EsiResponse<List<CharacterTitle>>> GetCharacterTitlesAsync(int characterId) =>
            _esiClient.GetRequestAsync<CharacterIdRouteRequest, List<CharacterTitle>>(CharacterIdRouteRequest.Create(characterId));

        public Task<EsiResponse<List<CharacterAffilation>>> PostCharacterAffilationAsync(int[] characterIds) =>
            _esiClient.PostRequestAsync<PostCharacterAffilationRequest, List<CharacterAffilation>>(new PostCharacterAffilationRequest(new CharacterIdsBodyModel(characterIds)));
    }
}
