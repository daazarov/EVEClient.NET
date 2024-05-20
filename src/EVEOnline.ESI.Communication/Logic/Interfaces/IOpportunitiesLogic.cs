using System.Collections.Generic;
using System.Threading.Tasks;

using EVEOnline.ESI.Communication.Attributes;
using EVEOnline.ESI.Communication.DataContract;

namespace EVEOnline.ESI.Communication
{
    public interface IOpportunitiesLogic
    {
        /// <summary>
        /// Return a list of tasks finished by a character
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        [ProtectedEndpoint(RequiredScope = "esi-characters.read_opportunities.v1")]
        [Route("/latest/characters/{character_id}/opportunities/", Version = EndpointVersion.Latest)]
        [Route("/legacy/characters/{character_id}/opportunities/", Version = EndpointVersion.Legacy)]
        [Route("/v1/characters/{character_id}/opportunities/", Version = EndpointVersion.V1, Preferred = true)]
        [Route("/dev/characters/{character_id}/opportunities/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<List<ComplitedTask>>> CompletedTasks(int characterId);

        /// <summary>
        /// Return a list of opportunities groups
        /// </summary>
        [PublicEndpoint]
        [Route("/latest/opportunities/groups/", Version = EndpointVersion.Latest)]
        [Route("/legacy/opportunities/groups/", Version = EndpointVersion.Legacy)]
        [Route("/v1/opportunities/groups/", Version = EndpointVersion.V1, Preferred = true)]
        [Route("/dev/opportunities/groups/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<List<int>>> Groups();

        /// <summary>
        /// Return information of an opportunities group
        /// </summary>
        /// <param name="groupId">ID of an opportunities group</param>
        [PublicEndpoint]
        [Route("/latest/opportunities/groups/{group_id}/", Version = EndpointVersion.Latest)]
        [Route("/legacy/opportunities/groups/{group_id}/", Version = EndpointVersion.Legacy)]
        [Route("/v1/opportunities/groups/{group_id}/", Version = EndpointVersion.V1, Preferred = true)]
        [Route("/dev/opportunities/groups/{group_id}/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<OpportunitiesGroup>> GroupInfo(int groupId);

        /// <summary>
        /// Return a list of opportunities tasks
        /// </summary>
        [PublicEndpoint]
        [Route("/latest/opportunities/tasks/", Version = EndpointVersion.Latest)]
        [Route("/legacy/opportunities/tasks/", Version = EndpointVersion.Legacy)]
        [Route("/v1/opportunities/tasks/", Version = EndpointVersion.V1, Preferred = true)]
        [Route("/dev/opportunities/tasks/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<List<int>>> Tasks();

        /// <summary>
        /// Return information of an opportunities task
        /// </summary>
        /// <param name="taskId">ID of an opportunities task</param>
        [PublicEndpoint]
        [Route("/latest/opportunities/tasks/{task_id}/", Version = EndpointVersion.Latest)]
        [Route("/legacy/opportunities/tasks/{task_id}/", Version = EndpointVersion.Legacy)]
        [Route("/v1/opportunities/tasks/{task_id}/", Version = EndpointVersion.V1, Preferred = true)]
        [Route("/dev/opportunities/tasks/{task_id}/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<OpportunitiesTask>> TaskInfo(int taskId);
    }
}
