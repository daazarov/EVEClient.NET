using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

using EVEClient.NET.DataContract;

namespace EVEClient.NET
{
    public interface IClonesLogic
    {
        /// <summary>
        /// A list of the character’s clones
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        Task<EsiResponse<Clones>> CloneList(int characterId, string? token = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Return implants on the active clone of a character
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        Task<EsiResponse<List<int>>> CloneImplants(int characterId, string? token = null, CancellationToken cancellationToken = default);
    }
}
