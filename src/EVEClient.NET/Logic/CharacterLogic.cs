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

        public Task<EsiResponse<List<CharacterStanding>>> Standings(int characterId, string? token = null) =>
            _esiClient.GetRequestAsync<CharacterIdRouteRequest, List<CharacterStanding>>(CharacterIdRouteRequest.Create(characterId), token);

        public Task<EsiResponse<List<CharacterAgentsResearch>>> AgentsResearch(int characterId, string? token = null) =>
            _esiClient.GetRequestAsync<CharacterIdRouteRequest, List<CharacterAgentsResearch>>(CharacterIdRouteRequest.Create(characterId), token);

        public Task<EsiResponsePagination<List<CharacterBlueprint>>> Blueprints(int characterId, int page = 1, string? token = null) =>
            _esiClient.GetPaginationRequestAsync<GetCharacterBlueprintsRequest, List<CharacterBlueprint>>(GetCharacterBlueprintsRequest.Create(characterId, page), token);

        public Task<EsiResponse<List<CharacterCorporationHistory>>> CorporationHistory(int characterId) =>
            _esiClient.GetRequestAsync<CharacterIdRouteRequest, List<CharacterCorporationHistory>>(CharacterIdRouteRequest.Create(characterId));

        public Task<EsiResponse<long>> CSPA(int characterId, int[] characterIds, string? token = null) =>
            _esiClient.PostRequestAsync<PostCharacterCspaRequest, long>(PostCharacterCspaRequest.Create(characterId, characterIds), token);

        public Task<EsiResponse<CharacterFatigue>> Fatigue(int characterId, string? token = null) =>
            _esiClient.GetRequestAsync<CharacterIdRouteRequest, CharacterFatigue>(CharacterIdRouteRequest.Create(characterId), token);

        public Task<EsiResponse<List<CharacterMedal>>> Medals(int characterId, string? token = null) =>
            _esiClient.GetRequestAsync<CharacterIdRouteRequest, List<CharacterMedal>>(CharacterIdRouteRequest.Create(characterId), token);

        public Task<EsiResponse<List<CharacterNotification>>> Notifications(int characterId, string? token = null) =>
            _esiClient.GetRequestAsync<CharacterIdRouteRequest, List<CharacterNotification>>(CharacterIdRouteRequest.Create(characterId), token);

        public Task<EsiResponse<List<CharacterContactNotification>>> ContactNotifications(int characterId, string? token = null) =>
            _esiClient.GetRequestAsync<CharacterIdRouteRequest, List<CharacterContactNotification>>(CharacterIdRouteRequest.Create(characterId), token);

        public Task<EsiResponse<CharacterPortrait>> Portrait(int characterId) =>
            _esiClient.GetRequestAsync<CharacterIdRouteRequest, CharacterPortrait>(CharacterIdRouteRequest.Create(characterId));

        public Task<EsiResponse<CharacterRoles>> Roles(int characterId, string? token = null) =>
            _esiClient.GetRequestAsync<CharacterIdRouteRequest, CharacterRoles>(CharacterIdRouteRequest.Create(characterId), token);

        public Task<EsiResponse<List<CharacterTitle>>> Titles(int characterId, string? token = null) =>
            _esiClient.GetRequestAsync<CharacterIdRouteRequest, List<CharacterTitle>>(CharacterIdRouteRequest.Create(characterId), token);

        public Task<EsiResponse<List<CharacterAffilation>>> Affilation(int[] characterIds) =>
            _esiClient.PostRequestAsync<PostCharacterAffilationRequest, List<CharacterAffilation>>(PostCharacterAffilationRequest.Create(characterIds));
    }
}
