using System.Collections.Generic;
using System.Threading.Tasks;

using EVEOnline.ESI.Communication.DataContract;

using static EVEOnline.ESI.Communication.Models.CommonRequests;

namespace EVEOnline.ESI.Communication.Logic
{
    internal class SkillsLogic : ISkillsLogic
    {
        private readonly IEsiHttpClient<ISkillsLogic> _esiClient;

        public SkillsLogic(IEsiHttpClient<ISkillsLogic> esiClient)
        {
            _esiClient = esiClient;
        }

        public Task<EsiResponse<SkillAttributes>> Attributes(int characterId) =>
            _esiClient.GetRequestAsync<CharacterIdRouteRequest, SkillAttributes>(CharacterIdRouteRequest.Create(characterId));

        public Task<EsiResponse<List<SkillQueueItem>>> SkillQueue(int characterId) =>
            _esiClient.GetRequestAsync<CharacterIdRouteRequest, List<SkillQueueItem>>(CharacterIdRouteRequest.Create(characterId));

        public Task<EsiResponse<SkillDetails>> SkillDetails(int characterId) =>
            _esiClient.GetRequestAsync<CharacterIdRouteRequest, SkillDetails>(CharacterIdRouteRequest.Create(characterId));
    }
}
