using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

using EVEClient.NET.DataContract;

namespace EVEClient.NET
{
    public interface IDogmaLogic
    {
        /// <summary>
        /// Get a list of dogma attribute ids
        /// </summary>
        Task<EsiResponse<List<int>>> Attributes(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get information on a dogma attribute
        /// </summary>
        /// <param name="attributeId">A dogma attribute ID</param>
        Task<EsiResponse<AttributeInfo>> AttributeInfo(int attributeId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Returns info about a dynamic item resulting from mutation with a mutaplasmid.
        /// </summary>
        Task<EsiResponse<DynamicItemInfo>> DynamicItemInfo(long itemId, int typeId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get a list of dogma effect ids
        /// </summary>
        Task<EsiResponse<List<int>>> Effects(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get information on a dogma effect
        /// </summary>
        /// <param name="effectID">A dogma effect ID</param>
        Task<EsiResponse<EffectInfo>> EffectInfo(int effectId, CancellationToken cancellationToken = default);
    }
}
