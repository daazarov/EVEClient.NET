using System.Collections.Generic;
using System.Threading.Tasks;

using EVEClient.NET.DataContract;
using EVEClient.NET.Extensions;
using EVEClient.NET.Requests;
using EVEClient.NET.Requests.Characters;

namespace EVEClient.NET.Logic
{
    internal class CharacterLogic : ICharacterLogic
    {
        private readonly IEsiHttpClient _client;

        public CharacterLogic(IEsiHttpClient client)
        { 
            _client = client;
        }

        public async Task<EsiResponse<CharacterPublicInformation>> PublicInformation(int characterId)
        {
            var response = await _client.Request(ESI.Endpoints.Characters.PublicInformation, new Common.CharacterIdRequest
            {
                CharacterId = characterId
            });
            
            return await response.ReadEsiResponse<CharacterPublicInformation>();
        }

        public async Task<EsiResponse<List<CharacterStanding>>> Standings(int characterId, string? token = null)
        {
            var response = await _client.Request(ESI.Endpoints.Characters.Standings, new Common.CharacterIdRequest
            {
                CharacterId = characterId,
                Token = token
            });

            return await response.ReadEsiResponse<List<CharacterStanding>>();
        }

        public async Task<EsiResponse<List<CharacterAgentsResearch>>> AgentsResearch(int characterId, string? token = null)
        {
            var response = await _client.Request(ESI.Endpoints.Characters.AgentsResearch, new Common.CharacterIdRequest
            {
                CharacterId = characterId,
                Token = token
            });
            
            return await response.ReadEsiResponse<List<CharacterAgentsResearch>>();
        }

        public async Task<EsiResponsePagination<List<CharacterBlueprint>>> Blueprints(int characterId, int page = 1, string? token = null)
        {
            var response = await _client.Request(ESI.Endpoints.Characters.Blueprints, new Common.PageBasedCharacterIdRequest
            {
                CharacterId = characterId,
                Page = page,
                Token = token
            });

            return await response.ReadPaginatedEsiResponse<List<CharacterBlueprint>>();
        }

        public async Task<EsiResponse<List<CharacterCorporationHistory>>> CorporationHistory(int characterId)
        {
            var response = await _client.Request(ESI.Endpoints.Characters.CorporationHistory, new Common.CharacterIdRequest
            {
                CharacterId = characterId
            });

            return await response.ReadEsiResponse<List<CharacterCorporationHistory>>();
        }

        public async Task<EsiResponse<long>> CSPA(int characterId, int[] characterIds, string? token = null)
        {
            var response = await _client.Request(ESI.Endpoints.Characters.CSPA, new PostCharacterCspaRequest
            {
                CharacterId = characterId,
                CharacterIds = characterIds,
                Token = token
            });

            return await response.ReadEsiResponse<long>();
        }

        public async Task<EsiResponse<CharacterFatigue>> Fatigue(int characterId, string? token = null)
        {
            var response = await _client.Request(ESI.Endpoints.Characters.Fatigue, new Common.CharacterIdRequest
            {
                CharacterId = characterId,
                Token = token
            });

            return await response.ReadEsiResponse<CharacterFatigue>();
        }

        public async Task<EsiResponse<List<CharacterMedal>>> Medals(int characterId, string? token = null)
        {
            var response = await _client.Request(ESI.Endpoints.Characters.Medals, new Common.CharacterIdRequest
            {
                CharacterId = characterId,
                Token = token
            });

            return await response.ReadEsiResponse<List<CharacterMedal>>();
        }

        public async Task<EsiResponse<List<CharacterNotification>>> Notifications(int characterId, string? token = null)
        {
            var response = await _client.Request(ESI.Endpoints.Characters.Notifications, new Common.CharacterIdRequest
            {
                CharacterId = characterId,
                Token = token
            });

            return await response.ReadEsiResponse<List<CharacterNotification>>();
        }

        public async Task<EsiResponse<List<CharacterContactNotification>>> ContactNotifications(int characterId, string? token = null)
        {
            var response = await _client.Request(ESI.Endpoints.Characters.ContactNotifications, new Common.CharacterIdRequest
            {
                CharacterId = characterId,
                Token = token
            });

            return await response.ReadEsiResponse<List<CharacterContactNotification>>();
        }

        public async Task<EsiResponse<CharacterPortrait>> Portrait(int characterId)
        {
            var response = await _client.Request(ESI.Endpoints.Characters.Portrait, new Common.CharacterIdRequest
            {
                CharacterId = characterId,
            });

            return await response.ReadEsiResponse<CharacterPortrait>();
        }

        public async Task<EsiResponse<CharacterRoles>> Roles(int characterId, string? token = null)
        {
            var response = await _client.Request(ESI.Endpoints.Characters.Roles, new Common.CharacterIdRequest
            {
                CharacterId = characterId,
                Token = token
            });

            return await response.ReadEsiResponse<CharacterRoles>();
        }

        public async Task<EsiResponse<List<CharacterTitle>>> Titles(int characterId, string? token = null)
        {
            var response = await _client.Request(ESI.Endpoints.Characters.Titles, new Common.CharacterIdRequest
            {
                CharacterId = characterId,
                Token = token
            });

            return await response.ReadEsiResponse<List<CharacterTitle>>();
        }

        public async Task<EsiResponse<List<CharacterAffilation>>> Affilation(int[] characterIds)
        {
            var response = await _client.Request(ESI.Endpoints.Characters.Affilation, new PostCharacterAffilationRequest
            {
                CharacterIds = characterIds
            });

            return await response.ReadEsiResponse<List<CharacterAffilation>>();
        }

        //public async Task<EsiStreamResponse<CharacterBlueprint>> Blueprints(int characterId, int pageLimit = 0, int pageOffset = 0, string? token = null, CancellationToken cancellationToken = default)
        //{
        //    var resonse = new EsiStreamResponseDefault<CharacterBlueprint>
        //    (
        //        executor: (page) => 
        //            _client.GetPaginationRequestAsync<List<CharacterBlueprint>>(ESI.Endpoints.Characters.Blueprints, new Common.PageBasedCharacterIdRequest
        //            {
        //                CharacterId = characterId,
        //                Page = page,
        //                MethodType = HttpMethodType.Get
        //            },
        //            token,
        //            ExecutionOptions.WithoutETag),
        //        pageOffset: pageOffset,
        //        pageLimit: pageLimit,
        //        cancellationToken: cancellationToken,
        //        pageSize: 1000
        //    );

        //    await resonse.InitializeAsync();

        //    return resonse;
        //}
    }
}
