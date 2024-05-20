using System.Collections.Generic;
using System.Threading.Tasks;

using EVEOnline.ESI.Communication.DataContract;

using static EVEOnline.ESI.Communication.Models.CommonRequests;
using static EVEOnline.ESI.Communication.Models.OpportunitiesRequests;

namespace EVEOnline.ESI.Communication.Logic
{
    internal class OpportunitiesLogic : IOpportunitiesLogic
    {
        private readonly IEsiHttpClient<IOpportunitiesLogic> _esiClient;

        public OpportunitiesLogic(IEsiHttpClient<IOpportunitiesLogic> esiClient)
        {
            _esiClient = esiClient;
        }

        public Task<EsiResponse<List<ComplitedTask>>> CompletedTasks(int characterId) =>
            _esiClient.GetRequestAsync<CharacterIdRouteRequest, List<ComplitedTask>>(CharacterIdRouteRequest.Create(characterId));

        public Task<EsiResponse<OpportunitiesGroup>> GroupInfo(int groupId) =>
            _esiClient.GetRequestAsync<CharacterIdRouteRequest, OpportunitiesGroup>(CharacterIdRouteRequest.Create(groupId));

        public Task<EsiResponse<List<int>>> Groups() =>
            _esiClient.GetRequestAsync<List<int>>();

        public Task<EsiResponse<OpportunitiesTask>> TaskInfo(int taskId) =>
            _esiClient.GetRequestAsync<TaskIdRouteRequest, OpportunitiesTask>(TaskIdRouteRequest.Create(taskId));

        public Task<EsiResponse<List<int>>> Tasks() =>
            _esiClient.GetRequestAsync<List<int>>();
    }
}
