using System.Collections.Generic;
using System.Threading.Tasks;

using EVEOnline.ESI.Communication.Attributes;
using EVEOnline.ESI.Communication.DataContract;

namespace EVEOnline.ESI.Communication
{
    public interface IClonesLogic
    {
        /// <summary>
        /// A list of the character’s clones
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        [ProtectedEndpoint(RequiredScope = "esi-clones.read_clones.v1")]
        [Route("/latest/characters/{character_id}/clones/", Version = EndpointVersion.Latest)]
        [Route("/v3/characters/{character_id}/clones/", Version = EndpointVersion.V3, Preferred = true)]
        [Route("/v4/characters/{character_id}/clones/", Version = EndpointVersion.V4, Preferred = true)]
        [Route("/dev/characters/{character_id}/clones/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<Clones>> GetCharacterClonesAsync(int characterId);

        /// <summary>
        /// Return implants on the active clone of a character
        /// </summary>
        /// <param name="characterId">An EVE character ID</param>
        [ProtectedEndpoint(RequiredScope = "esi-clones.read_implants.v1")]
        [Route("/latest/characters/{character_id}/implants/", Version = EndpointVersion.Latest)]
        [Route("/legacy/characters/{character_id}/implants/", Version = EndpointVersion.Legacy)]
        [Route("/v1/characters/{character_id}/implants/", Version = EndpointVersion.V1, Preferred = true)]
        [Route("/v2/characters/{character_id}/implants/", Version = EndpointVersion.V2, Preferred = true)]
        [Route("/dev/characters/{character_id}/implants/", Version = EndpointVersion.Dev)]
        Task<EsiResponse<List<int>>> GetCharacterCloneImplantsAsync(int characterId);
    }
}
