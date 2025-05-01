using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

using EVEClient.NET.DataContract;

namespace EVEClient.NET
{
    public interface ISkillsLogic
    {
        /// <summary>
        /// Return attributes of a character
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        Task<EsiResponse<SkillAttributes>> Attributes(int characterId, string? token = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// List the configured skill queue for the given character
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        Task<EsiResponse<List<SkillQueueItem>>> SkillQueue(int characterId, string? token = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// List all trained skills for the given character
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        Task<EsiResponse<SkillDetails>> SkillDetails(int characterId, string? token = null, CancellationToken cancellationToken = default);
    }
}
