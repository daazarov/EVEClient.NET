using System.Collections.Generic;
using System.Threading.Tasks;

using EVEClient.NET.Attributes;
using EVEClient.NET.DataContract;

namespace EVEClient.NET
{
    public interface IFittingsLogic
    {
        /// <summary>
        /// Return fittings of a character
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        [ProtectedEndpoint(RequiredScope = "esi-fittings.read_fittings.v1")]
        [Route("/latest/characters/{character_id}/fittings/", Version = EndpointVersion.Latest)]
        [Route("/v2/characters/{character_id}/fittings/", Version = EndpointVersion.V2, Preferred = true)]
        [Route("/dev/characters/{character_id}/fittings/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<List<Fitting>>> GetFittings(int characterId, string? token = null);

        /// <summary>
        /// Save a new fitting for a character
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="fitting">Details about the new fitting</param>
        [ProtectedEndpoint(RequiredScope = "esi-fittings.write_fittings.v1")]
        [Route("/latest/characters/{character_id}/fittings/", Version = EndpointVersion.Latest)]
        [Route("/v2/characters/{character_id}/fittings/", Version = EndpointVersion.V2, Preferred = true)]
        [Route("/dev/characters/{character_id}/fittings/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<NewFittingResponse>> NewFitting(int characterId, NewFitting fitting, string? token = null);

        /// <summary>
        /// Delete a fitting from a character
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        /// <param name="fittingId">ID for a fitting of this character</param>
        [ProtectedEndpoint(RequiredScope = "esi-fittings.write_fittings.v1")]
        [Route("/latest/characters/{character_id}/fittings/{fitting_id}/", Version = EndpointVersion.Latest)]
        [Route("/legacy/characters/{character_id}/fittings/{fitting_id}/", Version = EndpointVersion.Legacy)]
        [Route("/v1/characters/{character_id}/fittings/{fitting_id}/", Version = EndpointVersion.V1, Preferred = true)]
        [Route("/dev/characters/{character_id}/fittings/{fitting_id}/", Version = EndpointVersion.Dev)]
        Task<EsiResponse> DeleteFitting(int characterId, int fittingId, string? token = null);
    }
}
