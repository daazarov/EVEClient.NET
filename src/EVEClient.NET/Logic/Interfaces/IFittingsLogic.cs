using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

using EVEClient.NET.DataContract;

namespace EVEClient.NET
{
    public interface IFittingsLogic
    {
        /// <summary>
        /// Return fittings of a character
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        Task<EsiResponse<List<Fitting>>> GetFittings(int characterId, string? token = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Save a new fitting for a character
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="fitting">Details about the new fitting</param>
        Task<EsiResponse<NewFittingResponse>> NewFitting(int characterId, NewFitting fitting, string? token = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Delete a fitting from a character
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="fittingId">ID for a fitting of this character</param>
        Task<EsiResponse> DeleteFitting(int characterId, int fittingId, string? token = null, CancellationToken cancellationToken = default);
    }
}
