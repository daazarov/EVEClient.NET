using System.Threading.Tasks;

using EVEClient.NET.Attributes;
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
        [ProtectedEndpoint(RequiredScope = "esi-location.read_location.v1")]
        [Route("/latest/characters/{character_id}/location/", Version = EndpointVersion.Latest)]
        [Route("/legacy/characters/{character_id}/location/", Version = EndpointVersion.Legacy)]
        [Route("/v1/characters/{character_id}/location/", Version = EndpointVersion.V1, Preferred = true)]
        [Route("/v2/characters/{character_id}/location/", Version = EndpointVersion.V2, Preferred = true)]
        [Route("/dev/characters/{character_id}/location/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<Location>> CurrentLocation(int characterId, string? token = null);

        /// <summary>
        /// Checks if the character is currently online
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        [ProtectedEndpoint(RequiredScope = "esi-location.read_online.v1")]
        [Route("/latest/characters/{character_id}/online/", Version = EndpointVersion.Latest)]
        [Route("/v2/characters/{character_id}/online/", Version = EndpointVersion.V2, Preferred = true)]
        [Route("/v3/characters/{character_id}/online/", Version = EndpointVersion.V3, Preferred = true)]
        [Route("/dev/characters/{character_id}/online/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<Activity>> Online(int characterId, string? token = null);

        /// <summary>
        /// Get the current ship type, name and id
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        [ProtectedEndpoint(RequiredScope = "esi-location.read_ship_type.v1")]
        [Route("/latest/characters/{character_id}/ship/", Version = EndpointVersion.Latest)]
        [Route("/legacy/characters/{character_id}/ship/", Version = EndpointVersion.Legacy)]
        [Route("/v1/characters/{character_id}/ship/", Version = EndpointVersion.V1, Preferred = true)]
        [Route("/v2/characters/{character_id}/ship/", Version = EndpointVersion.V2, Preferred = true)]
        [Route("/dev/characters/{character_id}/ship/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<Ship>> CurrentShip(int characterId, string? token = null);
    }
}
