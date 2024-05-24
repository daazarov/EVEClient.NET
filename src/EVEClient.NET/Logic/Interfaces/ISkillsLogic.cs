using System.Collections.Generic;
using System.Threading.Tasks;

using EVEClient.NET.Attributes;
using EVEClient.NET.DataContract;

namespace EVEClient.NET
{
    public interface ISkillsLogic
    {
        /// <summary>
        /// Return attributes of a character
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        [ProtectedEndpoint(RequiredScope = "esi-skills.read_skills.v1")]
        [Route("/latest/characters/{character_id}/attributes/", Version = EndpointVersion.Latest)]
        [Route("/legacy/characters/{character_id}/attributes/", Version = EndpointVersion.Legacy)]
        [Route("/v1/characters/{character_id}/attributes/", Version = EndpointVersion.V1, Preferred = true)]
        [Route("/dev/characters/{character_id}/attributes/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<SkillAttributes>> Attributes(int characterId);

        /// <summary>
        /// List the configured skill queue for the given character
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        [ProtectedEndpoint(RequiredScope = "esi-skills.read_skillqueue.v1")]
        [Route("/latest/characters/{character_id}/skillqueue/", Version = EndpointVersion.Latest)]
        [Route("/legacy/characters/{character_id}/skillqueue/", Version = EndpointVersion.Legacy)]
        [Route("/v2/characters/{character_id}/skillqueue/", Version = EndpointVersion.V2, Preferred = true)]
        [Route("/dev/characters/{character_id}/skillqueue/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<List<SkillQueueItem>>> SkillQueue(int characterId);

        /// <summary>
        /// List all trained skills for the given character
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        [ProtectedEndpoint(RequiredScope = "esi-skills.read_skills.v1")]
        [Route("/latest/characters/{character_id}/skills/", Version = EndpointVersion.Latest)]
        [Route("/v4/characters/{character_id}/skills/", Version = EndpointVersion.V4, Preferred = true)]
        [Route("/dev/characters/{character_id}/skills/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<SkillDetails>> SkillDetails(int characterId);
    }
}
