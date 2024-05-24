using System.Collections.Generic;
using System.Threading.Tasks;

using EVEClient.NET.DataContract;

using static EVEClient.NET.Models.CharactersRequests;
using static EVEClient.NET.Models.CommonRequests;

namespace EVEClient.NET.Logic
{
    internal class CharacterLogic : ICharacterLogic
    {
        private readonly IEsiHttpClient<ICharacterLogic> _esiClient;

        public CharacterLogic(IEsiHttpClient<ICharacterLogic> esiClient)
        { 
            _esiClient = esiClient;
        }

        public Task<EsiResponse<CharacterPublicInformation>> PublicInformation(int characterId) =>
            _esiClient.GetRequestAsync<CharacterIdRouteRequest, CharacterPublicInformation>(CharacterIdRouteRequest.Create(characterId));

        public Task<EsiResponse<List<CharacterStanding>>> Standings(int characterId) =>
            _esiClient.GetRequestAsync<CharacterIdRouteRequest, List<CharacterStanding>>(CharacterIdRouteRequest.Create(characterId));

        public Task<EsiResponse<List<CharacterAgentsResearch>>> AgentsResearch(int characterId) =>
            _esiClient.GetRequestAsync<CharacterIdRouteRequest, List<CharacterAgentsResearch>>(CharacterIdRouteRequest.Create(characterId));

        public Task<EsiResponsePagination<List<CharacterBlueprint>>> Blueprints(int characterId, int page = 1) =>
            _esiClient.GetPaginationRequestAsync<GetCharacterBlueprintsRequest, List<CharacterBlueprint>>(GetCharacterBlueprintsRequest.Create(characterId, page));

        public Task<EsiResponse<List<CharacterCorporationHistory>>> CorporationHistory(int characterId) =>
            _esiClient.GetRequestAsync<CharacterIdRouteRequest, List<CharacterCorporationHistory>>(CharacterIdRouteRequest.Create(characterId));

        public Task<EsiResponse<long>> CSPA(int characterId, int[] characterIds) =>
            _esiClient.PostRequestAsync<PostCharacterCspaRequest, long>(PostCharacterCspaRequest.Create(characterId, characterIds));

        public Task<EsiResponse<CharacterFatigue>> Fatigue(int characterId) =>
            _esiClient.GetRequestAsync<CharacterIdRouteRequest, CharacterFatigue>(CharacterIdRouteRequest.Create(characterId));

        public Task<EsiResponse<List<CharacterMedal>>> Medals(int characterId) =>
            _esiClient.GetRequestAsync<CharacterIdRouteRequest, List<CharacterMedal>>(CharacterIdRouteRequest.Create(characterId));

        public Task<EsiResponse<List<CharacterNotification>>> Notifications(int characterId) =>
            _esiClient.GetRequestAsync<CharacterIdRouteRequest, List<CharacterNotification>>(CharacterIdRouteRequest.Create(characterId));

        public Task<EsiResponse<List<CharacterContactNotification>>> ContactNotifications(int characterId) =>
            _esiClient.GetRequestAsync<CharacterIdRouteRequest, List<CharacterContactNotification>>(CharacterIdRouteRequest.Create(characterId));

        public Task<EsiResponse<CharacterPortrait>> Portrait(int characterId) =>
            _esiClient.GetRequestAsync<CharacterIdRouteRequest, CharacterPortrait>(CharacterIdRouteRequest.Create(characterId));

        public Task<EsiResponse<CharacterRoles>> Roles(int characterId) =>
            _esiClient.GetRequestAsync<CharacterIdRouteRequest, CharacterRoles>(CharacterIdRouteRequest.Create(characterId));

        public Task<EsiResponse<List<CharacterTitle>>> Titles(int characterId) =>
            _esiClient.GetRequestAsync<CharacterIdRouteRequest, List<CharacterTitle>>(CharacterIdRouteRequest.Create(characterId));

        public Task<EsiResponse<List<CharacterAffilation>>> Affilation(int[] characterIds) =>
            _esiClient.PostRequestAsync<PostCharacterAffilationRequest, List<CharacterAffilation>>(PostCharacterAffilationRequest.Create(characterIds));
    }
}
