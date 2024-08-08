using System.Collections.Generic;
using System.Threading.Tasks;

using EVEClient.NET.DataContract;

using static EVEClient.NET.Models.CommonRequests;

namespace EVEClient.NET.Logic
{
    internal class SkillsLogic : ISkillsLogic
    {
        private readonly IEsiHttpClient<ISkillsLogic> _esiClient;

        public SkillsLogic(IEsiHttpClient<ISkillsLogic> esiClient)
        {
            _esiClient = esiClient;
        }

        public Task<EsiResponse<SkillAttributes>> Attributes(int characterId, string? token = null) =>
            _esiClient.GetRequestAsync<CharacterIdRouteRequest, SkillAttributes>(CharacterIdRouteRequest.Create(characterId), token);

        public Task<EsiResponse<List<SkillQueueItem>>> SkillQueue(int characterId, string? token = null) =>
            _esiClient.GetRequestAsync<CharacterIdRouteRequest, List<SkillQueueItem>>(CharacterIdRouteRequest.Create(characterId), token);

        public Task<EsiResponse<SkillDetails>> SkillDetails(int characterId, string? token = null) =>
            _esiClient.GetRequestAsync<CharacterIdRouteRequest, SkillDetails>(CharacterIdRouteRequest.Create(characterId), token);
    }
}
