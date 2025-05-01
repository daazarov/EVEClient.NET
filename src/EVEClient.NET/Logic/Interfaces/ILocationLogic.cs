using System.Threading;
using System.Threading.Tasks;

using EVEClient.NET.DataContract;

namespace EVEClient.NET
{
    public interface ILocationLogic
    {
        /// <summary>
        /// Information about the characters current location.
        /// Returns the current solar system id, and also the current station or structure ID if applicable
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        Task<EsiResponse<Location>> CurrentLocation(int characterId, string? token = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Checks if the character is currently online
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        Task<EsiResponse<Activity>> Online(int characterId, string? token = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the current ship type, name and id
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        Task<EsiResponse<Ship>> CurrentShip(int characterId, string? token = null, CancellationToken cancellationToken = default);
    }
}
